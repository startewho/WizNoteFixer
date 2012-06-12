namespace WizTitleFixer
{
    partial class Folders
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
            this.tbFolderDocs = new System.Windows.Forms.TextBox();
            this.cmbFolderList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbFolderDocs
            // 
            this.tbFolderDocs.Location = new System.Drawing.Point(22, 38);
            this.tbFolderDocs.Multiline = true;
            this.tbFolderDocs.Name = "tbFolderDocs";
            this.tbFolderDocs.Size = new System.Drawing.Size(383, 172);
            this.tbFolderDocs.TabIndex = 0;
            // 
            // cmbFolderList
            // 
            this.cmbFolderList.FormattingEnabled = true;
            this.cmbFolderList.Location = new System.Drawing.Point(22, 12);
            this.cmbFolderList.Name = "cmbFolderList";
            this.cmbFolderList.Size = new System.Drawing.Size(383, 20);
            this.cmbFolderList.TabIndex = 1;
            this.cmbFolderList.SelectedIndexChanged += new System.EventHandler(this.cmbFolderList_SelectedIndexChanged);
            // 
            // Folders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 222);
            this.Controls.Add(this.cmbFolderList);
            this.Controls.Add(this.tbFolderDocs);
            this.Name = "Folders";
            this.Text = "Folders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFolderDocs;
        private System.Windows.Forms.ComboBox cmbFolderList;
    }
}