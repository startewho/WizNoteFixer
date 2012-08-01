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
            resources.ApplyResources(this.btnRepView, "btnRepView");
            this.btnRepView.Name = "btnRepView";
            this.btnRepView.UseVisualStyleBackColor = true;
            this.btnRepView.Click += new System.EventHandler(this.btnRepView_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // btnBackUp
            // 
            resources.ApplyResources(this.btnBackUp, "btnBackUp");
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnHelp
            // 
            resources.ApplyResources(this.btnHelp, "btnHelp");
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lbPre
            // 
            resources.ApplyResources(this.lbPre, "lbPre");
            this.lbPre.FormattingEnabled = true;
            this.lbPre.Name = "lbPre";
            // 
            // cmbExpress
            // 
            resources.ApplyResources(this.cmbExpress, "cmbExpress");
            this.cmbExpress.FormattingEnabled = true;
            this.cmbExpress.Name = "cmbExpress";
            // 
            // btnRecover
            // 
            resources.ApplyResources(this.btnRecover, "btnRecover");
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.UseVisualStyleBackColor = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // btnReplace
            // 
            resources.ApplyResources(this.btnReplace, "btnReplace");
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lbRes
            // 
            resources.ApplyResources(this.lbRes, "lbRes");
            this.lbRes.FormattingEnabled = true;
            this.lbRes.Name = "lbRes";
            // 
            // WizTitleFixer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.cmbExpress);
            this.Controls.Add(this.lbPre);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnRepView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WizTitleFixer";
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

