namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Y0 = new System.Windows.Forms.CheckBox();
            this.Y1 = new System.Windows.Forms.CheckBox();
            this.Y2 = new System.Windows.Forms.CheckBox();
            this.Y3 = new System.Windows.Forms.CheckBox();
            this.X3 = new System.Windows.Forms.CheckBox();
            this.X2 = new System.Windows.Forms.CheckBox();
            this.X1 = new System.Windows.Forms.CheckBox();
            this.X0 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X13 = new System.Windows.Forms.CheckBox();
            this.X12 = new System.Windows.Forms.CheckBox();
            this.X11 = new System.Windows.Forms.CheckBox();
            this.X10 = new System.Windows.Forms.CheckBox();
            this.Y13 = new System.Windows.Forms.CheckBox();
            this.Y12 = new System.Windows.Forms.CheckBox();
            this.Y11 = new System.Windows.Forms.CheckBox();
            this.Y10 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AX3 = new System.Windows.Forms.CheckBox();
            this.AX2 = new System.Windows.Forms.CheckBox();
            this.AX1 = new System.Windows.Forms.CheckBox();
            this.AX0 = new System.Windows.Forms.CheckBox();
            this.AX7 = new System.Windows.Forms.CheckBox();
            this.AX6 = new System.Windows.Forms.CheckBox();
            this.AX5 = new System.Windows.Forms.CheckBox();
            this.AX4 = new System.Windows.Forms.CheckBox();
            this.timer_ui_update = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab_state = new System.Windows.Forms.Label();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(113, 138);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 25);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1057, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "启动串口";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1057, 13);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "13";
            // 
            // Y0
            // 
            this.Y0.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y0.AutoSize = true;
            this.Y0.Location = new System.Drawing.Point(754, 79);
            this.Y0.Name = "Y0";
            this.Y0.Size = new System.Drawing.Size(41, 25);
            this.Y0.TabIndex = 4;
            this.Y0.Text = "do0";
            this.Y0.UseVisualStyleBackColor = true;
            this.Y0.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // Y1
            // 
            this.Y1.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y1.AutoSize = true;
            this.Y1.Location = new System.Drawing.Point(848, 79);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(41, 25);
            this.Y1.TabIndex = 5;
            this.Y1.Text = "do1";
            this.Y1.UseVisualStyleBackColor = true;
            this.Y1.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // Y2
            // 
            this.Y2.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y2.AutoSize = true;
            this.Y2.Location = new System.Drawing.Point(919, 79);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(41, 25);
            this.Y2.TabIndex = 6;
            this.Y2.Text = "do2";
            this.Y2.UseVisualStyleBackColor = true;
            this.Y2.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // Y3
            // 
            this.Y3.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y3.AutoSize = true;
            this.Y3.Location = new System.Drawing.Point(998, 79);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(41, 25);
            this.Y3.TabIndex = 7;
            this.Y3.Text = "do3";
            this.Y3.UseVisualStyleBackColor = true;
            this.Y3.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // X3
            // 
            this.X3.Appearance = System.Windows.Forms.Appearance.Button;
            this.X3.AutoSize = true;
            this.X3.Location = new System.Drawing.Point(998, 151);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(41, 25);
            this.X3.TabIndex = 12;
            this.X3.Text = "di3";
            this.X3.UseVisualStyleBackColor = true;
            // 
            // X2
            // 
            this.X2.Appearance = System.Windows.Forms.Appearance.Button;
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(919, 151);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(41, 25);
            this.X2.TabIndex = 11;
            this.X2.Text = "di2";
            this.X2.UseVisualStyleBackColor = true;
            // 
            // X1
            // 
            this.X1.Appearance = System.Windows.Forms.Appearance.Button;
            this.X1.AutoSize = true;
            this.X1.Location = new System.Drawing.Point(848, 151);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(41, 25);
            this.X1.TabIndex = 10;
            this.X1.Text = "di1";
            this.X1.UseVisualStyleBackColor = true;
            // 
            // X0
            // 
            this.X0.Appearance = System.Windows.Forms.Appearance.Button;
            this.X0.AutoSize = true;
            this.X0.Location = new System.Drawing.Point(754, 151);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(41, 25);
            this.X0.TabIndex = 9;
            this.X0.Text = "di0";
            this.X0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(754, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "模块1 address = 120";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "模块2 address = 121";
            // 
            // X13
            // 
            this.X13.Appearance = System.Windows.Forms.Appearance.Button;
            this.X13.AutoSize = true;
            this.X13.Location = new System.Drawing.Point(998, 287);
            this.X13.Name = "X13";
            this.X13.Size = new System.Drawing.Size(41, 25);
            this.X13.TabIndex = 21;
            this.X13.Text = "di3";
            this.X13.UseVisualStyleBackColor = true;
            // 
            // X12
            // 
            this.X12.Appearance = System.Windows.Forms.Appearance.Button;
            this.X12.AutoSize = true;
            this.X12.Location = new System.Drawing.Point(919, 287);
            this.X12.Name = "X12";
            this.X12.Size = new System.Drawing.Size(41, 25);
            this.X12.TabIndex = 20;
            this.X12.Text = "di2";
            this.X12.UseVisualStyleBackColor = true;
            // 
            // X11
            // 
            this.X11.Appearance = System.Windows.Forms.Appearance.Button;
            this.X11.AutoSize = true;
            this.X11.Location = new System.Drawing.Point(848, 287);
            this.X11.Name = "X11";
            this.X11.Size = new System.Drawing.Size(41, 25);
            this.X11.TabIndex = 19;
            this.X11.Text = "di1";
            this.X11.UseVisualStyleBackColor = true;
            // 
            // X10
            // 
            this.X10.Appearance = System.Windows.Forms.Appearance.Button;
            this.X10.AutoSize = true;
            this.X10.Location = new System.Drawing.Point(754, 287);
            this.X10.Name = "X10";
            this.X10.Size = new System.Drawing.Size(41, 25);
            this.X10.TabIndex = 18;
            this.X10.Text = "di0";
            this.X10.UseVisualStyleBackColor = true;
            // 
            // Y13
            // 
            this.Y13.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y13.AutoSize = true;
            this.Y13.Location = new System.Drawing.Point(998, 210);
            this.Y13.Name = "Y13";
            this.Y13.Size = new System.Drawing.Size(41, 25);
            this.Y13.TabIndex = 17;
            this.Y13.Text = "do3";
            this.Y13.UseVisualStyleBackColor = true;
            this.Y13.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // Y12
            // 
            this.Y12.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y12.AutoSize = true;
            this.Y12.Location = new System.Drawing.Point(919, 215);
            this.Y12.Name = "Y12";
            this.Y12.Size = new System.Drawing.Size(41, 25);
            this.Y12.TabIndex = 16;
            this.Y12.Text = "do2";
            this.Y12.UseVisualStyleBackColor = true;
            this.Y12.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // Y11
            // 
            this.Y11.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y11.AutoSize = true;
            this.Y11.Location = new System.Drawing.Point(848, 215);
            this.Y11.Name = "Y11";
            this.Y11.Size = new System.Drawing.Size(41, 25);
            this.Y11.TabIndex = 15;
            this.Y11.Text = "do1";
            this.Y11.UseVisualStyleBackColor = true;
            this.Y11.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // Y10
            // 
            this.Y10.Appearance = System.Windows.Forms.Appearance.Button;
            this.Y10.AutoSize = true;
            this.Y10.Location = new System.Drawing.Point(754, 215);
            this.Y10.Name = "Y10";
            this.Y10.Size = new System.Drawing.Size(41, 25);
            this.Y10.TabIndex = 14;
            this.Y10.Text = "do0";
            this.Y10.UseVisualStyleBackColor = true;
            this.Y10.CheckStateChanged += new System.EventHandler(this.Y_CheckStateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(754, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "模块3 address = 100";
            // 
            // AX3
            // 
            this.AX3.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX3.AutoSize = true;
            this.AX3.Location = new System.Drawing.Point(964, 337);
            this.AX3.Name = "AX3";
            this.AX3.Size = new System.Drawing.Size(41, 25);
            this.AX3.TabIndex = 26;
            this.AX3.Text = "ai3";
            this.AX3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX3.UseVisualStyleBackColor = true;
            // 
            // AX2
            // 
            this.AX2.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX2.AutoSize = true;
            this.AX2.Location = new System.Drawing.Point(899, 337);
            this.AX2.Name = "AX2";
            this.AX2.Size = new System.Drawing.Size(41, 25);
            this.AX2.TabIndex = 25;
            this.AX2.Text = "ai2";
            this.AX2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX2.UseVisualStyleBackColor = true;
            // 
            // AX1
            // 
            this.AX1.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX1.AutoSize = true;
            this.AX1.Location = new System.Drawing.Point(824, 337);
            this.AX1.Name = "AX1";
            this.AX1.Size = new System.Drawing.Size(41, 25);
            this.AX1.TabIndex = 24;
            this.AX1.Text = "ai1";
            this.AX1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX1.UseVisualStyleBackColor = true;
            // 
            // AX0
            // 
            this.AX0.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX0.AutoSize = true;
            this.AX0.Location = new System.Drawing.Point(754, 337);
            this.AX0.Name = "AX0";
            this.AX0.Size = new System.Drawing.Size(41, 25);
            this.AX0.TabIndex = 23;
            this.AX0.Text = "ai0";
            this.AX0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX0.UseVisualStyleBackColor = true;
            // 
            // AX7
            // 
            this.AX7.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX7.AutoSize = true;
            this.AX7.Location = new System.Drawing.Point(1237, 337);
            this.AX7.Name = "AX7";
            this.AX7.Size = new System.Drawing.Size(41, 25);
            this.AX7.TabIndex = 35;
            this.AX7.Text = "ai7";
            this.AX7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX7.UseVisualStyleBackColor = true;
            // 
            // AX6
            // 
            this.AX6.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX6.AutoSize = true;
            this.AX6.Location = new System.Drawing.Point(1165, 337);
            this.AX6.Name = "AX6";
            this.AX6.Size = new System.Drawing.Size(41, 25);
            this.AX6.TabIndex = 34;
            this.AX6.Text = "ai6";
            this.AX6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX6.UseVisualStyleBackColor = true;
            // 
            // AX5
            // 
            this.AX5.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX5.AutoSize = true;
            this.AX5.Location = new System.Drawing.Point(1094, 337);
            this.AX5.Name = "AX5";
            this.AX5.Size = new System.Drawing.Size(41, 25);
            this.AX5.TabIndex = 33;
            this.AX5.Text = "ai5";
            this.AX5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX5.UseVisualStyleBackColor = true;
            // 
            // AX4
            // 
            this.AX4.Appearance = System.Windows.Forms.Appearance.Button;
            this.AX4.AutoSize = true;
            this.AX4.Location = new System.Drawing.Point(1028, 337);
            this.AX4.Name = "AX4";
            this.AX4.Size = new System.Drawing.Size(41, 25);
            this.AX4.TabIndex = 32;
            this.AX4.Text = "ai4";
            this.AX4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AX4.UseVisualStyleBackColor = true;
            // 
            // timer_ui_update
            // 
            this.timer_ui_update.Interval = 10;
            this.timer_ui_update.Tick += new System.EventHandler(this.timer_ui_update_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "DO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "DI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(705, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "DI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "DO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(705, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "AI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(772, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "当前状态";
            // 
            // lab_state
            // 
            this.lab_state.AutoSize = true;
            this.lab_state.Location = new System.Drawing.Point(845, 16);
            this.lab_state.Name = "lab_state";
            this.lab_state.Size = new System.Drawing.Size(23, 15);
            this.lab_state.TabIndex = 42;
            this.lab_state.Text = "11";
            // 
            // timerBlink
            // 
            this.timerBlink.Interval = 1000;
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 552);
            this.Controls.Add(this.lab_state);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AX7);
            this.Controls.Add(this.AX6);
            this.Controls.Add(this.AX5);
            this.Controls.Add(this.AX4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AX3);
            this.Controls.Add(this.AX2);
            this.Controls.Add(this.AX1);
            this.Controls.Add(this.AX0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X13);
            this.Controls.Add(this.X12);
            this.Controls.Add(this.X11);
            this.Controls.Add(this.X10);
            this.Controls.Add(this.Y13);
            this.Controls.Add(this.Y12);
            this.Controls.Add(this.Y11);
            this.Controls.Add(this.Y10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.X3);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.X0);
            this.Controls.Add(this.Y3);
            this.Controls.Add(this.Y2);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.Y0);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox Y0;
        private System.Windows.Forms.CheckBox Y1;
        private System.Windows.Forms.CheckBox Y2;
        private System.Windows.Forms.CheckBox Y3;
        private System.Windows.Forms.CheckBox X3;
        private System.Windows.Forms.CheckBox X2;
        private System.Windows.Forms.CheckBox X1;
        private System.Windows.Forms.CheckBox X0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox X13;
        private System.Windows.Forms.CheckBox X12;
        private System.Windows.Forms.CheckBox X11;
        private System.Windows.Forms.CheckBox X10;
        private System.Windows.Forms.CheckBox Y13;
        private System.Windows.Forms.CheckBox Y12;
        private System.Windows.Forms.CheckBox Y11;
        private System.Windows.Forms.CheckBox Y10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AX3;
        private System.Windows.Forms.CheckBox AX2;
        private System.Windows.Forms.CheckBox AX1;
        private System.Windows.Forms.CheckBox AX0;
        private System.Windows.Forms.CheckBox AX7;
        private System.Windows.Forms.CheckBox AX6;
        private System.Windows.Forms.CheckBox AX5;
        private System.Windows.Forms.CheckBox AX4;
        private System.Windows.Forms.Timer timer_ui_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lab_state;
        private System.Windows.Forms.Timer timerBlink;
    }
}

