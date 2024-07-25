namespace MallKioskApp_Final
{
    partial class lowerMap
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
            this.backBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.upper = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upper)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Location = new System.Drawing.Point(3, 648);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(305, 47);
            this.backBtn.TabIndex = 8;
            this.backBtn.Text = "Upper ⬅";
            this.backBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.upper);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 632);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1296, 645);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // upper
            // 
            this.upper.BackgroundImage = global::MallKioskApp_Final.Properties.Resources.MicrosoftTeams_image1;
            this.upper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upper.Location = new System.Drawing.Point(18, 18);
            this.upper.Name = "upper";
            this.upper.Size = new System.Drawing.Size(1235, 597);
            this.upper.TabIndex = 0;
            this.upper.TabStop = false;
            // 
            // lowerMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.backBtn);
            this.Name = "lowerMap";
            this.Size = new System.Drawing.Size(1287, 695);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label backBtn;
        private System.Windows.Forms.PictureBox upper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
