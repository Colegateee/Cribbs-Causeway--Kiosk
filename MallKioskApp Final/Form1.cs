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

    public partial class Form1 : Form
    {


        //---------------Buttons-------------------
        bool storeHover = true;
        bool diningHover = true;
        bool settingsHover = true;
        bool mapHover = true;
        bool entertainmentHover = true;
        //-----------------------------------------------

        public Form1()
        {
            //-----------------------------------------------
            //Initialise
            //Original location: -10, 165
            InitializeComponent();
            CenterToScreen();

            diningMenu.Hide();
            burgerKing1.Hide();
            fridays1.Hide();
            greggs1.Hide();
            kfc1.Hide();

            //-----------------------------------------------

            //Search Function
            this.searchBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchFunction);
            mapF map1 = new mapF();
            stores stores1 = new stores();
            //---------------Buttons-------------------
            storesBtn.MouseEnter += OnMouseEnterStoreBtn;
            storesBtn.MouseLeave += OnMouseLeaveStoreBtn;

            dining.MouseEnter += OnMouseEnterDining;
            dining.MouseLeave += OnMouseLeaveDining;

            maps.MouseEnter += OnMouseEnterSettings;
            maps.MouseLeave += OnMouseLeaveSettings;

            maps.MouseEnter += OnMouseEnterMap;
            maps.MouseLeave += OnMouseLeaveMap;

            entertainment.MouseEnter += OnMouseEnterEntertainment;
            entertainment.MouseLeave += OnMouseLeaveEntertainment;
            //-----------------------------------------------


        }
        //Search Function
        void searchFunction(object sender, KeyEventArgs e)
        {
            string error = searchBar.Text;
            if (e.KeyValue == Convert.ToInt32(Keys.Enter))
            {
                string burgerKingWord = "burger king";
                string searchBarText = searchBar.Text;
                string checker = "";
                string[] list = { "burger king", "fridays", "burgerking", "greggs", "kfc", "apple", "three", "3", "dining", "store", "food", "chicken", "burger", "phone", "bread"};
                                    //0             //1         //2         //3       //4   //5     //6     //7     //8        //9    //10    //11       //12     //13     
                for (int j = 0; j < list.Length; j++)
                {
                    checker = "";
                    char[] character = list[j].ToCharArray();
                    foreach (char a in character)
                    {
                        foreach (char b in searchBarText)
                        {
                            if (a.ToString().ToLower() == b.ToString().ToLower())
                            {
                                checker += b;
                                break;
                            }
                        }
                        
                    }
                    if (list[j].ToLower() == checker.ToLower())
                    {
                        errortext.Text = "";
                        if (j == 0 || j == 2 || j == 12)
                        {
                            burgerKing1.BringToFront();
                            burgerKing1.Show();
                        }
                        else if(j == 1)
                        {
                            fridays1.BringToFront();
                            fridays1.Show();
                        }
                        else if(j == 3 || j == 14)
                        {
                            greggs1.BringToFront();
                            greggs1.Show();
                        }
                        else if (j == 4 || j == 11)
                        {
                            kfc1.BringToFront();
                            kfc1.Show();
                        }
                        else if (j == 8 || j == 10)
                        {
                            diningMenu.BringToFront();
                            diningMenu.Show();
                        }
                        else
                        {
                            stores stores1 = new stores();
                            stores1.Show();
                            this.Hide();
                        }
                        break;
                    }
                    errortext.Text = ("No Results found for the word: " + error);

                }
                searchBar.Text = "";
            }
            
        }

        //---------------BUTTONS------------------------
        //---------------STORE Button-------------------
        public async void OnMouseEnterStoreBtn(object sender, EventArgs e)
        {
            storeHover = true;
            float fontSize = storesBtn.Font.Size;

            while (fontSize <= 20 && storeHover)
            {
                fontSize += 1;
                storesBtn.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }

        public async void OnMouseLeaveStoreBtn(object sender, EventArgs e)
        {
            storeHover = false;
            float fontSize = storesBtn.Font.Size;

            while (fontSize >= 20 && !storeHover)
            {
                fontSize -= 1;
                storesBtn.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }
        //-----------------------------------------------
        //---------------DINING Button-------------------
        public async void OnMouseEnterDining(object sender, EventArgs e) //Hover Animation
        {
            diningHover = true;
            float fontSize = dining.Font.Size;

            while (fontSize <= 25 && diningHover)
            {
                fontSize += 1;
                dining.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }

        public async void OnMouseLeaveDining(object sender, EventArgs e) //Hover Animation
        {
            diningHover = false;
            float fontSize = dining.Font.Size;

            while (fontSize >= 20 && !diningHover)
            {
                fontSize -= 1;
                dining.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }

        private void dining_Click(object sender, EventArgs e)
        {
            diningMenu.BringToFront();
            diningMenu.BringToFront();
            diningMenu.Show();

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            //player.SoundLocation = @"F:\Visual Studio 2017\final kiosk\OneDrive_2024-02-09 (1)\MallKioskApp Final\MallKioskApp Final\Sounds\button\cfa1f779-0954-4623-a7db-cc93a703a7f9";
            //player.Load();
            //player.Play();
        }
        //-----------------------------------------------
        //---------------SETTINGS Button-------------------
        public async void OnMouseEnterSettings(object sender, EventArgs e)
        {
            settingsHover = true;
            float fontSize = maps.Font.Size;

            while (fontSize <= 25 && settingsHover)
            {
                fontSize += 1;
                maps.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }

        public async void OnMouseLeaveSettings(object sender, EventArgs e)
        {
            settingsHover = false;
            float fontSize = maps.Font.Size;

            while (fontSize >= 20 && !settingsHover)
            {
                fontSize -= 1;
                maps.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }
        //-----------------------------------------------
        //---------------MAP Button-------------------
        public async void OnMouseEnterMap(object sender, EventArgs e)
        {
            mapHover = true;
            float fontSize = maps.Font.Size;

            while (fontSize <= 25 && mapHover)
            {
                fontSize += 1;
                maps.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }

        public async void OnMouseLeaveMap(object sender, EventArgs e)
        {
            mapHover = false;
            float fontSize = maps.Font.Size;

            while (fontSize >= 20 && !mapHover)
            {
                fontSize -= 1;
                maps.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }
        //-----------------------------------------------
        //---------------ENTERTAINMENT Button-------------------
        public async void OnMouseEnterEntertainment(object sender, EventArgs e)
        {
            entertainmentHover = true;
            float fontSize = entertainment.Font.Size;

            while (fontSize <= 25 && entertainmentHover)
            {
                fontSize += 1;
                entertainment.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }

        public async void OnMouseLeaveEntertainment(object sender, EventArgs e)
        {
            entertainmentHover = false;
            float fontSize = entertainment.Font.Size;

            while (fontSize >= 20 && !entertainmentHover)
            {
                fontSize -= 1;
                entertainment.Font = new Font("Modern No. 20", fontSize);
                await Task.Delay(1);
            }
        }
        //-----------------------------------------------
        //-----------------------------------------------


        private void background_Click(object sender, EventArgs e)
        {

        }

        private void storesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            stores stores2 = new stores();
            stores2.Show();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleLogo_Click(object sender, EventArgs e)
        {

        }

        private void dining1_Load(object sender, EventArgs e)
        {

        }

        private void maps_Click(object sender, EventArgs e)
        {
            this.Hide();
            mapF map1 = new mapF();
            map1.Show();
        }

    }

}
