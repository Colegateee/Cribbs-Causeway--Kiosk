namespace MallKioskApp_Final
{
    partial class mapF
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
            this.titleLogo = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upper = new System.Windows.Forms.PictureBox();
            this.lower = new System.Windows.Forms.Label();
            this.upperMap1 = new MallKioskApp_Final.lowerMap();
            this.lowerMap1 = new MallKioskApp_Final.lowerMap();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upper)).BeginInit();
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
            this.titleLogo.TabIndex = 3;
            this.titleLogo.Text = "Cribbs Causeway";
            this.titleLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLogo.Click += new System.EventHandler(this.titleLogo_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Location = new System.Drawing.Point(12, 731);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(305, 61);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back ⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1275, 645);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.upper);
            this.panel1.Controls.Add(this.upperMap1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 632);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // upper
            // 
            this.upper.BackgroundImage = global::MallKioskApp_Final.Properties.Resources.image;
            this.upper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upper.Location = new System.Drawing.Point(18, 18);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(1235, 597);
            this.upper.TabIndex = 0;
            this.upper.TabStop = false;
            this.upper.Click += new System.EventHandler(this.upper_Click);
            // 
            // lower
            // 
            this.lower.BackColor = System.Drawing.Color.Transparent;
            this.lower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lower.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lower.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lower.Location = new System.Drawing.Point(987, 731);
            this.lower.Name = "lower";
            this.lower.Size = new System.Drawing.Size(286, 61);
            this.lower.TabIndex = 7;
            this.lower.Text = "Lower ➨";
            this.lower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lower.Click += new System.EventHandler(this.label1_Click);
            // 
            // upperMap1
            // 
            this.upperMap1.BackColor = System.Drawing.Color.Transparent;
            this.upperMap1.Location = new System.Drawing.Point(-8, -3);
            this.upperMap1.MaximumSize = new System.Drawing.Size(1275, 714);
            this.upperMap1.MinimumSize = new System.Drawing.Size(1275, 714);
            this.upperMap1.Name = "upperMap1";
            this.upperMap1.Size = new System.Drawing.Size(1275, 714);
            this.upperMap1.TabIndex = 1;
            // 
            // lowerMap1
            // 
            this.lowerMap1.BackColor = System.Drawing.Color.Transparent;
            this.lowerMap1.Location = new System.Drawing.Point(9, 93);
            this.lowerMap1.Name = "lowerMap1";
            this.lowerMap1.Size = new System.Drawing.Size(1287, 695);
            this.lowerMap1.TabIndex = 8;
            // 
            // mapF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MallKioskApp_Final.Properties.Resources.BackgroundBlurred;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 801);
            this.Controls.Add(this.lowerMap1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.lower);
            this.Controls.Add(this.titleLogo);
            this.MaximumSize = new System.Drawing.Size(1320, 840);
            this.MinimumSize = new System.Drawing.Size(1320, 840);
            this.Name = "mapF";
            this.Text = "mapF";
            this.Load += new System.EventHandler(this.mapF_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLogo;
        private System.Windows.Forms.Label backBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox upper;
        private System.Windows.Forms.Label lower;
        private lowerMap upperMap1;
        private lowerMap lowerMap1;
    }
}