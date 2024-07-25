namespace MallKioskApp_Final
{
    partial class StoreMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreMenu));
            this.titleLogo = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.RichTextBox();
            this.storesBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLogo
            // 
            this.titleLogo.BackColor = System.Drawing.Color.Transparent;
            this.titleLogo.Font = new System.Drawing.Font("Modern No. 20", 68.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLogo.Location = new System.Drawing.Point(69, -24);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(690, 147);
            this.titleLogo.TabIndex = 3;
            this.titleLogo.Text = "Cribbs Causeway";
            this.titleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.SystemColors.Control;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Modern No. 20", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(272, 116);
            this.searchBar.MaxLength = 30;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(265, 33);
            this.searchBar.TabIndex = 4;
            this.searchBar.Tag = "Search, Find";
            this.searchBar.Text = "";
            // 
            // storesBtn
            // 
            this.storesBtn.BackColor = System.Drawing.Color.Transparent;
            this.storesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storesBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storesBtn.Location = new System.Drawing.Point(89, 239);
            this.storesBtn.Name = "storesBtn";
            this.storesBtn.Size = new System.Drawing.Size(163, 73);
            this.storesBtn.TabIndex = 6;
            this.storesBtn.Text = "STORES";
            this.storesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.storesBtn);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.titleLogo);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "StoreMenu";
            this.Text = "StoreMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLogo;
        private System.Windows.Forms.RichTextBox searchBar;
        private System.Windows.Forms.Label storesBtn;
    }
}