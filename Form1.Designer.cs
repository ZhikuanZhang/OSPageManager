namespace PageManage
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NewMemBtn = new System.Windows.Forms.Button();
            this.NewPrBtn = new System.Windows.Forms.Button();
            this.DelPrBtn = new System.Windows.Forms.Button();
            this.ShowPrBtn = new System.Windows.Forms.Button();
            this.NewPrIDTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPrNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewPrSizeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DelPrTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MemNameTB = new System.Windows.Forms.TextBox();
            this.MemSizeTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.ShowMemBtn = new System.Windows.Forms.Button();
            this.InfoSave = new System.Windows.Forms.Button();
            this.InfoLoadBtn = new System.Windows.Forms.Button();
            this.DisplayGB = new System.Windows.Forms.GroupBox();
            this.DisplayBox = new System.Windows.Forms.RichTextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SearchPrBtn = new System.Windows.Forms.Button();
            this.SearchMemBtn = new System.Windows.Forms.Button();
            this.SearchPrTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SearchMemTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DisplayGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewMemBtn
            // 
            this.NewMemBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NewMemBtn.Location = new System.Drawing.Point(36, 61);
            this.NewMemBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.NewMemBtn.Name = "NewMemBtn";
            this.NewMemBtn.Size = new System.Drawing.Size(112, 27);
            this.NewMemBtn.TabIndex = 0;
            this.NewMemBtn.Text = "新建存储区";
            this.NewMemBtn.UseVisualStyleBackColor = false;
            this.NewMemBtn.Click += new System.EventHandler(this.NewMemBtn_Click);
            // 
            // NewPrBtn
            // 
            this.NewPrBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.NewPrBtn.Location = new System.Drawing.Point(36, 107);
            this.NewPrBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.NewPrBtn.Name = "NewPrBtn";
            this.NewPrBtn.Size = new System.Drawing.Size(112, 27);
            this.NewPrBtn.TabIndex = 0;
            this.NewPrBtn.Text = "新建进程";
            this.NewPrBtn.UseVisualStyleBackColor = false;
            this.NewPrBtn.Click += new System.EventHandler(this.NewPrBtn_Click);
            // 
            // DelPrBtn
            // 
            this.DelPrBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DelPrBtn.Location = new System.Drawing.Point(36, 155);
            this.DelPrBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.DelPrBtn.Name = "DelPrBtn";
            this.DelPrBtn.Size = new System.Drawing.Size(112, 27);
            this.DelPrBtn.TabIndex = 0;
            this.DelPrBtn.Text = "删除进程";
            this.DelPrBtn.UseVisualStyleBackColor = false;
            this.DelPrBtn.Click += new System.EventHandler(this.DelPrBtn_Click);
            // 
            // ShowPrBtn
            // 
            this.ShowPrBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ShowPrBtn.Location = new System.Drawing.Point(36, 299);
            this.ShowPrBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.ShowPrBtn.Name = "ShowPrBtn";
            this.ShowPrBtn.Size = new System.Drawing.Size(112, 27);
            this.ShowPrBtn.TabIndex = 0;
            this.ShowPrBtn.Text = "查看全部进程";
            this.ShowPrBtn.UseVisualStyleBackColor = false;
            this.ShowPrBtn.Click += new System.EventHandler(this.ShowPrBtn_Click);
            // 
            // NewPrIDTB
            // 
            this.NewPrIDTB.Location = new System.Drawing.Point(211, 113);
            this.NewPrIDTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.NewPrIDTB.Name = "NewPrIDTB";
            this.NewPrIDTB.Size = new System.Drawing.Size(55, 23);
            this.NewPrIDTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // NewPrNameTB
            // 
            this.NewPrNameTB.Location = new System.Drawing.Point(316, 107);
            this.NewPrNameTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.NewPrNameTB.MaxLength = 32760;
            this.NewPrNameTB.Name = "NewPrNameTB";
            this.NewPrNameTB.Size = new System.Drawing.Size(55, 23);
            this.NewPrNameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // NewPrSizeTB
            // 
            this.NewPrSizeTB.Location = new System.Drawing.Point(422, 107);
            this.NewPrSizeTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.NewPrSizeTB.MaxLength = 32760;
            this.NewPrSizeTB.Name = "NewPrSizeTB";
            this.NewPrSizeTB.Size = new System.Drawing.Size(55, 23);
            this.NewPrSizeTB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Size:";
            // 
            // DelPrTB
            // 
            this.DelPrTB.Location = new System.Drawing.Point(211, 161);
            this.DelPrTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.DelPrTB.Name = "DelPrTB";
            this.DelPrTB.Size = new System.Drawing.Size(55, 23);
            this.DelPrTB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 14);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID:";
            // 
            // MemNameTB
            // 
            this.MemNameTB.Location = new System.Drawing.Point(211, 63);
            this.MemNameTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MemNameTB.MaxLength = 32760;
            this.MemNameTB.Name = "MemNameTB";
            this.MemNameTB.Size = new System.Drawing.Size(55, 23);
            this.MemNameTB.TabIndex = 1;
            // 
            // MemSizeTB
            // 
            this.MemSizeTB.Location = new System.Drawing.Point(316, 63);
            this.MemSizeTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MemSizeTB.MaxLength = 32760;
            this.MemSizeTB.Name = "MemSizeTB";
            this.MemSizeTB.Size = new System.Drawing.Size(55, 23);
            this.MemSizeTB.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name:";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(274, 65);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(42, 14);
            this.lb.TabIndex = 2;
            this.lb.Text = "Size:";
            // 
            // ShowMemBtn
            // 
            this.ShowMemBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ShowMemBtn.Location = new System.Drawing.Point(36, 349);
            this.ShowMemBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.ShowMemBtn.Name = "ShowMemBtn";
            this.ShowMemBtn.Size = new System.Drawing.Size(112, 27);
            this.ShowMemBtn.TabIndex = 0;
            this.ShowMemBtn.Text = "查看完整内存";
            this.ShowMemBtn.UseVisualStyleBackColor = false;
            this.ShowMemBtn.Click += new System.EventHandler(this.ShowMemBtn_Click);
            // 
            // InfoSave
            // 
            this.InfoSave.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InfoSave.Location = new System.Drawing.Point(36, 397);
            this.InfoSave.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.InfoSave.Name = "InfoSave";
            this.InfoSave.Size = new System.Drawing.Size(112, 27);
            this.InfoSave.TabIndex = 0;
            this.InfoSave.Text = "信息保存";
            this.InfoSave.UseVisualStyleBackColor = false;
            this.InfoSave.Click += new System.EventHandler(this.InfoSave_Click);
            // 
            // InfoLoadBtn
            // 
            this.InfoLoadBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.InfoLoadBtn.Location = new System.Drawing.Point(36, 448);
            this.InfoLoadBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.InfoLoadBtn.Name = "InfoLoadBtn";
            this.InfoLoadBtn.Size = new System.Drawing.Size(112, 27);
            this.InfoLoadBtn.TabIndex = 0;
            this.InfoLoadBtn.Text = "信息载入";
            this.InfoLoadBtn.UseVisualStyleBackColor = false;
            this.InfoLoadBtn.Click += new System.EventHandler(this.InfoLoadBtn_Click);
            // 
            // DisplayGB
            // 
            this.DisplayGB.BackColor = System.Drawing.Color.Azure;
            this.DisplayGB.Controls.Add(this.DisplayBox);
            this.DisplayGB.Location = new System.Drawing.Point(490, 35);
            this.DisplayGB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.DisplayGB.Name = "DisplayGB";
            this.DisplayGB.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.DisplayGB.Size = new System.Drawing.Size(370, 443);
            this.DisplayGB.TabIndex = 3;
            this.DisplayGB.TabStop = false;
            this.DisplayGB.Text = "Display";
            // 
            // DisplayBox
            // 
            this.DisplayBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisplayBox.ForeColor = System.Drawing.Color.Teal;
            this.DisplayBox.Location = new System.Drawing.Point(8, 23);
            this.DisplayBox.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(354, 415);
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.Text = "Loading................\n\n";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.MintCream;
            this.ClearBtn.Location = new System.Drawing.Point(771, 485);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(86, 27);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SearchPrBtn
            // 
            this.SearchPrBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SearchPrBtn.Location = new System.Drawing.Point(36, 203);
            this.SearchPrBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.SearchPrBtn.Name = "SearchPrBtn";
            this.SearchPrBtn.Size = new System.Drawing.Size(112, 27);
            this.SearchPrBtn.TabIndex = 0;
            this.SearchPrBtn.Text = "查询进程";
            this.SearchPrBtn.UseVisualStyleBackColor = false;
            this.SearchPrBtn.Click += new System.EventHandler(this.SearchPrBtn_Click);
            // 
            // SearchMemBtn
            // 
            this.SearchMemBtn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.SearchMemBtn.Location = new System.Drawing.Point(36, 247);
            this.SearchMemBtn.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.SearchMemBtn.Name = "SearchMemBtn";
            this.SearchMemBtn.Size = new System.Drawing.Size(112, 27);
            this.SearchMemBtn.TabIndex = 0;
            this.SearchMemBtn.Text = "查询存储区";
            this.SearchMemBtn.UseVisualStyleBackColor = false;
            this.SearchMemBtn.Click += new System.EventHandler(this.SearchMemBtn_Click);
            // 
            // SearchPrTB
            // 
            this.SearchPrTB.Location = new System.Drawing.Point(211, 205);
            this.SearchPrTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.SearchPrTB.Name = "SearchPrTB";
            this.SearchPrTB.Size = new System.Drawing.Size(55, 23);
            this.SearchPrTB.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID:";
            // 
            // SearchMemTB
            // 
            this.SearchMemTB.Location = new System.Drawing.Point(211, 247);
            this.SearchMemTB.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.SearchMemTB.MaxLength = 32760;
            this.SearchMemTB.Name = "SearchMemTB";
            this.SearchMemTB.Size = new System.Drawing.Size(55, 23);
            this.SearchMemTB.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ad:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(914, 526);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DisplayGB);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MemSizeTB);
            this.Controls.Add(this.SearchMemTB);
            this.Controls.Add(this.NewPrSizeTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchPrTB);
            this.Controls.Add(this.DelPrTB);
            this.Controls.Add(this.MemNameTB);
            this.Controls.Add(this.NewPrNameTB);
            this.Controls.Add(this.NewPrIDTB);
            this.Controls.Add(this.InfoLoadBtn);
            this.Controls.Add(this.SearchPrBtn);
            this.Controls.Add(this.SearchMemBtn);
            this.Controls.Add(this.ShowPrBtn);
            this.Controls.Add(this.InfoSave);
            this.Controls.Add(this.DelPrBtn);
            this.Controls.Add(this.ShowMemBtn);
            this.Controls.Add(this.NewPrBtn);
            this.Controls.Add(this.NewMemBtn);
            this.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "MainForm";
            this.Text = "PageManage";
            this.DisplayGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewMemBtn;
        private System.Windows.Forms.Button NewPrBtn;
        private System.Windows.Forms.Button DelPrBtn;
        private System.Windows.Forms.Button ShowPrBtn;
        private System.Windows.Forms.TextBox NewPrIDTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPrNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewPrSizeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DelPrTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MemNameTB;
        private System.Windows.Forms.TextBox MemSizeTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button ShowMemBtn;
        private System.Windows.Forms.Button InfoSave;
        private System.Windows.Forms.Button InfoLoadBtn;
        private System.Windows.Forms.GroupBox DisplayGB;
        private System.Windows.Forms.RichTextBox DisplayBox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SearchPrBtn;
        private System.Windows.Forms.Button SearchMemBtn;
        private System.Windows.Forms.TextBox SearchPrTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SearchMemTB;
        private System.Windows.Forms.Label label8;
    }
}

