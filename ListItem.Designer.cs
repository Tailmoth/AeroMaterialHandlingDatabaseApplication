namespace AeroMaterialHandlingDatabaseApplication
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPictureListItem = new System.Windows.Forms.PictureBox();
            this.lblTitleListItem = new System.Windows.Forms.Label();
            this.tbShortDescListItem = new System.Windows.Forms.TextBox();
            this.lblTagsListItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureListItem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPictureListItem
            // 
            this.pbPictureListItem.Image = global::AeroMaterialHandlingDatabaseApplication.Properties.Resources.Logo_Complete_Short_Hook_Transparent_300dpi_405_;
            this.pbPictureListItem.Location = new System.Drawing.Point(3, 3);
            this.pbPictureListItem.Name = "pbPictureListItem";
            this.pbPictureListItem.Size = new System.Drawing.Size(150, 150);
            this.pbPictureListItem.TabIndex = 0;
            this.pbPictureListItem.TabStop = false;
            // 
            // lblTitleListItem
            // 
            this.lblTitleListItem.AutoSize = true;
            this.lblTitleListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleListItem.Location = new System.Drawing.Point(159, 3);
            this.lblTitleListItem.Name = "lblTitleListItem";
            this.lblTitleListItem.Size = new System.Drawing.Size(55, 24);
            this.lblTitleListItem.TabIndex = 1;
            this.lblTitleListItem.Text = "Tittle";
            // 
            // tbShortDescListItem
            // 
            this.tbShortDescListItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbShortDescListItem.Location = new System.Drawing.Point(159, 74);
            this.tbShortDescListItem.Multiline = true;
            this.tbShortDescListItem.Name = "tbShortDescListItem";
            this.tbShortDescListItem.ReadOnly = true;
            this.tbShortDescListItem.Size = new System.Drawing.Size(677, 79);
            this.tbShortDescListItem.TabIndex = 2;
            // 
            // lblTagsListItem
            // 
            this.lblTagsListItem.AutoSize = true;
            this.lblTagsListItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTagsListItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagsListItem.Location = new System.Drawing.Point(159, 51);
            this.lblTagsListItem.Name = "lblTagsListItem";
            this.lblTagsListItem.Size = new System.Drawing.Size(44, 20);
            this.lblTagsListItem.TabIndex = 3;
            this.lblTagsListItem.Text = "Tags";
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.lblTagsListItem);
            this.Controls.Add(this.tbShortDescListItem);
            this.Controls.Add(this.lblTitleListItem);
            this.Controls.Add(this.pbPictureListItem);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(846, 159);
            this.Load += new System.EventHandler(this.ListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureListItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPictureListItem;
        private System.Windows.Forms.Label lblTitleListItem;
        private System.Windows.Forms.TextBox tbShortDescListItem;
        private System.Windows.Forms.Label lblTagsListItem;
    }
}
