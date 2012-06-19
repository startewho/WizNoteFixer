namespace EventCounter
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
            this.tbCountTo = new System.Windows.Forms.TextBox();
            this.lbCountTo = new System.Windows.Forms.Label();
            this.lbReachTo = new System.Windows.Forms.Label();
            this.tbReachTo = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCountTo
            // 
            this.tbCountTo.Location = new System.Drawing.Point(214, 31);
            this.tbCountTo.Name = "tbCountTo";
            this.tbCountTo.Size = new System.Drawing.Size(208, 21);
            this.tbCountTo.TabIndex = 0;
            // 
            // lbCountTo
            // 
            this.lbCountTo.AutoSize = true;
            this.lbCountTo.Location = new System.Drawing.Point(60, 34);
            this.lbCountTo.Name = "lbCountTo";
            this.lbCountTo.Size = new System.Drawing.Size(47, 12);
            this.lbCountTo.TabIndex = 1;
            this.lbCountTo.Text = "CountTo";
            // 
            // lbReachTo
            // 
            this.lbReachTo.AutoSize = true;
            this.lbReachTo.Location = new System.Drawing.Point(60, 105);
            this.lbReachTo.Name = "lbReachTo";
            this.lbReachTo.Size = new System.Drawing.Size(47, 12);
            this.lbReachTo.TabIndex = 3;
            this.lbReachTo.Text = "ReachTo";
            // 
            // tbReachTo
            // 
            this.tbReachTo.Location = new System.Drawing.Point(214, 102);
            this.tbReachTo.Name = "tbReachTo";
            this.tbReachTo.Size = new System.Drawing.Size(208, 21);
            this.tbReachTo.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(60, 151);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(60, 210);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(248, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Second Hander";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lbReachTo);
            this.Controls.Add(this.tbReachTo);
            this.Controls.Add(this.lbCountTo);
            this.Controls.Add(this.tbCountTo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCountTo;
        private System.Windows.Forms.Label lbCountTo;
        private System.Windows.Forms.Label lbReachTo;
        private System.Windows.Forms.TextBox tbReachTo;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRemove;
    }
}

