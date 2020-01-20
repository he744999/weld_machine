# Stateless 项目 Readme 个人中文翻译

*直接使用.NET 框架创建状态机或基于此技术的轻量级工程流程*

```

var phoneCall = new StateMachine<State, Trigger>(State.OffHook);

phoneCall.Configure(State.OffHook)
    .Permit(Triiger.CallDialled, State.Ringing);

phoneCall.Configure(State.Ringing)
    .Permit(Triiger.CallConnected, State.Connected);

phoneCall.Configure(State.Connected)
    .OnEntry(() => StartCallTimer())
    .OnExit(() => StopCallTimer())
    .Permit(Triiger.LeftMessage, State.OffHook)
    .Permit(Triiger.PlacedOnHold, State.OnHold);

// ...

phoneCall.Fire(Trigger.CallDialled);
Assert.AreEqual(State.Ringing, phoneCall.State);

```

该项目和例子灵感来源于[Simple State Machine](https://archive.codeplex.com/?p=simplestatemachine)

## 特点

状态机中多数的功能都是支持的

* 对状态机的通用支持和 .NET 所有数据类型的支持 (numbers, strings, enums, etc.)
* 层次状态机
* 状态的进入/离开事件
* 事件的条件触发
* 框架自身检查

一些有用的扩展功能同时被提供

* 可在外部储存状态
* 含参数的触发器(事件)
* 重入状态
* 输出 DOT图(Graph description language)

## 层次状态机

下面这个例子中， OnHold 状态属于 Connected 状态的子状态，意味着 Onhold 状态活动时，Connected状态同时处于活动状态

```

phoneCall.Configure(State.OnHold)
    .SubstateOf(State.Connnected)
    .Permit(Trigger.TakenOffHold, State.Connected)
    .Permit(Trigger.PhoneHurledAgainsWall, State.PhoneDestroyed);

```

IsInState(State) 方法可以判断两个状态是否有层次关系, 在上述例子处于 OnHold 状态时， IsInState(State.Connected) 将会得到 true .

## 进入/退出动作

在例子中，在 Call 连接后 StartCallTimer() 将会调用， StopCallTimer() 将会在 Call 挂掉后调用

Call 可在 Connected 和 OnHold 状态中切换，不必使用 StartCallTimer() 和 StopCallTimer() 方法的反复调用，因为OnHold是Connected的子状态

进入/退出动作可由带参数的描述触发者、触发源状态和触发目标状态的 Transition 触发，

## 外部状态储存

Stateless 被设计成可嵌入在各种应用模式中，一些ORM对映射数据的存储位置提出了要求，UI框架通常要求将状态存储在特殊的“可绑定”属性中。 为此，StateMachine 构造函数可以接受将用于读取和写入状态值的函数参数：

```

var stateMachine = new StateMachine<State, Trigger>(
    () => myState.Value,
    s  => myState.Value = s
);

```

在这个例子中， 状态机储存在 myState 对象中

## 自我检查

通过 StateMachine.PermittedTriigers 属性可得到当前状态运行的触发事件，使用 StateMachine.GetInfo() 获取当前状态的配置信息

## 前置条件

一个状态可在同一触发事件下由不同的前置条件进入不同的状态

```

phoneCall.Configure(State.OffHold)
    .PermitIf(Trigger.CallDialled, State.Ringing, () => IsValidNumber)
    .PermitIf(Trigger.CallDialled, State.Beeping, () => !IsValidNumber)

```

前置条件应该是互斥的，子状态可通过重新指定以覆盖触发器， 子状态不会屏蔽超状态的触发条件的(层次状态机的基础),

在触发条件触发后才会检查前置条件，所以前置条件是安全的

## 带参的触发器

可指派带参数的触发器

```

var assignTriiger = stateMachine.SetTriggerParameters<string>(Trigger.Assign)
stateMachine.Configure(State.Assigned)
    .OnEntryFrom(assignTriiger, email => OnAssigned(email))

stateMachine.Fire(assignTrigger, "joe@example.com")

```
带参触发器可动态的选择目标状态，使用 PermitDynamic() 方法即可

## 忽略触发器和自身转换

当触发某个状态未指定的触发器时，框架将会报错，使用 Ignore(Trigger) 可忽略特定的触发器,

```

phoneCall.Configure(State.Connected)
    .Ignore(Trigger.CallDialled)

```

同时一个状态可选择自己作为下一个状态，当然进入和退出事件依然会有效

```

stateMachine.Configure(State.Assigned)
    .PermitReentry(Trigger.Assigned)
    .OnEntry(() => SendEmailToAssignee());

```

默认情况下，你想忽略的触发器需显式的声明，为了方便的屏蔽默认功能，你可以配置一个状态机的 OnUnHandledTrigger 方法：

```

stateMachine.OnUnHandledTriiger((state, trigger) => {});

```

## 输出 DOT 图形化

TODO

##　异步触发器

TODO

## 编译

TODO

##　文档目标

这个文档几乎描述了 Stateless 的所有，它的目标显然是保持轻量化

(为什么命名为 Stateless ？Stateless 实现了状态机理论的相关功能，但在使用委托版本的构造器时，它缺不自己维护任何内部状态)
