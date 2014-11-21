namespace weatherhelper
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelstatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labeltemp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelwind = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelpollution = new System.Windows.Forms.Label();
            this.labelcity = new System.Windows.Forms.Label();
            this.labelupdatetime = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "要查询的地区：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "天气：";
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(72, 101);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(0, 12);
            this.labelstatus.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "温度：";
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.Location = new System.Drawing.Point(72, 124);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(0, 12);
            this.labeltemp.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "风向：";
            // 
            // labelwind
            // 
            this.labelwind.AutoSize = true;
            this.labelwind.Location = new System.Drawing.Point(72, 147);
            this.labelwind.Name = "labelwind";
            this.labelwind.Size = new System.Drawing.Size(0, 12);
            this.labelwind.TabIndex = 11;
            this.labelwind.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "污染：";
            // 
            // labelpollution
            // 
            this.labelpollution.AutoSize = true;
            this.labelpollution.Location = new System.Drawing.Point(72, 169);
            this.labelpollution.Name = "labelpollution";
            this.labelpollution.Size = new System.Drawing.Size(0, 12);
            this.labelpollution.TabIndex = 13;
            // 
            // labelcity
            // 
            this.labelcity.AutoSize = true;
            this.labelcity.Location = new System.Drawing.Point(25, 55);
            this.labelcity.Name = "labelcity";
            this.labelcity.Size = new System.Drawing.Size(0, 12);
            this.labelcity.TabIndex = 14;
            // 
            // labelupdatetime
            // 
            this.labelupdatetime.AutoSize = true;
            this.labelupdatetime.Location = new System.Drawing.Point(171, 190);
            this.labelupdatetime.Name = "labelupdatetime";
            this.labelupdatetime.Size = new System.Drawing.Size(0, 12);
            this.labelupdatetime.TabIndex = 15;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(25, 77);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(29, 12);
            this.labeldate.TabIndex = 16;
            this.labeldate.Text = "时间";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(75, 20);
            this.comboBox1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "选择日期";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 211);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labelupdatetime);
            this.Controls.Add(this.labelcity);
            this.Controls.Add(this.labelpollution);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelwind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 250);
            this.MinimumSize = new System.Drawing.Size(415, 250);
            this.Name = "Form1";
            this.Text = "天气助手";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelwind;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelpollution;
        private System.Windows.Forms.Label labelcity;
        private System.Windows.Forms.Label labelupdatetime;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}

