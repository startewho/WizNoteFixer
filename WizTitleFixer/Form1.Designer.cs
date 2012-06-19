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
            this.btnRepView = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbPre = new System.Windows.Forms.ListBox();
            this.cmbExpress = new System.Windows.Forms.ComboBox();
            this.btnRecover = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.lbRes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRepView
            // 
            this.btnRepView.Location = new System.Drawing.Point(546, 10);
            this.btnRepView.Name = "btnRepView";
            this.btnRepView.Size = new System.Drawing.Size(107, 23);
            this.btnRepView.TabIndex = 0;
            this.btnRepView.Text = "Preview";
            this.btnRepView.UseVisualStyleBackColor = true;
            this.btnRepView.Click += new System.EventHandler(this.btnRepView_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(668, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(107, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(668, 140);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(107, 23);
            this.btnBackUp.TabIndex = 4;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Visible = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(668, 242);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(107, 23);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbPre
            // 
            this.lbPre.FormattingEnabled = true;
            this.lbPre.ItemHeight = 12;
            this.lbPre.Location = new System.Drawing.Point(13, 40);
            this.lbPre.Name = "lbPre";
            this.lbPre.Size = new System.Drawing.Size(641, 196);
            this.lbPre.TabIndex = 6;
            // 
            // cmbExpress
            // 
            this.cmbExpress.FormattingEnabled = true;
            this.cmbExpress.Location = new System.Drawing.Point(13, 12);
            this.cmbExpress.Name = "cmbExpress";
            this.cmbExpress.Size = new System.Drawing.Size(527, 20);
            this.cmbExpress.TabIndex = 7;
            // 
            // btnRecover
            // 
            this.btnRecover.Location = new System.Drawing.Point(668, 202);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(107, 23);
            this.btnRecover.TabIndex = 4;
            this.btnRecover.Text = "Recover";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Visible = false;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(668, 12);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(107, 23);
            this.btnReplace.TabIndex = 8;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lbRes
            // 
            this.lbRes.FormattingEnabled = true;
            this.lbRes.ItemHeight = 12;
            this.lbRes.Location = new System.Drawing.Point(13, 242);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(641, 196);
            this.lbRes.TabIndex = 9;
            // 
            // WizTitleFixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.cmbExpress);
            this.Controls.Add(this.lbPre);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnRepView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WizTitleFixer";
            this.Text = "WizTitleFixer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepView;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListBox lbPre;
        private System.Windows.Forms.ComboBox cmbExpress;
        private System.Windows.Forms.Button btnRecover;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.ListBox lbRes;
    }
}

