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
    public partial class frmBuy : Form
    {


        private int mon = 0, tot = 0, inc = 0;
        int gerInc, gerTot, gerChange, sovInc, sovTot, sovChange, japInc, japTot, japChange, usInc, usTot, usChange, chinInc, chinTot, chinChange, ukeInc, ukeTot, ukeChange, ukpInc, ukpTot, ukpChange, itInc, itTot, itChange, anzInc, anzTot, anzChange, fraInc, fraTot, fraChange;
        public string gameMode, sPath = "Game1", gPath = "currentGame", part1, part2, turn, current;
        string ger, sov, jap, us, chin, uke, ukp, it, anz, fra;
        public frmBuy()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            frmGerm germ = new frmGerm();
            frmSov sovi = new frmSov();
            frmJap japf = new frmJap();
            frmUS usf = new frmUS();
            frmChi chif = new frmChi();
            frmUKE ukef = new frmUKE();
            frmUKP ukpf = new frmUKP();
            frmIt itf = new frmIt();
            frmAnz anzf = new frmAnz();
            frmFra fraf = new frmFra();

            System.IO.StreamReader readFile2 = new System.IO.StreamReader(gPath);
            StreamWriter SaveFile = new StreamWriter(sPath);
            sPath = readFile2.ReadLine();
            switch (turn)
            {
                case "Ger":
                    gerTot -= tot;
                    break;
                case "Sov":
                    sovTot -= tot;
                    break;
                case "Jap":
                    japTot -= tot;
                    break;
                case "US":
                    usTot -= tot;
                    break;
                case "Chi":
                    chinTot -=tot;
                    break;
                case "UKE":
                    ukeTot -= tot;
                    break;
                case "UKP":
                    ukpTot -= tot;
                    break;
                case "It":
                    itTot -= tot;
                    break;
                case "Anz":
                    anzTot -= tot;
                    break;
                case "Fra":
                    fraTot -= tot;
                    break;
            }

            SaveFile.WriteLine(gameMode);
            SaveFile.WriteLine(turn);
            SaveFile.WriteLine(gerInc + " " + gerTot + " " + ger.Substring(6));
            SaveFile.WriteLine(sovInc + " " + sovTot + " " + sov.Substring(6));
            SaveFile.WriteLine(japInc + " " + japTot + " " + jap.Substring(6));
            SaveFile.WriteLine(usInc + " " + usTot + " " + us.Substring(6));
            SaveFile.WriteLine(chinInc + " " + chinTot + " " + chin.Substring(6));
            SaveFile.WriteLine(ukeInc + " " + ukeTot + " " + uke.Substring(6));
            SaveFile.WriteLine(ukpInc + " " + ukpTot + " " + ukp.Substring(6));
            SaveFile.WriteLine(itInc + " " + itTot + " " + it.Substring(6));
            SaveFile.WriteLine(anzInc + " " + anzTot + " " + anz.Substring(6));
            SaveFile.WriteLine(fraInc + " " + fraTot);

            SaveFile.Close();
            readFile2.Close();
            switch (turn)
            {
                case "Ger":
                    germ.Show();
                    this.Close();
                    break;
                case "Sov":
                    sovi.Show();
                    this.Close();
                    break;
                case "Jap":
                    japf.Show();
                    this.Close();
                    break;
                case "US":
                    usf.Show();
                    this.Close();
                    break;
                case "Chi":
                    chif.Show();
                    this.Close();
                    break;
                case "UKE":
                    ukef.Show();
                    this.Close();
                    break;
                case "UKP":
                    ukpf.Show();
                    this.Close();
                    break;
                case "It":
                    itf.Show();
                    this.Close();
                    break;
                case "Anz":
                    anzf.Show();
                    this.Close();
                    break;
                case "Fra":
                    fraf.Show();
                    this.Close();
                    break;
            }
            
        }

        private int calc1()
        { 
            tot = (Int32.Parse(txtInfNum.Text) * 3) + (Int32.Parse(txtMec.Text) * 4) + (Int32.Parse(txtArtNum.Text) * 4) + (Int32.Parse(txtTanNum.Text) * 6) + (Int32.Parse(txtMajNum.Text) * 30) + (Int32.Parse(txtMinNum.Text) * 12) + (Int32.Parse(txtAirNum.Text) * 15) + (Int32.Parse(txtNavNum.Text) * 15) + (Int32.Parse(txtFigNum.Text) * 10) + (Int32.Parse(txtTacNum.Text) * 11) + (Int32.Parse(txtStrNum.Text) * 12) + (Int32.Parse(txtBatNum.Text) * 20) + (Int32.Parse(txtAiCNum.Text) * 16) + (Int32.Parse(txtCruNum.Text) * 12) + (Int32.Parse(txtDesNum.Text) * 8) + (Int32.Parse(txtSubNum.Text) * 6) + (Int32.Parse(txtTraNum.Text) * 7) + (Int32.Parse(txtAntNum.Text) * 5);
            if ( tot > mon)
            {
                btnDone.Enabled = false;
                lblErr.Visible = true;
            }
            else
            {
                btnDone.Enabled = true;
                lblErr.Visible = false;
            }
            return tot;
        }
        private void calc()
        {
            tot = (Int32.Parse(txtInfNum.Text) * 3) + (Int32.Parse(txtMec.Text) * 4) + (Int32.Parse(txtArtNum.Text) * 4) + (Int32.Parse(txtTanNum.Text) * 6) + (Int32.Parse(txtMajNum.Text) * 30) + (Int32.Parse(txtMinNum.Text) * 12) + (Int32.Parse(txtAirNum.Text) * 15) + (Int32.Parse(txtNavNum.Text) * 15) + (Int32.Parse(txtFigNum.Text) * 10) + (Int32.Parse(txtTacNum.Text) * 11) + (Int32.Parse(txtStrNum.Text) * 12) + (Int32.Parse(txtBatNum.Text) * 20) + (Int32.Parse(txtAiCNum.Text) * 16) + (Int32.Parse(txtCruNum.Text) * 12) + (Int32.Parse(txtDesNum.Text) * 8) + (Int32.Parse(txtSubNum.Text) * 6) + (Int32.Parse(txtTraNum.Text) * 7) + (Int32.Parse(txtAntNum.Text) * 5);
            txtTotal.Text = tot.ToString();
            if (tot > mon)
            {
                btnDone.Enabled = false;
                lblErr.Visible = true;
            }
            else
            {
                btnDone.Enabled = true;
                lblErr.Visible = false;

                txtLeft.Text = (mon - tot).ToString();
            }
          
        }

        private void txtInfNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtArtNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtMec_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtTanNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtMinNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtMajNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtAirNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtNavNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtAntNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtBatNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtAiCNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtCruNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtDesNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtSubNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtTraNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtFigNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtTacNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void txtStrNum_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void btnInfMin_Click(object sender, EventArgs e)
        {
            txtInfNum.Text = (Int32.Parse(txtInfNum.Text) - 1).ToString();
        }

        private void btnInfPlu_Click(object sender, EventArgs e)
        {
            txtInfNum.Text = (Int32.Parse(txtInfNum.Text) + 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtArtNum.Text = (Int32.Parse(txtArtNum.Text) - 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtArtNum.Text = (Int32.Parse(txtArtNum.Text) + 1).ToString();
        }

        private void btnMecMin_Click(object sender, EventArgs e)
        {
            txtMec.Text = (Int32.Parse(txtMec.Text) - 1).ToString();
        }

        private void btnMecPlu_Click(object sender, EventArgs e)
        {
            txtMec.Text = (Int32.Parse(txtMec.Text) + 1).ToString();
        }

        private void btnTanMin_Click(object sender, EventArgs e)
        {
            txtTanNum.Text = (Int32.Parse(txtTanNum.Text) - 1).ToString();
        }

        private void btnTanPlu_Click(object sender, EventArgs e)
        {
            txtTanNum.Text = (Int32.Parse(txtTanNum.Text) + 1).ToString();
        }

        private void txtMinMin_Click(object sender, EventArgs e)
        {
            txtMinNum.Text = (Int32.Parse(txtMinNum.Text) - 1).ToString();
        }

        private void btnMinPlu_Click(object sender, EventArgs e)
        {
            txtMinNum.Text = (Int32.Parse(txtMinNum.Text) + 1).ToString();
        }

        private void btnMajMin_Click(object sender, EventArgs e)
        {
            txtMajNum.Text = (Int32.Parse(txtMajNum.Text) - 1).ToString();
        }

        private void btnMajPlu_Click(object sender, EventArgs e)
        {
            txtMajNum.Text = (Int32.Parse(txtMajNum.Text) + 1).ToString();
        }

        private void txtAirMin_Click(object sender, EventArgs e)
        {
            txtAirNum.Text = (Int32.Parse(txtAirNum.Text) - 1).ToString();
        }

        private void btnAirPlu_Click(object sender, EventArgs e)
        {
            txtAirNum.Text = (Int32.Parse(txtAirNum.Text) + 1).ToString();
        }

        private void btnNavMin_Click(object sender, EventArgs e)
        {
            txtNavNum.Text = (Int32.Parse(txtNavNum.Text) - 1).ToString();
        }

        private void btnNavPlu_Click(object sender, EventArgs e)
        {
            txtNavNum.Text = (Int32.Parse(txtNavNum.Text) + 1).ToString();
        }

        private void btnAntMin_Click(object sender, EventArgs e)
        {
            txtAntNum.Text = (Int32.Parse(txtAntNum.Text) - 1).ToString();
        }

        private void btnAntPlu_Click(object sender, EventArgs e)
        {
            txtAntNum.Text = (Int32.Parse(txtAntNum.Text) + 1).ToString();
        }

        private void btnBatMin_Click(object sender, EventArgs e)
        {
            txtBatNum.Text = (Int32.Parse(txtBatNum.Text) - 1).ToString();
        }

        private void btnBatPlu_Click(object sender, EventArgs e)
        {
            txtBatNum.Text = (Int32.Parse(txtBatNum.Text) + 1).ToString();
        }

        private void btnAiCMin_Click(object sender, EventArgs e)
        {
            txtAiCNum.Text = (Int32.Parse(txtAiCNum.Text) - 1).ToString();
        }

        private void btnAiCPlu_Click(object sender, EventArgs e)
        {
            txtAiCNum.Text = (Int32.Parse(txtAiCNum.Text) + 1).ToString();
        }

        private void btnCruMin_Click(object sender, EventArgs e)
        {
            txtCruNum.Text = (Int32.Parse(txtCruNum.Text) - 1).ToString();
        }

        private void btnCruPlu_Click(object sender, EventArgs e)
        {
            txtCruNum.Text = (Int32.Parse(txtCruNum.Text) + 1).ToString();
        }

        private void btnDesMin_Click(object sender, EventArgs e)
        {
            txtDesNum.Text = (Int32.Parse(txtDesNum.Text) - 1).ToString();
        }

        private void btnDesPlu_Click(object sender, EventArgs e)
        {
            txtDesNum.Text = (Int32.Parse(txtDesNum.Text) + 1).ToString();
        }

        private void btnSubMin_Click(object sender, EventArgs e)
        {
            txtSubNum.Text = (Int32.Parse(txtSubNum.Text) - 1).ToString();
        }

        private void btnSubPlu_Click(object sender, EventArgs e)
        {
            txtSubNum.Text = (Int32.Parse(txtSubNum.Text) + 1).ToString();
        }

        private void btnTraMin_Click(object sender, EventArgs e)
        {
            txtTraNum.Text = (Int32.Parse(txtTraNum.Text) - 1).ToString();
        }

        private void btnTraPlu_Click(object sender, EventArgs e)
        {
            txtTraNum.Text = (Int32.Parse(txtTraNum.Text) + 1).ToString();
        }

        private void btnFigMin_Click(object sender, EventArgs e)
        {
            txtFigNum.Text = (Int32.Parse(txtFigNum.Text) - 1).ToString();
        }

        private void btnFigPlu_Click(object sender, EventArgs e)
        {
            txtFigNum.Text = (Int32.Parse(txtFigNum.Text) + 1).ToString();
        }

        private void btnTacMin_Click(object sender, EventArgs e)
        {
            txtTacNum.Text = (Int32.Parse(txtTacNum.Text) - 1).ToString();
        }

        private void btnTacPlu_Click(object sender, EventArgs e)
        {
            txtTacNum.Text = (Int32.Parse(txtTacNum.Text) + 1).ToString();
        }

        private void btnStrMin_Click(object sender, EventArgs e)
        {
            txtStrNum.Text = (Int32.Parse(txtStrNum.Text) - 1).ToString();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void btnStrPlu_Click(object sender, EventArgs e)
        {
            txtStrNum.Text = (Int32.Parse(txtStrNum.Text) + 1).ToString();
        }

        private void frmBuy_Load(object sender, EventArgs e)
        {
            loadSaveInfo();
            txtMoney.Text = mon.ToString();
        }

        private void loadSaveInfo ()
        {
            System.IO.StreamReader readFile2 = new System.IO.StreamReader(gPath);
            sPath = readFile2.ReadLine();
            System.IO.StreamReader readFile = new System.IO.StreamReader(sPath);

            gameMode = readFile.ReadLine();
            turn = readFile.ReadLine();
            if (gameMode == "G")
            {


                ger = readFile.ReadLine();
                sov = readFile.ReadLine();
                jap = readFile.ReadLine();
                us = readFile.ReadLine();
                chin = readFile.ReadLine();
                uke = readFile.ReadLine();
                ukp = readFile.ReadLine();
                it = readFile.ReadLine();
                anz = readFile.ReadLine();
                fra = readFile.ReadLine();
                gerInc = Int32.Parse(ger.Substring(0, ger.IndexOf(' ') + 1));
                ger.Remove(0, ger.IndexOf(' ') + 1);
                gerTot = Int32.Parse(ger.Substring(0, ger.IndexOf(' ') + 1));
                ger.Remove(0, ger.IndexOf(' ') + 1);
                sovInc = Int32.Parse(sov.Substring(0, sov.IndexOf(' ') + 1));
                sov.Remove(0, sov.IndexOf(' ') + 1);
                sovTot = Int32.Parse(sov.Substring(0, sov.IndexOf(' ') + 1));
                sov.Remove(0, sov.IndexOf(' ') + 1);
                japInc = Int32.Parse(jap.Substring(0, jap.IndexOf(' ') + 1));
                jap.Remove(0, jap.IndexOf(' ') + 1);
                japTot = Int32.Parse(jap.Substring(0, jap.IndexOf(' ') + 1));
                jap.Remove(0, jap.IndexOf(' ') + 1);
                usInc = Int32.Parse(us.Substring(0, us.IndexOf(' ') + 1));
                us.Remove(0, us.IndexOf(' ') + 1);
                usTot = Int32.Parse(us.Substring(0, us.IndexOf(' ') + 1));
                us.Remove(0, us.IndexOf(' ') + 1);
                chinInc = Int32.Parse(chin.Substring(0, chin.IndexOf(' ') + 1));
                chin.Remove(0, chin.IndexOf(' ') + 1);
                chinTot = Int32.Parse(chin.Substring(0, chin.IndexOf(' ') + 1));
                chin.Remove(0, chin.IndexOf(' ') + 1);
                ukeInc = Int32.Parse(uke.Substring(0, uke.IndexOf(' ') + 1));
                uke.Remove(0, uke.IndexOf(' ') + 1);
                ukeTot = Int32.Parse(uke.Substring(0, uke.IndexOf(' ') + 1));
                uke.Remove(0, uke.IndexOf(' ') + 1);
                ukpInc = Int32.Parse(ukp.Substring(0, ukp.IndexOf(' ') + 1));
                ukp.Remove(0, ukp.IndexOf(' ') + 1);
                ukpTot = Int32.Parse(ukp.Substring(0, ukp.IndexOf(' ') + 1));
                ukp.Remove(0, ukp.IndexOf(' ') + 1);
                itInc = Int32.Parse(it.Substring(0, it.IndexOf(' ') + 1));
                it.Remove(0, it.IndexOf(' ') + 1);
                itTot = Int32.Parse(it.Substring(0, it.IndexOf(' ') + 1));
                it.Remove(0, it.IndexOf(' ') + 1);
                anzInc = Int32.Parse(anz.Substring(0, anz.IndexOf(' ') + 1));
                anz.Remove(0, anz.IndexOf(' ') + 1);
                anzTot = Int32.Parse(anz.Substring(0, anz.IndexOf(' ') + 1));
                anz.Remove(0, anz.IndexOf(' ') + 1);
                fraInc = Int32.Parse(fra.Substring(0, fra.IndexOf(' ') + 1));
                fra.Remove(0, fra.IndexOf(' ') + 1);
                fraTot = Int32.Parse(fra.Substring(0, fra.IndexOf(' ') + 1));
                fra.Remove(0, fra.IndexOf(' ') + 1);
                readFile.Close();
                readFile2.Close();

            }

            switch (turn)
            {
                case "Ger":
                    mon = gerTot;
                    break;
                case "Sov":
                    mon = sovTot;
                    break;
                case "Jap":
                    mon = japTot;
                    break;
                case "US":
                    mon = usTot;
                    break;
                case "Chi":
                    mon = chinTot;
                    break;
                case "UKE":
                    mon = ukeTot;
                    break;
                case "UKP":
                    mon = ukpTot;
                    break;
                case "It":
                    mon = itTot;
                    break;
                case "Anz":
                    mon = anzTot;
                    break;
                case "Fra":
                    mon = fraTot;
                    break;               
            }

        }

    }
}
