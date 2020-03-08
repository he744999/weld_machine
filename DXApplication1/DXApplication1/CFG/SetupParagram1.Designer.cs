namespace DXApplication1
{
    partial class Form2
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_TOpen = new DevExpress.XtraEditors.TextEdit();
            this.textEdit_TClose = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton_xiaocheng = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_zero = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_OValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_K = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_RawValue = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.timer_UI = new System.Windows.Forms.Timer(this.components);
            this.simpleButton_to0 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_sub1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_sub10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_sub100 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_add1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_add10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_add100 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_add50 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_sub50 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit_targetWeight = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TOpen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_OValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_K.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RawValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_targetWeight.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(608, 404);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(518, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "点开时间";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(518, 253);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "点关时间";
            // 
            // textEdit_TOpen
            // 
            this.textEdit_TOpen.Location = new System.Drawing.Point(592, 215);
            this.textEdit_TOpen.Name = "textEdit_TOpen";
            this.textEdit_TOpen.Size = new System.Drawing.Size(100, 20);
            this.textEdit_TOpen.TabIndex = 4;
            // 
            // textEdit_TClose
            // 
            this.textEdit_TClose.Location = new System.Drawing.Point(592, 250);
            this.textEdit_TClose.Name = "textEdit_TClose";
            this.textEdit_TClose.Size = new System.Drawing.Size(100, 20);
            this.textEdit_TClose.TabIndex = 5;
            // 
            // simpleButton_xiaocheng
            // 
            this.simpleButton_xiaocheng.Location = new System.Drawing.Point(385, 109);
            this.simpleButton_xiaocheng.Name = "simpleButton_xiaocheng";
            this.simpleButton_xiaocheng.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_xiaocheng.TabIndex = 32;
            this.simpleButton_xiaocheng.Text = "校称";
            this.simpleButton_xiaocheng.Click += new System.EventHandler(this.simpleButton_xiaocheng_Click);
            // 
            // simpleButton_zero
            // 
            this.simpleButton_zero.Location = new System.Drawing.Point(279, 143);
            this.simpleButton_zero.Name = "simpleButton_zero";
            this.simpleButton_zero.Size = new System.Drawing.Size(75, 23);
            this.simpleButton_zero.TabIndex = 31;
            this.simpleButton_zero.Text = "调零";
            this.simpleButton_zero.Click += new System.EventHandler(this.simpleButton_zero_Click);
            // 
            // textEdit_OValue
            // 
            this.textEdit_OValue.Location = new System.Drawing.Point(173, 146);
            this.textEdit_OValue.Name = "textEdit_OValue";
            this.textEdit_OValue.Properties.Mask.EditMask = "d";
            this.textEdit_OValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_OValue.Properties.ReadOnly = true;
            this.textEdit_OValue.Size = new System.Drawing.Size(100, 20);
            this.textEdit_OValue.TabIndex = 30;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(108, 149);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(19, 14);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "0值";
            // 
            // textEdit_K
            // 
            this.textEdit_K.Location = new System.Drawing.Point(173, 110);
            this.textEdit_K.Name = "textEdit_K";
            this.textEdit_K.Properties.Mask.EditMask = "n";
            this.textEdit_K.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_K.Properties.ReadOnly = true;
            this.textEdit_K.Size = new System.Drawing.Size(100, 20);
            this.textEdit_K.TabIndex = 28;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(108, 113);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(19, 14);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "K值";
            // 
            // textEdit_RawValue
            // 
            this.textEdit_RawValue.Location = new System.Drawing.Point(173, 75);
            this.textEdit_RawValue.Name = "textEdit_RawValue";
            this.textEdit_RawValue.Properties.Mask.EditMask = "d";
            this.textEdit_RawValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_RawValue.Properties.ReadOnly = true;
            this.textEdit_RawValue.Size = new System.Drawing.Size(100, 20);
            this.textEdit_RawValue.TabIndex = 26;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(108, 78);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(48, 14);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "称原始值";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(109, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "仓位";
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(173, 41);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Mask.EditMask = "d";
            this.textEdit7.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit7.Size = new System.Drawing.Size(100, 20);
            this.textEdit7.TabIndex = 35;
            // 
            // timer_UI
            // 
            this.timer_UI.Tick += new System.EventHandler(this.timer_UI_Tick);
            // 
            // simpleButton_to0
            // 
            this.simpleButton_to0.Location = new System.Drawing.Point(43, 268);
            this.simpleButton_to0.Name = "simpleButton_to0";
            this.simpleButton_to0.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_to0.TabIndex = 75;
            this.simpleButton_to0.Text = "归零";
            this.simpleButton_to0.Click += new System.EventHandler(this.simpleButton_to0_Click);
            // 
            // simpleButton_sub1
            // 
            this.simpleButton_sub1.Location = new System.Drawing.Point(43, 297);
            this.simpleButton_sub1.Name = "simpleButton_sub1";
            this.simpleButton_sub1.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_sub1.TabIndex = 74;
            this.simpleButton_sub1.Text = "-1";
            this.simpleButton_sub1.Click += new System.EventHandler(this.simpleButton_sub1_Click);
            // 
            // simpleButton_sub10
            // 
            this.simpleButton_sub10.Location = new System.Drawing.Point(43, 326);
            this.simpleButton_sub10.Name = "simpleButton_sub10";
            this.simpleButton_sub10.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_sub10.TabIndex = 73;
            this.simpleButton_sub10.Text = "-10";
            this.simpleButton_sub10.Click += new System.EventHandler(this.simpleButton_sub10_Click);
            // 
            // simpleButton_sub100
            // 
            this.simpleButton_sub100.Location = new System.Drawing.Point(41, 383);
            this.simpleButton_sub100.Name = "simpleButton_sub100";
            this.simpleButton_sub100.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_sub100.TabIndex = 72;
            this.simpleButton_sub100.Text = "-100";
            this.simpleButton_sub100.Click += new System.EventHandler(this.simpleButton_sub100_Click);
            // 
            // simpleButton_add1
            // 
            this.simpleButton_add1.Location = new System.Drawing.Point(43, 237);
            this.simpleButton_add1.Name = "simpleButton_add1";
            this.simpleButton_add1.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_add1.TabIndex = 71;
            this.simpleButton_add1.Text = "+1";
            this.simpleButton_add1.Click += new System.EventHandler(this.simpleButton_add1_Click);
            // 
            // simpleButton_add10
            // 
            this.simpleButton_add10.Location = new System.Drawing.Point(43, 208);
            this.simpleButton_add10.Name = "simpleButton_add10";
            this.simpleButton_add10.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_add10.TabIndex = 70;
            this.simpleButton_add10.Text = "+10";
            this.simpleButton_add10.Click += new System.EventHandler(this.simpleButton_add10_Click);
            // 
            // simpleButton_add100
            // 
            this.simpleButton_add100.Location = new System.Drawing.Point(43, 145);
            this.simpleButton_add100.Name = "simpleButton_add100";
            this.simpleButton_add100.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_add100.TabIndex = 69;
            this.simpleButton_add100.Text = "+100";
            this.simpleButton_add100.Click += new System.EventHandler(this.simpleButton_add100_Click);
            // 
            // simpleButton_add50
            // 
            this.simpleButton_add50.Location = new System.Drawing.Point(43, 179);
            this.simpleButton_add50.Name = "simpleButton_add50";
            this.simpleButton_add50.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_add50.TabIndex = 76;
            this.simpleButton_add50.Text = "+50";
            this.simpleButton_add50.Click += new System.EventHandler(this.simpleButton_add50_Click);
            // 
            // simpleButton_sub50
            // 
            this.simpleButton_sub50.Location = new System.Drawing.Point(43, 355);
            this.simpleButton_sub50.Name = "simpleButton_sub50";
            this.simpleButton_sub50.Size = new System.Drawing.Size(42, 23);
            this.simpleButton_sub50.TabIndex = 77;
            this.simpleButton_sub50.Text = "-50";
            this.simpleButton_sub50.Click += new System.EventHandler(this.simpleButton_sub50_Click);
            // 
            // textEdit_targetWeight
            // 
            this.textEdit_targetWeight.EditValue = "";
            this.textEdit_targetWeight.Location = new System.Drawing.Point(279, 110);
            this.textEdit_targetWeight.Name = "textEdit_targetWeight";
            this.textEdit_targetWeight.Properties.Mask.EditMask = "d";
            this.textEdit_targetWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit_targetWeight.Size = new System.Drawing.Size(100, 20);
            this.textEdit_targetWeight.TabIndex = 78;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textEdit_targetWeight);
            this.Controls.Add(this.simpleButton_sub50);
            this.Controls.Add(this.simpleButton_add50);
            this.Controls.Add(this.simpleButton_to0);
            this.Controls.Add(this.simpleButton_sub1);
            this.Controls.Add(this.simpleButton_sub10);
            this.Controls.Add(this.simpleButton_sub100);
            this.Controls.Add(this.simpleButton_add1);
            this.Controls.Add(this.simpleButton_add10);
            this.Controls.Add(this.simpleButton_add100);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton_xiaocheng);
            this.Controls.Add(this.simpleButton_zero);
            this.Controls.Add(this.textEdit_OValue);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.textEdit_K);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.textEdit_RawValue);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textEdit_TClose);
            this.Controls.Add(this.textEdit_TOpen);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TOpen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_TClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_OValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_K.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_RawValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_targetWeight.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_TOpen;
        private DevExpress.XtraEditors.TextEdit textEdit_TClose;
        private DevExpress.XtraEditors.SimpleButton simpleButton_xiaocheng;
        private DevExpress.XtraEditors.SimpleButton simpleButton_zero;
        private DevExpress.XtraEditors.TextEdit textEdit_OValue;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit textEdit_K;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEdit_RawValue;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private System.Windows.Forms.Timer timer_UI;
        private DevExpress.XtraEditors.SimpleButton simpleButton_to0;
        private DevExpress.XtraEditors.SimpleButton simpleButton_sub1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_sub10;
        private DevExpress.XtraEditors.SimpleButton simpleButton_sub100;
        private DevExpress.XtraEditors.SimpleButton simpleButton_add1;
        private DevExpress.XtraEditors.SimpleButton simpleButton_add10;
        private DevExpress.XtraEditors.SimpleButton simpleButton_add100;
        private DevExpress.XtraEditors.SimpleButton simpleButton_add50;
        private DevExpress.XtraEditors.SimpleButton simpleButton_sub50;
        private DevExpress.XtraEditors.TextEdit textEdit_targetWeight;
    }
}