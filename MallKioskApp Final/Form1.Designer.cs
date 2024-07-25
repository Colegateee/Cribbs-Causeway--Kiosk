using System;

namespace MallKioskApp_Final
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
            this.titleLogo = new System.Windows.Forms.Label();
            this.searchBar = new System.Windows.Forms.RichTextBox();
            this.storesHover = new System.Windows.Forms.Label();
            this.storesBtn = new System.Windows.Forms.Label();
            this.dining = new System.Windows.Forms.Label();
            this.entertainment = new System.Windows.Forms.Label();
            this.maps = new System.Windows.Forms.Label();
            this.recommendLbl = new System.Windows.Forms.Label();
            this.errortext = new System.Windows.Forms.Label();
            this.fridays1 = new MallKioskApp_Final.fridays();
            this.burgerKing1 = new MallKioskApp_Final.burgerKing();
            this.greggs1 = new MallKioskApp_Final.greggs();
            this.kfc1 = new MallKioskApp_Final.kfc();
            this.diningMenu = new MallKioskApp_Final.dining();
            this.SuspendLayout();
            // 
            // titleLogo
            // 
            this.titleLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLogo.BackColor = System.Drawing.Color.Transparent;
            this.titleLogo.Font = new System.Drawing.Font("Modern No. 20", 68.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLogo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLogo.Location = new System.Drawing.Point(337, -24);
            this.titleLogo.Name = "titleLogo";
            this.titleLogo.Size = new System.Drawing.Size(673, 147);
            this.titleLogo.TabIndex = 2;
            this.titleLogo.Text = "Cribbs Causeway";
            this.titleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLogo.Click += new System.EventHandler(this.titleLogo_Click);
            // 
            // searchBar
            // 
            this.searchBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBar.BackColor = System.Drawing.SystemColors.Control;
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Font = new System.Drawing.Font("Modern No. 20", 15.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBar.Location = new System.Drawing.Point(519, 126);
            this.searchBar.MaxLength = 30;
            this.searchBar.Multiline = false;
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(265, 33);
            this.searchBar.TabIndex = 3;
            this.searchBar.Tag = "Search, Find";
            this.searchBar.Text = "";
            this.searchBar.WordWrap = false;
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // storesHover
            // 
            this.storesHover.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.storesHover.Location = new System.Drawing.Point(112, 288);
            this.storesHover.Name = "storesHover";
            this.storesHover.Size = new System.Drawing.Size(0, 1);
            this.storesHover.TabIndex = 5;
            // 
            // storesBtn
            // 
            this.storesBtn.BackColor = System.Drawing.Color.Transparent;
            this.storesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storesBtn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storesBtn.Location = new System.Drawing.Point(710, 294);
            this.storesBtn.Name = "storesBtn";
            this.storesBtn.Size = new System.Drawing.Size(251, 127);
            this.storesBtn.TabIndex = 5;
            this.storesBtn.Text = "STORES AND SERVICES";
            this.storesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storesBtn.Click += new System.EventHandler(this.storesBtn_Click);
            // 
            // dining
            // 
            this.dining.BackColor = System.Drawing.Color.Transparent;
            this.dining.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dining.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dining.Location = new System.Drawing.Point(305, 216);
            this.dining.Name = "dining";
            this.dining.Size = new System.Drawing.Size(311, 73);
            this.dining.TabIndex = 7;
            this.dining.Text = "DINING ";
            this.dining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dining.Click += new System.EventHandler(this.dining_Click);
            // 
            // entertainment
            // 
            this.entertainment.BackColor = System.Drawing.Color.Transparent;
            this.entertainment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entertainment.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entertainment.Location = new System.Drawing.Point(305, 321);
            this.entertainment.Name = "entertainment";
            this.entertainment.Size = new System.Drawing.Size(311, 73);
            this.entertainment.TabIndex = 8;
            this.entertainment.Text = "ENTERTAINMENT";
            this.entertainment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maps
            // 
            this.maps.BackColor = System.Drawing.Color.Transparent;
            this.maps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maps.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maps.Location = new System.Drawing.Point(683, 216);
            this.maps.Name = "maps";
            this.maps.Size = new System.Drawing.Size(311, 73);
            this.maps.TabIndex = 10;
            this.maps.Text = "MAP";
            this.maps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maps.Click += new System.EventHandler(this.maps_Click);
            // 
            // recommendLbl
            // 
            this.recommendLbl.BackColor = System.Drawing.Color.Transparent;
            this.recommendLbl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.recommendLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendLbl.Location = new System.Drawing.Point(0, 473);
            this.recommendLbl.Name = "recommendLbl";
            this.recommendLbl.Size = new System.Drawing.Size(311, 73);
            this.recommendLbl.TabIndex = 11;
            this.recommendLbl.Text = "RECOMMENDED:";
            this.recommendLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errortext
            // 
            this.errortext.BackColor = System.Drawing.Color.Transparent;
            this.errortext.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errortext.ForeColor = System.Drawing.Color.DarkRed;
            this.errortext.Location = new System.Drawing.Point(519, 95);
            this.errortext.Name = "errortext";
            this.errortext.Size = new System.Drawing.Size(265, 23);
            this.errortext.TabIndex = 17;
            // 
            // fridays1
            // 
            this.fridays1.BackColor = System.Drawing.Color.Transparent;
            this.fridays1.Location = new System.Drawing.Point(1, 126);
            this.fridays1.Name = "fridays1";
            this.fridays1.Size = new System.Drawing.Size(1305, 674);
            this.fridays1.TabIndex = 14;
            // 
            // burgerKing1
            // 
            this.burgerKing1.BackColor = System.Drawing.Color.Transparent;
            this.burgerKing1.Location = new System.Drawing.Point(-5, 114);
            this.burgerKing1.MaximumSize = new System.Drawing.Size(1311, 680);
            this.burgerKing1.MinimumSize = new System.Drawing.Size(1311, 680);
            this.burgerKing1.Name = "burgerKing1";
            this.burgerKing1.Size = new System.Drawing.Size(1311, 680);
            this.burgerKing1.TabIndex = 13;
            // 
            // greggs1
            // 
            this.greggs1.BackColor = System.Drawing.Color.Transparent;
            this.greggs1.Location = new System.Drawing.Point(5, 114);
            this.greggs1.MaximumSize = new System.Drawing.Size(1305, 674);
            this.greggs1.MinimumSize = new System.Drawing.Size(1305, 674);
            this.greggs1.Name = "greggs1";
            this.greggs1.Size = new System.Drawing.Size(1305, 674);
            this.greggs1.TabIndex = 15;
            // 
            // kfc1
            // 
            this.kfc1.BackColor = System.Drawing.Color.Transparent;
            this.kfc1.Location = new System.Drawing.Point(1, 114);
            this.kfc1.Name = "kfc1";
            this.kfc1.Size = new System.Drawing.Size(1305, 674);
            this.kfc1.TabIndex = 16;
            // 
            // diningMenu
            // 
            this.diningMenu.BackColor = System.Drawing.Color.Transparent;
            this.diningMenu.Location = new System.Drawing.Point(-5, 114);
            this.diningMenu.MaximumSize = new System.Drawing.Size(1314, 686);
            this.diningMenu.MinimumSize = new System.Drawing.Size(1314, 686);
            this.diningMenu.Name = "diningMenu";
            this.diningMenu.Size = new System.Drawing.Size(1314, 686);
            this.diningMenu.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 801);
            this.Controls.Add(this.errortext);
            this.Controls.Add(this.recommendLbl);
            this.Controls.Add(this.storesBtn);
            this.Controls.Add(this.maps);
            this.Controls.Add(this.entertainment);
            this.Controls.Add(this.dining);
            this.Controls.Add(this.storesHover);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.titleLogo);
            this.Controls.Add(this.fridays1);
            this.Controls.Add(this.burgerKing1);
            this.Controls.Add(this.greggs1);
            this.Controls.Add(this.kfc1);
            this.Controls.Add(this.diningMenu);
            this.MaximumSize = new System.Drawing.Size(1320, 840);
            this.MinimumSize = new System.Drawing.Size(1320, 840);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Label titleLogo;
        private System.Windows.Forms.RichTextBox searchBar;
        private System.Windows.Forms.Label storesHover;
        private System.Windows.Forms.Label storesBtn;
        private System.Windows.Forms.Label dining;
        private System.Windows.Forms.Label entertainment;
        private System.Windows.Forms.Label maps;
        private System.Windows.Forms.Label recommendLbl;
        private dining diningMenu;
        private burgerKing burgerKing1;
        private fridays fridays1;
        private greggs greggs1;
        private kfc kfc1;
        private System.Windows.Forms.Label errortext;
    }
}

