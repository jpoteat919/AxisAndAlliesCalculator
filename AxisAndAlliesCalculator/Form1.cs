using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AxisAndAlliesCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public int gameNum = 0;
        public string sPath = "", gPath = "currentGame", gameMode = "";


        private void btnNew_Click(object sender, EventArgs e)
        {
                       
            switch (cbGame.SelectedItem.ToString())
            {
                case "Game 1":
                    gameNum = 1;
                    sPath = "Game1";
                    if (File.Exists("Game1.txt"))
                        File.Delete("Game1.txt");
                    break;
                case "Game 2":
                    gameNum = 2;
                    sPath = "Game2";
                    if (File.Exists("Game2.txt"))
                        File.Delete("Game2.txt");
                    break;
                case "Game 3":
                    gameNum = 3;
                    sPath = "Game3";
                    if (File.Exists("Game3.txt"))
                        File.Delete("Game3.txt");
                    break;
                case "Game 4":
                    gameNum = 4;
                    sPath = "Game4";
                    if (File.Exists("Game4.txt"))
                        File.Delete("Game4.txt");
                    break;
                case "Game 5":
                    gameNum = 5;
                    sPath = "Game5";
                    if (File.Exists("Game5.txt"))
                        File.Delete("Game5.txt");
                    break;
            }
         
            btnNew.Visible = false;
            btnLaod.Visible = false;
            cbGame.Visible = false;
            btnPasific.Visible = true;
            btnEurope.Visible = true;
            btnGloabal.Visible = true;
        }

        private void btnLaod_Click(object sender, EventArgs e)
        {
            string turn;
            frmGerm Ger = new frmGerm();
            frmSov Sov = new frmSov();
            frmJap Jap = new frmJap();
            frmUS US = new frmUS();
            frmChi Chi = new frmChi();
            frmUKE UKE = new frmUKE();
            frmUKP UKP = new frmUKP();
            frmIt It = new frmIt();
            frmAnz Anz = new frmAnz();
            frmFra Fra = new frmFra();
            switch (cbGame.SelectedItem.ToString())
            {
                case "Game 1":
                    gameNum = 1;
                    sPath = "Game1";
                    break;
                case "Game 2":
                    gameNum = 2;
                    sPath = "Game2";
                    break;
                case "Game 3":
                    gameNum = 3;
                    sPath = "Game3";
                    break;
                case "Game 4":
                    gameNum = 4;
                    sPath = "Game4";
                    break;
                case "Game 5":
                    gameNum = 5;
                    sPath = "Game5";
                    break;
            }

            System.IO.StreamReader readFile = new System.IO.StreamReader(sPath);
            turn = readFile.ReadLine();
            turn = readFile.ReadLine();

            switch (turn)
            {
                case "Ger":
                    Ger.Show();
                    this.Hide();
                    break;
                case "Sov":
                    Sov.Show();
                    this.Hide();
                    break;
                case "Jap":
                    Jap.Show();
                    this.Hide();
                    break;
                case "US":
                    US.Show();
                    this.Hide();
                    break;
                case "Chi":
                    Chi.Show();
                    this.Hide();
                    break;
                case "UKE":
                    UKE.Show();
                    this.Hide();
                    break;
                case "UKP":
                    UKP.Show();
                    this.Hide();
                    break;
                case "It":
                    It.Show();
                    this.Hide();
                    break;
                case "Anz":
                    Anz.Show();
                    this.Hide();
                    break;
                case "Fra":
                    Fra.Show();
                    this.Hide();
                    break;
            }
            readFile.Close();
        }

        private void btnTut_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEurope_Click(object sender, EventArgs e)
        {
            StreamWriter SaveFile = new StreamWriter(sPath);
            StreamWriter SaveFile2 = new StreamWriter(gPath);
            SaveFile2.WriteLine(sPath.ToString());
            SaveFile2.Close();
            gameMode = "E";

            SaveFile.WriteLine(gameMode);
            SaveFile.WriteLine("Ger");
            SaveFile.WriteLine("30 30 false 0  false false false 0");
            SaveFile.WriteLine("37 37 false true 0 false 0");
            SaveFile.WriteLine("35 35 false true true");
            SaveFile.WriteLine("28 28 true");
            SaveFile.WriteLine("10 10 false false false false");
            SaveFile.WriteLine("17 17");

            SaveFile.Close();
            frmGerm Ger = new frmGerm();
            Ger.Show();
            this.Hide();
        }

        private void btnPasific_Click(object sender, EventArgs e)
        {
            StreamWriter SaveFile = new StreamWriter(sPath);
            StreamWriter SaveFile2 = new StreamWriter(gPath);
            SaveFile2.WriteLine(sPath.ToString());
            SaveFile2.Close();
            gameMode = "P";

            SaveFile.WriteLine(gameMode);
            SaveFile.WriteLine("Jap");
            SaveFile.WriteLine("26 26 false false false false");
            SaveFile.WriteLine("17 17 false true true true true");
            SaveFile.WriteLine("12 12 true");
            SaveFile.WriteLine("17 17 true");
            SaveFile.WriteLine("10 10 true false");

            SaveFile.Close();
            frmJap Jap = new frmJap();
            Jap.Show();
            this.Hide();
        }

        private void btnGloabal_Click(object sender, EventArgs e)
        {
            StreamWriter SaveFile = new StreamWriter(sPath);
            StreamWriter SaveFile2 = new StreamWriter(gPath);
            SaveFile2.WriteLine(sPath.ToString());
            SaveFile2.Close();
            gameMode = "G";

            SaveFile.WriteLine(gameMode);
            SaveFile.WriteLine("Ger");
            SaveFile.WriteLine("30 30 false 0  false false false 0");
            SaveFile.WriteLine("37 37 false true 0 false 0");
            SaveFile.WriteLine("26 26 false false false false");
            SaveFile.WriteLine("52 52 false true true true true false");
            SaveFile.WriteLine("12 12 true");
            SaveFile.WriteLine("28 28 true");
            SaveFile.WriteLine("17 17 true");
            SaveFile.WriteLine("10 10 false false false false");
            SaveFile.WriteLine("10 10 true false");
            SaveFile.WriteLine("19 19");

            SaveFile.Close();
            frmGerm Ger = new frmGerm();
            Ger.Show();
            this.Hide();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbGame.SelectedIndex = 0;
        }

        private void cbGame_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
