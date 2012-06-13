namespace WizTitleFixer
{
    partial class WizTitleFixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizTitleFixer));
            this.btnReplace = new System.Windows.Forms.Button();
            this.tbParts = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbFixedTitles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(402, 12);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(107, 23);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbParts
            // 
            this.tbParts.Location = new System.Drawing.Point(12, 12);
            this.tbParts.Name = "tbParts";
            this.tbParts.Size = new System.Drawing.Size(384, 21);
            this.tbParts.TabIndex = 2;
            this.tbParts.Text = "请将替换关键词用;分开";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(402, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(107, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(402, 81);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(107, 23);
            this.btnBackUp.TabIndex = 4;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(402, 154);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(107, 23);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbFixedTitles
            // 
            this.lbFixedTitles.FormattingEnabled = true;
            this.lbFixedTitles.ItemHeight = 12;
            this.lbFixedTitles.Location = new System.Drawing.Point(12, 39);
            this.lbFixedTitles.Name = "lbFixedTitles";
            this.lbFixedTitles.Size = new System.Drawing.Size(384, 208);
            this.lbFixedTitles.TabIndex = 6;
            // 
            // WizTitleFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 262);
            this.Controls.Add(this.lbFixedTitles);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tbParts);
            this.Controls.Add(this.btnReplace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WizTitleFixer";
            this.Text = "WizTitleFixer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox tbParts;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox lbFixedTitles;
    }
}

