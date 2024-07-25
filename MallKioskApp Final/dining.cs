using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MallKioskApp_Final
{
    public partial class dining : UserControl
    {
        //-------------------BUTTONS--------------------
        bool burgerKingHover = true;
        bool greggsHover = true;
        bool fridaysHover = true;
        bool kfcHover = true;
        bool backHover;
        public dining()
        {
            //Initialise
            InitializeComponent();
            burgerKing1.Hide();
            fridays1.Hide();
            greggs1.Hide();
            kfc1.Hide();
            //------------------------------------------
            //---------------BUTTONS--------------------
            burgerKingBtn.MouseEnter += OnMouseEnterBurgerKing;
            burgerKingBtn.MouseLeave += OnMouseLeaveBurgerKing;

            kfcBtn.MouseEnter += OnMouseEnterKfcBtn;
            kfcBtn.MouseLeave += OnMouseLeaveKfcBtn;

            greggsBtn.MouseEnter += OnMouseEnterGreggsBtn;
            greggsBtn.MouseLeave += OnMouseLeaveGreggsBtn;

            fridaysBtn.MouseEnter += OnMouseEnterFridaysBtn;
            fridaysBtn.MouseLeave += OnMouseLeaveFridaysBtn;

            backBtn.MouseEnter += OnMouseEnterBack;
            backBtn.MouseLeave += OnMouseLeaveBack;
            //------------------------------------------
        }

        //---------------BUTTONS---------------------
        //---------------BURGER KING-----------------
        private async void OnMouseEnterBurgerKing(object sender, EventArgs e)
        {
            burgerKingHover = true;
            float fontSize = burgerKingBtn.Font.Size;

            while (burgerKingHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                burgerKingBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveBurgerKing(Object sender, EventArgs e)
        {
            burgerKingHover = false;
            float fontSize = burgerKingBtn.Font.Size;

            while (!burgerKingHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                burgerKingBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private void burgerKingBtn_Click(object sender, EventArgs e)
        {
            burgerKing1.BringToFront();
            burgerKing1.Show();
            
        }
        //---------------Fridays-----------------
        private async void OnMouseEnterFridaysBtn(object sender, EventArgs e)
        {
            fridaysHover = true;
            float fontSize = fridaysBtn.Font.Size;

            while (fridaysHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                fridaysBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveFridaysBtn(Object sender, EventArgs e)
        {
            fridaysHover = false;
            float fontSize = fridaysBtn.Font.Size;

            while (!fridaysHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                fridaysBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private void fridaysBtn_Click(object sender, EventArgs e)
        {
            fridays1.BringToFront();
            fridays1.Show();
            
        }
        //---------------KFC-----------------
        private async void OnMouseEnterKfcBtn(object sender, EventArgs e)
        {
            kfcHover = true;
            float fontSize = kfcBtn.Font.Size;

            while (kfcHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                kfcBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveKfcBtn(Object sender, EventArgs e)
        {
            kfcHover = false;
            float fontSize = kfcBtn.Font.Size;

            while (!kfcHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                kfcBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private void kfcBtn_Click(object sender, EventArgs e)
        {
            kfc1.BringToFront();
            kfc1.Show();
        }
        //---------------GREGGS-----------------
        private async void OnMouseEnterGreggsBtn(object sender, EventArgs e)
        {
            greggsHover = true;
            float fontSize = greggsBtn.Font.Size;

            while (greggsHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                greggsBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveGreggsBtn(Object sender, EventArgs e)
        {
            greggsHover = false;
            float fontSize = greggsBtn.Font.Size;

            while (!greggsHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                greggsBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private void greggsBtn_Click(object sender, EventArgs e)
        {
            greggs1.BringToFront();
            greggs1.Show();
        }
        //-------------------------BACK BUTTON------------------------
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
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //--------------------------------------------------------------
        //---------------------------------------------
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void burgerKingLogo_Click(object sender, EventArgs e)
        {

        }

        private void burgerKingText_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
