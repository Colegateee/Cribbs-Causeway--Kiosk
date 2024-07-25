using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MallKioskApp_Final
{
    public partial class mapF : Form
    {
        bool backHover;
        bool upperHover;
        public mapF()
        {
            InitializeComponent();
            CenterToScreen();

            lowerMap1.Hide();

            backBtn.MouseEnter += OnMouseEnterBack;
            backBtn.MouseLeave += OnMouseLeaveBack;

            lower.MouseEnter += OnMouseEnterUpper;
            lower.MouseLeave += OnMouseLeaveUpper;
        }

        private async void OnMouseEnterBack(object sender, EventArgs e)
        {
            backHover = true;
            float fontSize = backBtn.Font.Size;

            while (backHover && fontSize <= 22)
            {
                fontSize += 0.5f;
                backBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveBack(Object sender, EventArgs e)
        {
            backHover = false;
            float fontSize = backBtn.Font.Size;

            while (!backHover && fontSize >= 20)
            {
                fontSize -= 0.5f;
                backBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseEnterUpper(object sender, EventArgs e)
        {
            upperHover = true;
            float fontSize = lower.Font.Size;

            while (upperHover && fontSize <= 22)
            {
                fontSize += 0.5f;
                lower.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveUpper(Object sender, EventArgs e)
        {
            upperHover = false;
            float fontSize = lower.Font.Size;

            while (!upperHover && fontSize >= 20)
            {
                fontSize -= 0.5f;
                lower.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }

        private void upper_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 ff1 = new Form1();
            this.Hide();
            ff1.Show();

        }

        private void titleLogo_Click(object sender, EventArgs e)
        {

        }

        private void mapF_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            lowerMap1.Show();
        }
    }
}
