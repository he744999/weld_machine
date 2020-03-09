namespace DXApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage_Run = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer1 = new DevExpress.XtraBars.TabFormContentContainer();
            this.textEdit_AllPans = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl_zsd = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_m3State = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toggleSwitch_ShowModel = new DevExpress.XtraEditors.ToggleSwitch();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton33 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton32 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton25 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch9 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_m3cang2 = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch_Cang2BigDoor = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_Cang2SmallDoor = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_Cheng2Door = new DevExpress.XtraEditors.ToggleSwitch();
            this.textEdit_target2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Cheng2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_m3cang1 = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch_Cang1BigDoor = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_Cang1SmallDoor = new DevExpress.XtraEditors.ToggleSwitch();
            this.toggleSwitch_Cheng1Door = new DevExpress.XtraEditors.ToggleSwitch();
            this.textEdit_target1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton_Cheng1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabFormPage_Setup = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.labelControl32 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl31 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl29 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton41 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.toggleSwitch10 = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.toggleSwitch5 = new DevExpress.XtraEditors.ToggleSwitch();
            this.tabFormPage_Light = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer3 = new DevExpress.XtraBars.TabFormContentContainer();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabFormPage_Sql = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer4 = new DevExpress.XtraBars.TabFormContentContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new DXApplication1.testDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton16 = new DevExpress.XtraEditors.SimpleButton();
            this.tabFormPage_Test = new DevExpress.XtraBars.TabFormPage();
            this.tabFormContentContainer6 = new DevExpress.XtraBars.TabFormContentContainer();
            this.simpleButton42 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton35 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton34 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton17 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton36 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton37 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton38 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton39 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.simpleButton40 = new DevExpress.XtraEditors.SimpleButton();
            this.timer_UI_loop = new System.Windows.Forms.Timer(this.components);
            this.timerInput = new System.Windows.Forms.Timer(this.components);
            this.diagramControl1 = new DevExpress.XtraDiagram.DiagramControl();
            this.timerDataUpdate = new System.Windows.Forms.Timer(this.components);
            this.bbiShow = new DevExpress.XtraBars.BarButtonItem();
            this.testDataSet = new DXApplication1.testDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new DXApplication1.testDataSet1TableAdapters.UserTableAdapter();
            this.textEdit_targ1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_targ2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.tabFormContentContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AllPans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_ShowModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang2BigDoor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang2SmallDoor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cheng2Door.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_target2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang1BigDoor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang1SmallDoor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cheng1Door.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_target1.Properties)).BeginInit();
            this.tabFormContentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch5.Properties)).BeginInit();
            this.tabFormContentContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabFormContentContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tabFormContentContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_targ1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_targ2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage_Run);
            this.tabFormControl1.Pages.Add(this.tabFormPage_Setup);
            this.tabFormControl1.Pages.Add(this.tabFormPage_Light);
            this.tabFormControl1.Pages.Add(this.tabFormPage_Sql);
            this.tabFormControl1.Pages.Add(this.tabFormPage_Test);
            this.tabFormControl1.SelectedPage = this.tabFormPage_Run;
            this.tabFormControl1.Size = new System.Drawing.Size(1075, 51);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabRightItemLinks.Add(this.barButtonItem3);
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.TitleItemLinks.Add(this.barButtonItem1);
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "test";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "begin";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "No ";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.DockingEnabled = false;
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.tabFormDefaultManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 51);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(1075, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 550);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(1075, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 499);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1075, 51);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 499);
            // 
            // tabFormPage_Run
            // 
            this.tabFormPage_Run.ContentContainer = this.tabFormContentContainer1;
            this.tabFormPage_Run.Name = "tabFormPage_Run";
            this.tabFormPage_Run.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage_Run.Text = "Run";
            // 
            // tabFormContentContainer1
            // 
            this.tabFormContentContainer1.Controls.Add(this.textEdit_targ2);
            this.tabFormContentContainer1.Controls.Add(this.textEdit_targ1);
            this.tabFormContentContainer1.Controls.Add(this.textEdit_AllPans);
            this.tabFormContentContainer1.Controls.Add(this.labelControl11);
            this.tabFormContentContainer1.Controls.Add(this.labelControl_zsd);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton_m3State);
            this.tabFormContentContainer1.Controls.Add(this.labelControl1);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch_ShowModel);
            this.tabFormContentContainer1.Controls.Add(this.textEdit11);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton33);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton32);
            this.tabFormContentContainer1.Controls.Add(this.labelControl25);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton25);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton10);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch9);
            this.tabFormContentContainer1.Controls.Add(this.labelControl24);
            this.tabFormContentContainer1.Controls.Add(this.labelControl15);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton_m3cang2);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch_Cang2BigDoor);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch_Cang2SmallDoor);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch_Cheng2Door);
            this.tabFormContentContainer1.Controls.Add(this.textEdit_target2);
            this.tabFormContentContainer1.Controls.Add(this.labelControl16);
            this.tabFormContentContainer1.Controls.Add(this.labelControl17);
            this.tabFormContentContainer1.Controls.Add(this.labelControl18);
            this.tabFormContentContainer1.Controls.Add(this.labelControl19);
            this.tabFormContentContainer1.Controls.Add(this.labelControl20);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton_Cheng2);
            this.tabFormContentContainer1.Controls.Add(this.labelControl13);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton_m3cang1);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch_Cang1BigDoor);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch_Cang1SmallDoor);
            this.tabFormContentContainer1.Controls.Add(this.toggleSwitch_Cheng1Door);
            this.tabFormContentContainer1.Controls.Add(this.textEdit_target1);
            this.tabFormContentContainer1.Controls.Add(this.labelControl6);
            this.tabFormContentContainer1.Controls.Add(this.labelControl4);
            this.tabFormContentContainer1.Controls.Add(this.labelControl5);
            this.tabFormContentContainer1.Controls.Add(this.labelControl3);
            this.tabFormContentContainer1.Controls.Add(this.labelControl2);
            this.tabFormContentContainer1.Controls.Add(this.simpleButton_Cheng1);
            this.tabFormContentContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer1.Location = new System.Drawing.Point(0, 51);
            this.tabFormContentContainer1.Name = "tabFormContentContainer1";
            this.tabFormContentContainer1.Size = new System.Drawing.Size(1075, 499);
            this.tabFormContentContainer1.TabIndex = 1;
            // 
            // textEdit_AllPans
            // 
            this.textEdit_AllPans.EditValue = "100";
            this.textEdit_AllPans.Location = new System.Drawing.Point(259, 289);
            this.textEdit_AllPans.MenuManager = this.tabFormDefaultManager1;
            this.textEdit_AllPans.Name = "textEdit_AllPans";
            this.textEdit_AllPans.Properties.Mask.EditMask = "d";
            this.textEdit_AllPans.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_AllPans.Size = new System.Drawing.Size(100, 20);
            this.textEdit_AllPans.TabIndex = 77;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(194, 290);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 14);
            this.labelControl11.TabIndex = 76;
            this.labelControl11.Text = "目标值";
            // 
            // labelControl_zsd
            // 
            this.labelControl_zsd.Location = new System.Drawing.Point(756, 44);
            this.labelControl_zsd.Name = "labelControl_zsd";
            this.labelControl_zsd.Size = new System.Drawing.Size(48, 14);
            this.labelControl_zsd.TabIndex = 75;
            this.labelControl_zsd.Text = "当前状态";
            // 
            // simpleButton_m3State
            // 
            this.simpleButton_m3State.Location = new System.Drawing.Point(822, 40);
            this.simpleButton_m3State.Name = "simpleButton_m3State";
            this.simpleButton_m3State.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_m3State.TabIndex = 74;
            this.simpleButton_m3State.Text = "-----";
            this.simpleButton_m3State.Click += new System.EventHandler(this.simpleButton_m3State_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(91, 456);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "Model 窗口";
            // 
            // toggleSwitch_ShowModel
            // 
            this.toggleSwitch_ShowModel.Location = new System.Drawing.Point(165, 454);
            this.toggleSwitch_ShowModel.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch_ShowModel.Name = "toggleSwitch_ShowModel";
            this.toggleSwitch_ShowModel.Properties.OffText = "Off";
            this.toggleSwitch_ShowModel.Properties.OnText = "On";
            this.toggleSwitch_ShowModel.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_ShowModel.TabIndex = 72;
            this.toggleSwitch_ShowModel.Toggled += new System.EventHandler(this.toggleSwitch_ShowModel_Toggled);
            // 
            // textEdit11
            // 
            this.textEdit11.Location = new System.Drawing.Point(1, 353);
            this.textEdit11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit11.MenuManager = this.tabFormDefaultManager1;
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Size = new System.Drawing.Size(109, 20);
            this.textEdit11.TabIndex = 71;
            // 
            // simpleButton33
            // 
            this.simpleButton33.Location = new System.Drawing.Point(465, 9);
            this.simpleButton33.Name = "simpleButton33";
            this.simpleButton33.Size = new System.Drawing.Size(177, 23);
            this.simpleButton33.TabIndex = 68;
            this.simpleButton33.Text = "料仓2";
            // 
            // simpleButton32
            // 
            this.simpleButton32.Location = new System.Drawing.Point(104, 7);
            this.simpleButton32.Name = "simpleButton32";
            this.simpleButton32.Size = new System.Drawing.Size(177, 23);
            this.simpleButton32.TabIndex = 67;
            this.simpleButton32.Text = "料仓1";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(405, 392);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(72, 14);
            this.labelControl25.TabIndex = 66;
            this.labelControl25.Text = "生成控制状态";
            // 
            // simpleButton25
            // 
            this.simpleButton25.Location = new System.Drawing.Point(76, 392);
            this.simpleButton25.Name = "simpleButton25";
            this.simpleButton25.Size = new System.Drawing.Size(75, 23);
            this.simpleButton25.TabIndex = 65;
            this.simpleButton25.Text = "TEST";
            this.simpleButton25.Click += new System.EventHandler(this.simpleButton25_Click_1);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Location = new System.Drawing.Point(512, 383);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(75, 23);
            this.simpleButton10.TabIndex = 64;
            this.simpleButton10.Text = "REREADY";
            // 
            // toggleSwitch9
            // 
            this.toggleSwitch9.Location = new System.Drawing.Point(512, 352);
            this.toggleSwitch9.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch9.Name = "toggleSwitch9";
            this.toggleSwitch9.Properties.OffText = "Off";
            this.toggleSwitch9.Properties.OnText = "On";
            this.toggleSwitch9.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch9.TabIndex = 63;
            this.toggleSwitch9.Toggled += new System.EventHandler(this.toggleSwitch9_Toggled);
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(405, 357);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(96, 14);
            this.labelControl24.TabIndex = 62;
            this.labelControl24.Text = "生成控制临时界面";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(558, 122);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(48, 14);
            this.labelControl15.TabIndex = 43;
            this.labelControl15.Text = "当前状态";
            // 
            // simpleButton_m3cang2
            // 
            this.simpleButton_m3cang2.Location = new System.Drawing.Point(617, 122);
            this.simpleButton_m3cang2.Name = "simpleButton_m3cang2";
            this.simpleButton_m3cang2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_m3cang2.TabIndex = 42;
            this.simpleButton_m3cang2.Text = "-----";
            // 
            // toggleSwitch_Cang2BigDoor
            // 
            this.toggleSwitch_Cang2BigDoor.Location = new System.Drawing.Point(457, 115);
            this.toggleSwitch_Cang2BigDoor.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch_Cang2BigDoor.Name = "toggleSwitch_Cang2BigDoor";
            this.toggleSwitch_Cang2BigDoor.Properties.OffText = "Off";
            this.toggleSwitch_Cang2BigDoor.Properties.OnText = "On";
            this.toggleSwitch_Cang2BigDoor.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_Cang2BigDoor.TabIndex = 40;
            // 
            // toggleSwitch_Cang2SmallDoor
            // 
            this.toggleSwitch_Cang2SmallDoor.Location = new System.Drawing.Point(482, 77);
            this.toggleSwitch_Cang2SmallDoor.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch_Cang2SmallDoor.Name = "toggleSwitch_Cang2SmallDoor";
            this.toggleSwitch_Cang2SmallDoor.Properties.OffText = "Off";
            this.toggleSwitch_Cang2SmallDoor.Properties.OnText = "On";
            this.toggleSwitch_Cang2SmallDoor.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_Cang2SmallDoor.TabIndex = 39;
            // 
            // toggleSwitch_Cheng2Door
            // 
            this.toggleSwitch_Cheng2Door.Location = new System.Drawing.Point(457, 223);
            this.toggleSwitch_Cheng2Door.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch_Cheng2Door.Name = "toggleSwitch_Cheng2Door";
            this.toggleSwitch_Cheng2Door.Properties.OffText = "Off";
            this.toggleSwitch_Cheng2Door.Properties.OnText = "On";
            this.toggleSwitch_Cheng2Door.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_Cheng2Door.TabIndex = 38;
            // 
            // textEdit_target2
            // 
            this.textEdit_target2.EditValue = "200";
            this.textEdit_target2.Location = new System.Drawing.Point(577, 154);
            this.textEdit_target2.MenuManager = this.tabFormDefaultManager1;
            this.textEdit_target2.Name = "textEdit_target2";
            this.textEdit_target2.Properties.Mask.EditMask = "d";
            this.textEdit_target2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_target2.Size = new System.Drawing.Size(100, 20);
            this.textEdit_target2.TabIndex = 37;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(392, 160);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(36, 14);
            this.labelControl16.TabIndex = 36;
            this.labelControl16.Text = "目标值";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(392, 120);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(36, 14);
            this.labelControl17.TabIndex = 35;
            this.labelControl17.Text = "仓大门";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(392, 82);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(36, 14);
            this.labelControl18.TabIndex = 34;
            this.labelControl18.Text = "仓小门";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(392, 228);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(24, 14);
            this.labelControl19.TabIndex = 33;
            this.labelControl19.Text = "称门";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(392, 188);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(36, 14);
            this.labelControl20.TabIndex = 32;
            this.labelControl20.Text = "称示数";
            // 
            // simpleButton_Cheng2
            // 
            this.simpleButton_Cheng2.Location = new System.Drawing.Point(455, 185);
            this.simpleButton_Cheng2.Name = "simpleButton_Cheng2";
            this.simpleButton_Cheng2.Size = new System.Drawing.Size(85, 26);
            this.simpleButton_Cheng2.TabIndex = 31;
            this.simpleButton_Cheng2.Text = "0";
            this.simpleButton_Cheng2.Click += new System.EventHandler(this.simpleButton_Cheng2_Click);
            this.simpleButton_Cheng2.DoubleClick += new System.EventHandler(this.simpleButton_Cheng2_DoubleClick);
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(204, 120);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(48, 14);
            this.labelControl13.TabIndex = 26;
            this.labelControl13.Text = "当前状态";
            // 
            // simpleButton_m3cang1
            // 
            this.simpleButton_m3cang1.Location = new System.Drawing.Point(258, 116);
            this.simpleButton_m3cang1.Name = "simpleButton_m3cang1";
            this.simpleButton_m3cang1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_m3cang1.TabIndex = 25;
            this.simpleButton_m3cang1.Text = "-----";
            // 
            // toggleSwitch_Cang1BigDoor
            // 
            this.toggleSwitch_Cang1BigDoor.Location = new System.Drawing.Point(98, 115);
            this.toggleSwitch_Cang1BigDoor.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch_Cang1BigDoor.Name = "toggleSwitch_Cang1BigDoor";
            this.toggleSwitch_Cang1BigDoor.Properties.OffText = "Off";
            this.toggleSwitch_Cang1BigDoor.Properties.OnText = "On";
            this.toggleSwitch_Cang1BigDoor.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_Cang1BigDoor.TabIndex = 14;
            // 
            // toggleSwitch_Cang1SmallDoor
            // 
            this.toggleSwitch_Cang1SmallDoor.Location = new System.Drawing.Point(127, 77);
            this.toggleSwitch_Cang1SmallDoor.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch_Cang1SmallDoor.Name = "toggleSwitch_Cang1SmallDoor";
            this.toggleSwitch_Cang1SmallDoor.Properties.OffText = "Off";
            this.toggleSwitch_Cang1SmallDoor.Properties.OnText = "On";
            this.toggleSwitch_Cang1SmallDoor.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_Cang1SmallDoor.TabIndex = 13;
            // 
            // toggleSwitch_Cheng1Door
            // 
            this.toggleSwitch_Cheng1Door.Location = new System.Drawing.Point(97, 225);
            this.toggleSwitch_Cheng1Door.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch_Cheng1Door.Name = "toggleSwitch_Cheng1Door";
            this.toggleSwitch_Cheng1Door.Properties.OffText = "Off";
            this.toggleSwitch_Cheng1Door.Properties.OnText = "On";
            this.toggleSwitch_Cheng1Door.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch_Cheng1Door.TabIndex = 12;
            // 
            // textEdit_target1
            // 
            this.textEdit_target1.EditValue = "100";
            this.textEdit_target1.Location = new System.Drawing.Point(233, 155);
            this.textEdit_target1.MenuManager = this.tabFormDefaultManager1;
            this.textEdit_target1.Name = "textEdit_target1";
            this.textEdit_target1.Properties.Mask.EditMask = "d";
            this.textEdit_target1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_target1.Size = new System.Drawing.Size(100, 20);
            this.textEdit_target1.TabIndex = 9;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(33, 152);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "目标值";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "仓大门";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "仓小门";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(45, 234);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "称门";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 185);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "称示数";
            // 
            // simpleButton_Cheng1
            // 
            this.simpleButton_Cheng1.Location = new System.Drawing.Point(97, 185);
            this.simpleButton_Cheng1.Name = "simpleButton_Cheng1";
            this.simpleButton_Cheng1.Size = new System.Drawing.Size(85, 26);
            this.simpleButton_Cheng1.TabIndex = 0;
            this.simpleButton_Cheng1.Text = "0";
            this.simpleButton_Cheng1.DoubleClick += new System.EventHandler(this.simpleButton_Cheng1_DoubleClick);
            // 
            // tabFormPage_Setup
            // 
            this.tabFormPage_Setup.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPage_Setup.Name = "tabFormPage_Setup";
            this.tabFormPage_Setup.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage_Setup.Text = "Setup";
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Controls.Add(this.labelControl32);
            this.tabFormContentContainer2.Controls.Add(this.labelControl31);
            this.tabFormContentContainer2.Controls.Add(this.labelControl28);
            this.tabFormContentContainer2.Controls.Add(this.labelControl29);
            this.tabFormContentContainer2.Controls.Add(this.simpleButton41);
            this.tabFormContentContainer2.Controls.Add(this.comboBox2);
            this.tabFormContentContainer2.Controls.Add(this.labelControl30);
            this.tabFormContentContainer2.Controls.Add(this.checkEdit2);
            this.tabFormContentContainer2.Controls.Add(this.toggleSwitch10);
            this.tabFormContentContainer2.Controls.Add(this.labelControl10);
            this.tabFormContentContainer2.Controls.Add(this.labelControl9);
            this.tabFormContentContainer2.Controls.Add(this.simpleButton6);
            this.tabFormContentContainer2.Controls.Add(this.comboBox1);
            this.tabFormContentContainer2.Controls.Add(this.labelControl8);
            this.tabFormContentContainer2.Controls.Add(this.checkEdit1);
            this.tabFormContentContainer2.Controls.Add(this.toggleSwitch5);
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 51);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(1075, 499);
            this.tabFormContentContainer2.TabIndex = 4;
            // 
            // labelControl32
            // 
            this.labelControl32.Location = new System.Drawing.Point(655, 93);
            this.labelControl32.Name = "labelControl32";
            this.labelControl32.Size = new System.Drawing.Size(72, 14);
            this.labelControl32.TabIndex = 19;
            this.labelControl32.Text = "步进电机串口";
            // 
            // labelControl31
            // 
            this.labelControl31.Location = new System.Drawing.Point(243, 93);
            this.labelControl31.Name = "labelControl31";
            this.labelControl31.Size = new System.Drawing.Size(66, 14);
            this.labelControl31.TabIndex = 18;
            this.labelControl31.Text = "Modbus串口";
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(629, 222);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(101, 14);
            this.labelControl28.TabIndex = 17;
            this.labelControl28.Text = "No communication";
            // 
            // labelControl29
            // 
            this.labelControl29.Location = new System.Drawing.Point(545, 222);
            this.labelControl29.Name = "labelControl29";
            this.labelControl29.Size = new System.Drawing.Size(52, 14);
            this.labelControl29.TabIndex = 16;
            this.labelControl29.Text = "Serial消息";
            // 
            // simpleButton41
            // 
            this.simpleButton41.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton41.ImageOptions.Image")));
            this.simpleButton41.Location = new System.Drawing.Point(748, 123);
            this.simpleButton41.Name = "simpleButton41";
            this.simpleButton41.Size = new System.Drawing.Size(68, 22);
            this.simpleButton41.TabIndex = 15;
            this.simpleButton41.Text = "刷新";
            this.simpleButton41.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(621, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 14;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(545, 186);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(52, 14);
            this.labelControl30.TabIndex = 13;
            this.labelControl30.Text = "Serial状态";
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(622, 156);
            this.checkEdit2.MenuManager = this.tabFormDefaultManager1;
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "自动连接";
            this.checkEdit2.Size = new System.Drawing.Size(75, 19);
            this.checkEdit2.TabIndex = 12;
            // 
            // toggleSwitch10
            // 
            this.toggleSwitch10.Location = new System.Drawing.Point(622, 181);
            this.toggleSwitch10.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch10.Name = "toggleSwitch10";
            this.toggleSwitch10.Properties.OffText = "Off";
            this.toggleSwitch10.Properties.OnText = "On";
            this.toggleSwitch10.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch10.TabIndex = 11;
            this.toggleSwitch10.Toggled += new System.EventHandler(this.toggleSwitch10_Toggled);
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(219, 230);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(101, 14);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "No communication";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(135, 230);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(52, 14);
            this.labelControl9.TabIndex = 9;
            this.labelControl9.Text = "Serial消息";
            // 
            // simpleButton6
            // 
            this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.simpleButton6.Location = new System.Drawing.Point(338, 131);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(68, 22);
            this.simpleButton6.TabIndex = 8;
            this.simpleButton6.Text = "刷新";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(135, 194);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 14);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "Serial状态";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(212, 164);
            this.checkEdit1.MenuManager = this.tabFormDefaultManager1;
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "自动连接";
            this.checkEdit1.Size = new System.Drawing.Size(75, 19);
            this.checkEdit1.TabIndex = 4;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // toggleSwitch5
            // 
            this.toggleSwitch5.Location = new System.Drawing.Point(212, 189);
            this.toggleSwitch5.MenuManager = this.tabFormDefaultManager1;
            this.toggleSwitch5.Name = "toggleSwitch5";
            this.toggleSwitch5.Properties.OffText = "Off";
            this.toggleSwitch5.Properties.OnText = "On";
            this.toggleSwitch5.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch5.TabIndex = 3;
            this.toggleSwitch5.Toggled += new System.EventHandler(this.toggleSwitch5_Toggled);
            // 
            // tabFormPage_Light
            // 
            this.tabFormPage_Light.ContentContainer = this.tabFormContentContainer3;
            this.tabFormPage_Light.Name = "tabFormPage_Light";
            this.tabFormPage_Light.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage_Light.Text = "Light";
            // 
            // tabFormContentContainer3
            // 
            this.tabFormContentContainer3.Controls.Add(this.labelControl35);
            this.tabFormContentContainer3.Controls.Add(this.labelControl14);
            this.tabFormContentContainer3.Controls.Add(this.pictureBox1);
            this.tabFormContentContainer3.Controls.Add(this.simpleButton4);
            this.tabFormContentContainer3.Controls.Add(this.simpleButton3);
            this.tabFormContentContainer3.Controls.Add(this.simpleButton2);
            this.tabFormContentContainer3.Controls.Add(this.simpleButton1);
            this.tabFormContentContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer3.Location = new System.Drawing.Point(0, 51);
            this.tabFormContentContainer3.Name = "tabFormContentContainer3";
            this.tabFormContentContainer3.Size = new System.Drawing.Size(1075, 499);
            this.tabFormContentContainer3.TabIndex = 5;
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(127, 130);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(12, 14);
            this.labelControl35.TabIndex = 18;
            this.labelControl35.Text = "---";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(50, 130);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(48, 14);
            this.labelControl14.TabIndex = 17;
            this.labelControl14.Text = "当前状态";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(12, 177);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(60, 31);
            this.simpleButton4.TabIndex = 6;
            this.simpleButton4.Text = "turn";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(108, 238);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(60, 31);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "W";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(108, 201);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(60, 31);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "R";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(108, 164);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(60, 31);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "TURN";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tabFormPage_Sql
            // 
            this.tabFormPage_Sql.ContentContainer = this.tabFormContentContainer4;
            this.tabFormPage_Sql.Name = "tabFormPage_Sql";
            this.tabFormPage_Sql.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage_Sql.Text = "SQL";
            // 
            // tabFormContentContainer4
            // 
            this.tabFormContentContainer4.Controls.Add(this.gridControl1);
            this.tabFormContentContainer4.Controls.Add(this.simpleButton16);
            this.tabFormContentContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer4.Location = new System.Drawing.Point(0, 51);
            this.tabFormContentContainer4.Name = "tabFormContentContainer4";
            this.tabFormContentContainer4.Size = new System.Drawing.Size(1075, 499);
            this.tabFormContentContainer4.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.userBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.tabFormDefaultManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 499);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.testDataSet1;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "testDataSet1";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colpassword});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", null, "(ID: Count={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 94;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 94;
            // 
            // colpassword
            // 
            this.colpassword.FieldName = "password";
            this.colpassword.MinWidth = 25;
            this.colpassword.Name = "colpassword";
            this.colpassword.Visible = true;
            this.colpassword.VisibleIndex = 2;
            this.colpassword.Width = 94;
            // 
            // simpleButton16
            // 
            this.simpleButton16.Location = new System.Drawing.Point(719, 60);
            this.simpleButton16.Name = "simpleButton16";
            this.simpleButton16.Size = new System.Drawing.Size(75, 23);
            this.simpleButton16.TabIndex = 0;
            this.simpleButton16.Text = "Connect";
            this.simpleButton16.Click += new System.EventHandler(this.simpleButton16_Click);
            // 
            // tabFormPage_Test
            // 
            this.tabFormPage_Test.ContentContainer = this.tabFormContentContainer6;
            this.tabFormPage_Test.Name = "tabFormPage_Test";
            this.tabFormPage_Test.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage_Test.Text = "TEST";
            // 
            // tabFormContentContainer6
            // 
            this.tabFormContentContainer6.Controls.Add(this.simpleButton42);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton35);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton34);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton17);
            this.tabFormContentContainer6.Controls.Add(this.labelControl34);
            this.tabFormContentContainer6.Controls.Add(this.labelControl33);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton36);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton37);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton38);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton39);
            this.tabFormContentContainer6.Controls.Add(this.textBox1);
            this.tabFormContentContainer6.Controls.Add(this.simpleButton40);
            this.tabFormContentContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer6.Location = new System.Drawing.Point(0, 51);
            this.tabFormContentContainer6.Name = "tabFormContentContainer6";
            this.tabFormContentContainer6.Size = new System.Drawing.Size(1075, 499);
            this.tabFormContentContainer6.TabIndex = 4;
            // 
            // simpleButton42
            // 
            this.simpleButton42.Location = new System.Drawing.Point(239, 225);
            this.simpleButton42.Name = "simpleButton42";
            this.simpleButton42.Size = new System.Drawing.Size(75, 23);
            this.simpleButton42.TabIndex = 45;
            this.simpleButton42.Text = "START";
            this.simpleButton42.Click += new System.EventHandler(this.simpleButton42_Click);
            // 
            // simpleButton35
            // 
            this.simpleButton35.Location = new System.Drawing.Point(500, 325);
            this.simpleButton35.Name = "simpleButton35";
            this.simpleButton35.Size = new System.Drawing.Size(75, 23);
            this.simpleButton35.TabIndex = 44;
            this.simpleButton35.Text = "REREADY";
            this.simpleButton35.Click += new System.EventHandler(this.simpleButton35_Click);
            // 
            // simpleButton34
            // 
            this.simpleButton34.Location = new System.Drawing.Point(500, 285);
            this.simpleButton34.Name = "simpleButton34";
            this.simpleButton34.Size = new System.Drawing.Size(75, 23);
            this.simpleButton34.TabIndex = 43;
            this.simpleButton34.Text = "TOGGLE";
            this.simpleButton34.Click += new System.EventHandler(this.simpleButton34_Click);
            // 
            // simpleButton17
            // 
            this.simpleButton17.Location = new System.Drawing.Point(500, 238);
            this.simpleButton17.Name = "simpleButton17";
            this.simpleButton17.Size = new System.Drawing.Size(75, 23);
            this.simpleButton17.TabIndex = 42;
            this.simpleButton17.Text = "START";
            this.simpleButton17.Click += new System.EventHandler(this.simpleButton17_Click_1);
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(768, 105);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(12, 14);
            this.labelControl34.TabIndex = 41;
            this.labelControl34.Text = "---";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(678, 108);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(48, 14);
            this.labelControl33.TabIndex = 40;
            this.labelControl33.Text = "当前状态";
            // 
            // simpleButton36
            // 
            this.simpleButton36.Location = new System.Drawing.Point(272, 88);
            this.simpleButton36.Name = "simpleButton36";
            this.simpleButton36.Size = new System.Drawing.Size(75, 23);
            this.simpleButton36.TabIndex = 39;
            this.simpleButton36.Text = "~";
            this.simpleButton36.Click += new System.EventHandler(this.simpleButton36_Click);
            // 
            // simpleButton37
            // 
            this.simpleButton37.Location = new System.Drawing.Point(191, 88);
            this.simpleButton37.Name = "simpleButton37";
            this.simpleButton37.Size = new System.Drawing.Size(75, 23);
            this.simpleButton37.TabIndex = 38;
            this.simpleButton37.Text = "!";
            this.simpleButton37.Click += new System.EventHandler(this.simpleButton37_Click);
            // 
            // simpleButton38
            // 
            this.simpleButton38.Location = new System.Drawing.Point(191, 142);
            this.simpleButton38.Name = "simpleButton38";
            this.simpleButton38.Size = new System.Drawing.Size(75, 23);
            this.simpleButton38.TabIndex = 37;
            this.simpleButton38.Text = "?";
            this.simpleButton38.Click += new System.EventHandler(this.simpleButton38_Click);
            // 
            // simpleButton39
            // 
            this.simpleButton39.Location = new System.Drawing.Point(369, 146);
            this.simpleButton39.Name = "simpleButton39";
            this.simpleButton39.Size = new System.Drawing.Size(75, 23);
            this.simpleButton39.TabIndex = 36;
            this.simpleButton39.Text = "CtrlX";
            this.simpleButton39.Click += new System.EventHandler(this.simpleButton39_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 21);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "?";
            // 
            // simpleButton40
            // 
            this.simpleButton40.Location = new System.Drawing.Point(369, 117);
            this.simpleButton40.Name = "simpleButton40";
            this.simpleButton40.Size = new System.Drawing.Size(75, 23);
            this.simpleButton40.TabIndex = 34;
            this.simpleButton40.Text = "Send";
            this.simpleButton40.Click += new System.EventHandler(this.simpleButton40_Click);
            // 
            // timer_UI_loop
            // 
            this.timer_UI_loop.Interval = 10;
            this.timer_UI_loop.Tick += new System.EventHandler(this.timer_UI_loop_Tick);
            // 
            // timerInput
            // 
            this.timerInput.Tick += new System.EventHandler(this.timerInput_Tick);
            // 
            // diagramControl1
            // 
            this.diagramControl1.Location = new System.Drawing.Point(309, 21);
            this.diagramControl1.Name = "diagramControl1";
            this.diagramControl1.OptionsBehavior.SelectedStencils = new DevExpress.Diagram.Core.StencilCollection(new string[] {
            "BasicShapes",
            "BasicFlowchartShapes",
            "ArrowShapes",
            "SoftwareIcons",
            "SDLDiagramShapes"});
            this.diagramControl1.OptionsView.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.diagramControl1.OptionsView.ShowGrid = false;
            this.diagramControl1.OptionsView.ShowPageBreaks = false;
            this.diagramControl1.OptionsView.ShowRulers = false;
            this.diagramControl1.OptionsView.Theme = DevExpress.Diagram.Core.DiagramThemes.Sequence;
            this.diagramControl1.Size = new System.Drawing.Size(435, 334);
            this.diagramControl1.TabIndex = 7;
            this.diagramControl1.Text = "diagramControl1";
            // 
            // timerDataUpdate
            // 
            this.timerDataUpdate.Interval = 10;
            this.timerDataUpdate.Tick += new System.EventHandler(this.timerDataUpdate_Tick);
            // 
            // bbiShow
            // 
            this.bbiShow.Caption = "Show";
            this.bbiShow.Id = -1;
            this.bbiShow.ImageOptions.ImageUri.Uri = "Show";
            this.bbiShow.Name = "bbiShow";
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // textEdit_targ1
            // 
            this.textEdit_targ1.EditValue = "----";
            this.textEdit_targ1.Location = new System.Drawing.Point(98, 154);
            this.textEdit_targ1.MenuManager = this.tabFormDefaultManager1;
            this.textEdit_targ1.Name = "textEdit_targ1";
            this.textEdit_targ1.Properties.Mask.EditMask = "d";
            this.textEdit_targ1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_targ1.Size = new System.Drawing.Size(100, 20);
            this.textEdit_targ1.TabIndex = 78;
            // 
            // textEdit_targ2
            // 
            this.textEdit_targ2.EditValue = "----";
            this.textEdit_targ2.Location = new System.Drawing.Point(455, 154);
            this.textEdit_targ2.MenuManager = this.tabFormDefaultManager1;
            this.textEdit_targ2.Name = "textEdit_targ2";
            this.textEdit_targ2.Properties.Mask.EditMask = "d";
            this.textEdit_targ2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_targ2.Size = new System.Drawing.Size(100, 20);
            this.textEdit_targ2.TabIndex = 79;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 550);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.tabFormContentContainer1);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.tabFormContentContainer1.ResumeLayout(false);
            this.tabFormContentContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_AllPans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_ShowModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang2BigDoor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang2SmallDoor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cheng2Door.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_target2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang1BigDoor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cang1SmallDoor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch_Cheng1Door.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_target1.Properties)).EndInit();
            this.tabFormContentContainer2.ResumeLayout(false);
            this.tabFormContentContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch5.Properties)).EndInit();
            this.tabFormContentContainer3.ResumeLayout(false);
            this.tabFormContentContainer3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabFormContentContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tabFormContentContainer6.ResumeLayout(false);
            this.tabFormContentContainer6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagramControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_targ1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_targ2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer1;
        private DevExpress.XtraBars.TabFormPage tabFormPage_Run;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer3;
        private DevExpress.XtraBars.TabFormPage tabFormPage_Setup;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.XtraBars.TabFormPage tabFormPage_Light;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Timer timer_UI_loop;
        private System.Windows.Forms.Timer timerInput;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cheng1;
        private DevExpress.XtraDiagram.DiagramControl diagramControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_target1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_Cheng1Door;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_Cang1BigDoor;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_Cang1SmallDoor;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch5;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton simpleButton_m3cang1;
        private System.Windows.Forms.Timer timerDataUpdate;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer4;
        private DevExpress.XtraBars.TabFormPage tabFormPage_Sql;
        private DevExpress.XtraEditors.SimpleButton simpleButton16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SimpleButton simpleButton_m3cang2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_Cang2BigDoor;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_Cang2SmallDoor;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_Cheng2Door;
        private DevExpress.XtraEditors.TextEdit textEdit_target2;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.SimpleButton simpleButton_Cheng2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch9;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton25;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.SimpleButton simpleButton33;
        private DevExpress.XtraEditors.SimpleButton simpleButton32;
        private DevExpress.XtraBars.BarButtonItem bbiShow;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private testDataSet testDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private testDataSet1 testDataSet1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private testDataSet1TableAdapters.UserTableAdapter userTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer6;
        private DevExpress.XtraBars.TabFormPage tabFormPage_Test;
        private DevExpress.XtraEditors.SimpleButton simpleButton36;
        private DevExpress.XtraEditors.SimpleButton simpleButton37;
        private DevExpress.XtraEditors.SimpleButton simpleButton38;
        private DevExpress.XtraEditors.SimpleButton simpleButton39;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton40;
        private DevExpress.XtraEditors.LabelControl labelControl32;
        private DevExpress.XtraEditors.LabelControl labelControl31;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.LabelControl labelControl29;
        private DevExpress.XtraEditors.SimpleButton simpleButton41;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch10;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.SimpleButton simpleButton35;
        private DevExpress.XtraEditors.SimpleButton simpleButton34;
        private DevExpress.XtraEditors.SimpleButton simpleButton17;
        private DevExpress.XtraEditors.SimpleButton simpleButton42;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch_ShowModel;
        private DevExpress.XtraEditors.TextEdit textEdit_AllPans;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl_zsd;
        private DevExpress.XtraEditors.SimpleButton simpleButton_m3State;
        private DevExpress.XtraEditors.TextEdit textEdit_targ1;
        private DevExpress.XtraEditors.TextEdit textEdit_targ2;
    }
}

