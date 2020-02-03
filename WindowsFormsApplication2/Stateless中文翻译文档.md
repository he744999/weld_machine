# Stateless 项目 Readme 个人中文翻译

*这是一个基于.NET实现状态机理论的库,可直接嵌入你的项目中*


```

/// 这里有一个拉绳开关的灯，我们建模其拉一下灯亮，再拉一下灯灭的行为


//  一个灯有两种状态，开(on)和关(off).
enum State {on, off};
//  灯采用拉绳开关，有一个拉绳动作(turn)
enum Trigger {turn};

// 灯初始化状态为关灯
StateMachine _machine = new StateMachine<State, Trigger>(State.off);

// 配置状态State.on在触发器Trigger.turn下转换到状态State.off。在状态进入State.on时，执行OnEntryLightOn()动作
_machine.Configure(State.on).Permit(Trigger.turn, State.off)
	.OnEntry(t => OnEntryLightOn());

// 配置状态State.off在触发器Trigger.turn下转换到状态State.on。在状态进入State.off时，执行OnEntryLightOff()动作
_machine.Configure(State.off).Permit(Trigger.turn, State.on)
	.OnEntry(t => OnEntryLightOff());

// ...
// 触发器Trigger.turn
_machine.Fire(Trigger.turn);

```

## 特点

状态机是一种数学计算模型，不同的实现方式有不同的特点，Stateless如下：

* 对状态机的通用支持和 .NET 所有数据类型的支持 (numbers, strings, enums, etc.)
* 层次状态机
* 状态的进入/离开事件
* 事件的条件触发
* 框架自身检查

一些有用的扩展功能同时被提供

* 可在外部检查状态
* 含参数的触发器(事件)
* 重入状态
* 输出 DOT图(Graph description language)

## 层次状态机

下面这个例子中， 状态Read和Write属于On的子状态，意味着 Read或Write状态活动时，On状态同时处于活动状态（开着灯才能看书和写作, 突然的关灯则需要看书或写作的退出动作）

```

_machine.Configure(State.Read)
    .SubstateOf(State.on)
    .Permit(Trigger.W, State.Write);

_machine.Configure(State.Write)
    .SubstateOf(State.on)
    .Permit(Trigger.R, State.Read);

_machine.Configure(State.on)
    .Permit(Trigger.R, State.Read);

_machine.Configure(State.on)
    .Permit(Trigger.W, State.Write);

```

子状态不会屏蔽超状态的触发条件，即在Write中，turn条件触发后，Off状态将触发

在Stateless中，有IsInState(State)可以判断两个状态的层次关系，上个例子中处于State.Write时，_machine.IsInState(State.On)返回true.

## 进入/退出动作


当状态进入Write时，我们需要笔和纸等，Read时，我们需要一本书，设计出一个状态必然有区别于其他状态的动作，.OnEntry()和.OnExit()等是进入/退出动作

的连接方法。以前大While+If的方式构建模型，需要我们精心的放置If的位置以达到我们的目标，现在你只需要一次构造状态机，然后专心处理状态机的输入和输出

```

_machine.Configure(State.Write)
    .SubstateOf(State.on)
    .Permit(Trigger.R, State.Read)
	.OnEntry(t => OnEntryWrite())  // 进入动作
	.OnExit(t => OnExitWrite());   // 退出动作

```

进入/退出动作可由带参数的描述触发者、触发源状态和触发目标状态的 Transition 触发，

## 外部检查

状态机嵌入到你的程序后，你有了绑定当前状态到某个属性到中的需求，Stateless未采用类似_machine.CurrentState()的方法, 而是绑定到状态机初始化参数的变量中


```

var stateMachine = new StateMachine<State, Trigger>(
    () => _state,
    s  => _state = s
);

/* 

StateMachine(Func<TState> stateAccessor, Action<TState> stateMutator);

stateAccessor: Func委托，调用这个函数去读取当前状态

stateMutator: Action委托，调用这个去写入新的状态值


string CurrentState = _machine._state.toString();  //获取当前状态到变量中
*/

```


## 自我检查

通过 StateMachine.PermittedTriigers 属性可得到当前状态可触发事件，使用 StateMachine.GetInfo() 获取当前状态的配置信息

## 前置条件?


这是我个人不推荐使用的功能，这功能是在触发条件下增加一个If判断，状态机的存在就是消除显式的If，以得到清晰易梳理的控制。


```

_machine.Configure(State.off)
	.PermitIf(Trigger.turn, State.on, () => IsEvectricity()) // 拉绳动作后判断当前是否有电费， 没电费不能开灯辣：）
	.OnEntry(t => OnEntryLightOff());

```

同一个状态的前置条件应该是互斥的，子状态可通过重新指定以覆盖触发器， 

在触发条件触发后才会检查前置条件，所以前置条件是安全的

## 带参的触发器


触发条件可指派带参数的


```

var WriteSomething= stateMachine.SetTriggerParameters<string>(Trigger.Assign)

stateMachine.Configure(State.Assigned)
    .OnEntryFrom(WriteSomething, text => OnAssigned(text))

stateMachine.Fire(WriteSomething, "Hello, world！")

```


## 忽略触发器和自身转换


当触发器是状态未订阅的时，Stateless将默认会引发一个Exception，这可不行鸭！Ignore() 忽略单个触发器

_machine.OnUnhandledTrigger((state, trigger) => { }) // 将忽略所有的未订阅触发器

```


_machine.Configure(State.off).Permit(Trigger.turn, State.on)
	.OnEntry(t => OnEntryLightOff())
	.Ignore(Trigger.W);  // 忽略单个触发器

_machine.OnUnhandledTrigger((state, trigger) => { }); // 忽略所有未订阅触发器

```

一个状态可选择自己作为下一个状态，进入和退出事件依然会有效

```

stateMachine.Configure(State.on)
    .PermitReentry(Trigger.check)
    .OnEntry(() => OnEntryOn());

```


TODO

##　异步触发器

TODO

## 编译

TODO

##　文档目标

这个文档几乎描述了 Stateless 的所有，它的目标显然是保持轻量化

(为什么命名为 Stateless ？Stateless 实现了状态机理论的相关功能，但在使用委托版本的构造器时，它缺不自己维护任何内部状态)
？？？ 理解：Stateless好用到你感觉不到库的存在



