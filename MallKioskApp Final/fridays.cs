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
    public partial class fridays : UserControl
    {
        bool backHover;
        public fridays()
        {
            InitializeComponent();
            //BUTTONS
            backBtn.MouseEnter += OnMouseEnterBack;
            backBtn.MouseLeave += OnMouseLeaveBack;

        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void OnMouseEnterBack(object sender, EventArgs e)
        {
            backHover = true;
            float fontSize = backBtn.Font.Size;

            while (backHover && fontSize <= 16)
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

            while (!backHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                backBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
    }
}
