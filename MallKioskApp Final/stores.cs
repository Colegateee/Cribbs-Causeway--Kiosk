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
    public partial class stores : Form
    {
        bool burgerKingHover = true;
        bool greggsHover = true;
        bool fridaysHover = true;
        bool kfcHover = true;
        bool backHover;

        public stores()
        {
            InitializeComponent();
            three1.Hide();
            apple1.Hide();
            apple2.Hide();
            apple3.Hide();

            CenterToScreen();
            //------------------------------------------
            //---------------BUTTONS--------------------
            threeBtn.MouseEnter += OnMouseEnterBurgerKing;
            threeBtn.MouseLeave += OnMouseLeaveBurgerKing;

            gsBtn.MouseEnter += OnMouseEnterKfcBtn;
            gsBtn.MouseLeave += OnMouseLeaveKfcBtn;

            bmBtn.MouseEnter += OnMouseEnterGreggsBtn;
            bmBtn.MouseLeave += OnMouseLeaveGreggsBtn;

            appleBtn.MouseEnter += OnMouseEnterFridaysBtn;
            appleBtn.MouseLeave += OnMouseLeaveFridaysBtn;

            backBtn.MouseEnter += OnMouseEnterBack;
            backBtn.MouseLeave += OnMouseLeaveBack;
            //------------------------------------------
        }

        //---------------BUTTONS---------------------
        //---------------BURGER KING-----------------
        private async void OnMouseEnterBurgerKing(object sender, EventArgs e)
        {
            burgerKingHover = true;
            float fontSize = threeBtn.Font.Size;

            while (burgerKingHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                threeBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveBurgerKing(Object sender, EventArgs e)
        {
            burgerKingHover = false;
            float fontSize = threeBtn.Font.Size;

            while (!burgerKingHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                threeBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        //---------------Fridays-----------------
        private async void OnMouseEnterFridaysBtn(object sender, EventArgs e)
        {
            fridaysHover = true;
            float fontSize = appleBtn.Font.Size;

            while (fridaysHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                appleBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveFridaysBtn(Object sender, EventArgs e)
        {
            fridaysHover = false;
            float fontSize = appleBtn.Font.Size;

            while (!fridaysHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                appleBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        //---------------KFC-----------------
        private async void OnMouseEnterKfcBtn(object sender, EventArgs e)
        {
            kfcHover = true;
            float fontSize = gsBtn.Font.Size;

            while (kfcHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                gsBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveKfcBtn(Object sender, EventArgs e)
        {
            kfcHover = false;
            float fontSize = gsBtn.Font.Size;

            while (!kfcHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                gsBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        //---------------GREGGS-----------------
        private async void OnMouseEnterGreggsBtn(object sender, EventArgs e)
        {
            greggsHover = true;
            float fontSize = bmBtn.Font.Size;

            while (greggsHover && fontSize <= 18)
            {
                fontSize += 0.5f;
                bmBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
        }
        private async void OnMouseLeaveGreggsBtn(Object sender, EventArgs e)
        {
            greggsHover = false;
            float fontSize = bmBtn.Font.Size;

            while (!greggsHover && fontSize >= 14)
            {
                fontSize -= 0.5f;
                bmBtn.Font = new Font("Modern No. 20", fontSize, FontStyle.Bold);
                await Task.Delay(1);
            }
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
            Form1 ff1 = new Form1();
            ff1.Show();
            hide();
        }

        private void hide()
        {
            this.Hide();
        }
        //--------------------------------------------------------------
        //---------------------------------------------
        private void burgerKingBtn_Click(object sender, EventArgs e)
        {
            three1.BringToFront();
            three1.Show();
        }

        private void appleBtn_Click(object sender, EventArgs e)
        {
            apple3.BringToFront();
            apple3.Show();
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Form1 ff1 = new Form1();
            ff1.Show();
            hide();
        }
    }
}
