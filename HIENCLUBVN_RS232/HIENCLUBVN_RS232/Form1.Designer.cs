namespace HIENCLUBVN_RS232
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.cbBits = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbBit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btKetNoi = new System.Windows.Forms.Button();
            this.btNgat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCom
            // 
            this.cbCom.ForeColor = System.Drawing.Color.Red;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(79, 39);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(100, 21);
            this.cbCom.TabIndex = 0;
            this.cbCom.SelectedIndexChanged += new System.EventHandler(this.cbCom_SelectedIndexChanged);
            // 
            // cbRate
            // 
            this.cbRate.ForeColor = System.Drawing.Color.Red;
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Location = new System.Drawing.Point(79, 78);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(100, 21);
            this.cbRate.TabIndex = 1;
            this.cbRate.SelectedIndexChanged += new System.EventHandler(this.cbRate_SelectedIndexChanged);
            // 
            // cbBits
            // 
            this.cbBits.ForeColor = System.Drawing.Color.Red;
            this.cbBits.FormattingEnabled = true;
            this.cbBits.Location = new System.Drawing.Point(79, 118);
            this.cbBits.Name = "cbBits";
            this.cbBits.Size = new System.Drawing.Size(100, 21);
            this.cbBits.TabIndex = 2;
            this.cbBits.SelectedIndexChanged += new System.EventHandler(this.cbBits_SelectedIndexChanged);
            // 
            // cbParity
            // 
            this.cbParity.ForeColor = System.Drawing.Color.Red;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(79, 159);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(100, 21);
            this.cbParity.TabIndex = 3;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbBit
            // 
            this.cbBit.ForeColor = System.Drawing.Color.Red;
            this.cbBit.FormattingEnabled = true;
            this.cbBit.Location = new System.Drawing.Point(79, 206);
            this.cbBit.Name = "cbBit";
            this.cbBit.Size = new System.Drawing.Size(100, 21);
            this.cbBit.TabIndex = 4;
            this.cbBit.SelectedIndexChanged += new System.EventHandler(this.cbBit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(16, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stop Bit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBit);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbBits);
            this.groupBox1.Controls.Add(this.cbRate);
            this.groupBox1.Controls.Add(this.cbCom);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 251);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // txtkq
            // 
            this.txtkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.Location = new System.Drawing.Point(261, 54);
            this.txtkq.Multiline = true;
            this.txtkq.Name = "txtkq";
            this.txtkq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtkq.Size = new System.Drawing.Size(651, 289);
            this.txtkq.TabIndex = 9;
            // 
            // txtSend
            // 
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSend.Location = new System.Drawing.Point(261, 373);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(569, 35);
            this.txtSend.TabIndex = 10;
            // 
            // btSend
            // 
            this.btSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.ForeColor = System.Drawing.Color.Red;
            this.btSend.Location = new System.Drawing.Point(853, 373);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(59, 35);
            this.btSend.TabIndex = 11;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btKetNoi
            // 
            this.btKetNoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btKetNoi.Location = new System.Drawing.Point(19, 20);
            this.btKetNoi.Name = "btKetNoi";
            this.btKetNoi.Size = new System.Drawing.Size(74, 27);
            this.btKetNoi.TabIndex = 5;
            this.btKetNoi.Text = "Kết Nối";
            this.btKetNoi.UseVisualStyleBackColor = true;
            this.btKetNoi.Click += new System.EventHandler(this.btKetNoi_Click);
            // 
            // btNgat
            // 
            this.btNgat.ForeColor = System.Drawing.Color.Red;
            this.btNgat.Location = new System.Drawing.Point(112, 20);
            this.btNgat.Name = "btNgat";
            this.btNgat.Size = new System.Drawing.Size(74, 27);
            this.btNgat.TabIndex = 6;
            this.btNgat.Text = "Ngắt";
            this.btNgat.UseVisualStyleBackColor = true;
            this.btNgat.Click += new System.EventHandler(this.btNgat_Click);
            // 
            // btXoa
            // 
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btXoa.Location = new System.Drawing.Point(19, 62);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(74, 27);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.ForeColor = System.Drawing.Color.Fuchsia;
            this.btThoat.Location = new System.Drawing.Point(112, 63);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(74, 27);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btNgat);
            this.groupBox2.Controls.Add(this.btKetNoi);
            this.groupBox2.Location = new System.Drawing.Point(15, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 111);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(50, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "HỌC VIỆN HẢI QUÂN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(313, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 24);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(931, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(73, 17);
            this.status.Text = "StatusLabel1";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(931, 24);
            this.menu.TabIndex = 17;
            this.menu.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aboutToolStripMenuItem.Text = "Tác Giả";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Temperature";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Secutity On";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "Security Off";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 32);
            this.button4.TabIndex = 20;
            this.button4.Text = "Status Light";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(590, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 32);
            this.button5.TabIndex = 25;
            this.button5.Text = "Light 1 On";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(672, 432);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 32);
            this.button6.TabIndex = 24;
            this.button6.Text = "Light 1 Off";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(754, 432);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 32);
            this.button7.TabIndex = 23;
            this.button7.Text = "Light 2 On";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(836, 432);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 32);
            this.button8.TabIndex = 22;
            this.button8.Text = "Light 2 Off";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(261, 480);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 32);
            this.button9.TabIndex = 33;
            this.button9.Text = "Light 3 On";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(343, 480);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 32);
            this.button10.TabIndex = 32;
            this.button10.Text = "Light 3 Off";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(426, 480);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(76, 32);
            this.button11.TabIndex = 31;
            this.button11.Text = "Light 4 On";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(508, 480);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(76, 32);
            this.button12.TabIndex = 30;
            this.button12.Text = "Light 4 Off";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(590, 480);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(76, 32);
            this.button13.TabIndex = 29;
            this.button13.Text = "Auto On";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(672, 480);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(76, 32);
            this.button14.TabIndex = 28;
            this.button14.Text = "Auto Off";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(754, 480);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(76, 32);
            this.button15.TabIndex = 27;
            this.button15.Text = "Status All";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(836, 480);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(76, 32);
            this.button16.TabIndex = 26;
            this.button16.Text = "Null";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(931, 539);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(774, 478);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Test RS232";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.ComboBox cbBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btKetNoi;
        private System.Windows.Forms.Button btNgat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

