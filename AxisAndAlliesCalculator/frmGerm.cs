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
    public partial class frmGerm : Form
    {
        public frmGerm()
        {
            InitializeComponent();
            Load += new EventHandler(frmGerm_Load);
        }
        //Forms to Switch to
        frmMain main = new frmMain();
        frmSov sovFrm = new frmSov();
        frmBuy Buy = new frmBuy();
        //Save File
        public int gameNum = 0;
        //Game info
        public string gameMode, turn = "Ger", sPath = "Game1", gPath = "currentGame", bPath = "money";
        //Display ammounts
        int gerInc, gerTot, gerChange, sovInc, sovTot, sovChange, japInc, japTot, japChange, usInc, usTot, usChange, chinInc, chinTot, chinChange, ukeInc, ukeTot, ukeChange, ukpInc, ukpTot, ukpChange, itInc, itTot, itChange, anzInc, anzTot, anzChange, fraInc, fraTot, fraChange;
        //Save+Exit Button
        private void button3_Click(object sender, EventArgs e)
        {
            string message = "If you have finished this turn, hit cancle then end turn before saving, if not hit OK.", caption = "Save";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Cancel)
                return;

            if (gameMode == "G")
                saveGlobal();
            else if (gameMode == "E")
                saveEurope();
        }

        //Buy Screen
        private void btnBuy_Click(object sender, EventArgs e)
        {
            Buy.Show();
            this.Hide();
        }
        //Load information
        string ger, sov, jap, us, chin, uke, ukp, it, anz, fra;
        //Germany Bonuses
        Boolean gerSovWar, axisCauc, gerEgypt, gerDenNor;
        int gerSovCon, GerMiddle;
        //End Turn button
        private void btnTrn_Click(object sender, EventArgs e)
        {
            //Update Money Totals
            gerChange = Int32.Parse(txtGerChange.Text);
            gerInc = Int32.Parse(txtGermInc.Text) + gerChange;
            gerTot = Int32.Parse(txtGerTot.Text) + gerInc;
            sovChange = Int32.Parse(txtSovChange.Text);
            sovInc = Int32.Parse(txtSovInc.Text) + sovChange;
            japChange = Int32.Parse(txtJapChange.Text);
            japInc = Int32.Parse(txtJapInc.Text) + japChange;
            usChange = Int32.Parse(txtUSChange.Text);
            usInc = Int32.Parse(txtUSInc.Text) + usChange;
            chinChange = Int32.Parse(txtChinChange.Text);
            chinInc = Int32.Parse(txtChinInc.Text) + chinChange;
            ukeChange = Int32.Parse(txtUKEChange.Text);
            ukeInc = Int32.Parse(txtUKEInc.Text) + ukeChange;
            ukpChange = Int32.Parse(txtUKPChange.Text);

            ukpInc = Int32.Parse(txtUKPInc.Text) + ukpChange;
            itChange = Int32.Parse(txtItChange.Text);
            itInc = Int32.Parse(txtItInc.Text) + itChange;
            anzChange = Int32.Parse(txtAnzChange.Text);
            anzInc = Int32.Parse(txtAnzInc.Text) + anzChange;
            fraChange = Int32.Parse(txtFraChange.Text);
            fraInc = Int32.Parse(txtFraInc.Text) + fraChange;

            txtGerTot.Text = gerTot.ToString();
            txtGermInc.Text = gerInc.ToString();
            txtSovInc.Text = sovInc.ToString();
            txtJapInc.Text = japInc.ToString();
            txtUSInc.Text = usInc.ToString();
            txtChinInc.Text = chinInc.ToString();
            txtUKEInc.Text = ukeInc.ToString();
            txtUKPInc.Text = ukpInc.ToString();
            txtItInc.Text = itInc.ToString();
            txtAnzInc.Text = anzInc.ToString();
            txtFraInc.Text = fraInc.ToString();
            //Change Turn
            turn = "Sov";
            //Save file
            switch (gameMode)
            {
                case "G":
                    saveGlobal();
                    break;
                case "E":
                    saveEurope();
                    break;
            }
            //Switch form
            this.Close();
            sovFrm.Show();
        }
        //Intital Load
        private void frmGerm_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader readFile2 = new System.IO.StreamReader(gPath);
            sPath = readFile2.ReadLine();
            System.IO.StreamReader readFile = new System.IO.StreamReader(sPath);
            gameMode = readFile.ReadLine();
            if (gameMode.Equals("G"))
                globalLoad();
            else if (gameMode.Equals("E"))
                europeLoad();

            readFile.Close();
            readFile2.Close();

        }
        //Loading
        private void globalLoad()
        {
            System.IO.StreamReader readFile = new System.IO.StreamReader(sPath);
            ger = readFile.ReadLine(); //GameMode
            ger = readFile.ReadLine(); //CountryTurn
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
            ger = ger.Remove(0, ger.IndexOf(' ') + 1);
            gerTot = Int32.Parse(ger.Substring(0, ger.IndexOf(' ') + 1));
            ger = ger.Remove(0, ger.IndexOf(' ') + 1);
            sovInc = Int32.Parse(sov.Substring(0, sov.IndexOf(' ') + 1));
            sov = sov.Remove(0, sov.IndexOf(' ') + 1);
            sovTot = Int32.Parse(sov.Substring(0, sov.IndexOf(' ') + 1));
            sov = sov.Remove(0, sov.IndexOf(' ') + 1);
            japInc = Int32.Parse(jap.Substring(0, jap.IndexOf(' ') + 1));
            jap = jap.Remove(0, jap.IndexOf(' ') + 1);
            japTot = Int32.Parse(jap.Substring(0, jap.IndexOf(' ') + 1));
            jap = jap.Remove(0, jap.IndexOf(' ') + 1);
            usInc = Int32.Parse(us.Substring(0, us.IndexOf(' ') + 1));
            us = us.Remove(0, us.IndexOf(' ') + 1);
            usTot = Int32.Parse(us.Substring(0, us.IndexOf(' ') + 1));
            us = us.Remove(0, us.IndexOf(' ') + 1);
            chinInc = Int32.Parse(chin.Substring(0, chin.IndexOf(' ') + 1));
            chin = chin.Remove(0, chin.IndexOf(' ') + 1);
            chinTot = Int32.Parse(chin.Substring(0, chin.IndexOf(' ') + 1));
            chin = chin.Remove(0, chin.IndexOf(' ') + 1);
            ukeInc = Int32.Parse(uke.Substring(0, uke.IndexOf(' ') + 1));
            uke = uke.Remove(0, uke.IndexOf(' ') + 1);
            ukeTot = Int32.Parse(uke.Substring(0, uke.IndexOf(' ') + 1));
            uke = uke.Remove(0, uke.IndexOf(' ') + 1);
            ukpInc = Int32.Parse(ukp.Substring(0, ukp.IndexOf(' ') + 1));
            ukp = ukp.Remove(0, ukp.IndexOf(' ') + 1);
            ukpTot = Int32.Parse(ukp.Substring(0, ukp.IndexOf(' ') + 1));
            ukp = ukp.Remove(0, ukp.IndexOf(' ') + 1);
            itInc = Int32.Parse(it.Substring(0, it.IndexOf(' ') + 1));
            it = it.Remove(0, it.IndexOf(' ') + 1);
            itTot = Int32.Parse(it.Substring(0, it.IndexOf(' ') + 1));
            it = it.Remove(0, it.IndexOf(' ') + 1);
            anzInc = Int32.Parse(anz.Substring(0, anz.IndexOf(' ') + 1));
            anz = anz.Remove(0, anz.IndexOf(' ') + 1);
            anzTot = Int32.Parse(anz.Substring(0, anz.IndexOf(' ') + 1));
            anz = anz.Remove(0, anz.IndexOf(' ') + 1);
            fraInc = Int32.Parse(fra.Substring(0, fra.IndexOf(' ') + 1));
            fra = fra.Remove(0, fra.IndexOf(' ') + 1);
            fraTot = Int32.Parse(fra);

            txtGermInc.Text = gerInc.ToString();
            txtGerTot.Text = gerTot.ToString();
            txtSovInc.Text = sovInc.ToString();
            txtSovTot.Text = sovTot.ToString();
            txtJapInc.Text = japInc.ToString();
            txtJapTot.Text = japTot.ToString();
            txtUSInc.Text = usInc.ToString();
            txtUSTot.Text = usTot.ToString();
            txtChinInc.Text = chinInc.ToString();
            txtChinTot.Text = chinTot.ToString();
            txtUKEInc.Text = ukeInc.ToString();
            txtUKETot.Text = ukeTot.ToString();
            txtUKPInc.Text = ukpInc.ToString();
            txtUKPTot.Text = ukpTot.ToString();
            txtItInc.Text = itInc.ToString();
            txtItTot.Text = itTot.ToString();
            txtAnzInc.Text = anzInc.ToString();
            txtAnzTot.Text = anzTot.ToString();
            txtFraInc.Text = fraInc.ToString();
            txtFraTot.Text = fraTot.ToString();

            readFile.Close();
        }
        private void europeLoad()
        {
            System.IO.StreamReader readFile = new System.IO.StreamReader(sPath);
            gameMode = readFile.ReadLine();
            turn = readFile.ReadLine();
            ger = readFile.ReadLine();
            sov = readFile.ReadLine();
            us = readFile.ReadLine();
            uke = readFile.ReadLine();
            it = readFile.ReadLine();
            fra = readFile.ReadLine();
            gerInc = Int32.Parse(ger.Substring(0, ger.IndexOf(' ') + 1));
            ger = ger.Remove(0, ger.IndexOf(' ') + 1);
            gerTot = Int32.Parse(ger.Substring(0, ger.IndexOf(' ') + 1));
            ger = ger.Remove(0, ger.IndexOf(' ') + 1);
            sovInc = Int32.Parse(sov.Substring(0, sov.IndexOf(' ') + 1));
            sov = sov.Remove(0, sov.IndexOf(' ') + 1);
            sovTot = Int32.Parse(sov.Substring(0, sov.IndexOf(' ') + 1));
            sov = sov.Remove(0, sov.IndexOf(' ') + 1);
            usInc = Int32.Parse(us.Substring(0, us.IndexOf(' ') + 1));
             us = us.Remove(0, us.IndexOf(' ') + 1);
            usTot = Int32.Parse(us.Substring(0, us.IndexOf(' ') + 1));
            us = us.Remove(0, us.IndexOf(' ') + 1);
            ukeInc = Int32.Parse(uke.Substring(0, uke.IndexOf(' ') + 1));
            uke = uke.Remove(0, uke.IndexOf(' ') + 1);
            ukeTot = Int32.Parse(uke.Substring(0, uke.IndexOf(' ') + 1));
            uke = uke.Remove(0, uke.IndexOf(' ') + 1);
            itInc = Int32.Parse(it.Substring(0, it.IndexOf(' ') + 1));
            it = it.Remove(0, it.IndexOf(' ') + 1);
            itTot = Int32.Parse(it.Substring(0, it.IndexOf(' ') + 1));
            it = it.Remove(0, it.IndexOf(' ') + 1);
            fraInc = Int32.Parse(fra.Substring(0, fra.IndexOf(' ') + 1));
            fra.Remove(0, fra.IndexOf(' ') + 1);
            fraTot = Int32.Parse(fra.Substring(0, fra.IndexOf(' ') + 1));

            txtGermInc.Text = gerInc.ToString();
            txtGerTot.Text = gerTot.ToString();
            txtSovInc.Text = sovInc.ToString();
            txtSovTot.Text = sovTot.ToString();
            txtUSInc.Text = usInc.ToString();
            txtUSTot.Text = usTot.ToString();
            txtUKEInc.Text = ukeInc.ToString();
            txtUKETot.Text = ukeTot.ToString();
            txtItInc.Text = itInc.ToString();
            txtItTot.Text = itTot.ToString();
            txtFraInc.Text = fraInc.ToString();
            txtFraTot.Text = fraTot.ToString();
        }
        //Saving
        private void saveGlobal()
        {
            System.IO.StreamReader readFile2 = new System.IO.StreamReader(gPath);
            StreamWriter SaveFile = new StreamWriter(sPath);
            sPath = readFile2.ReadLine();

            SaveFile.WriteLine(gameMode);
            SaveFile.WriteLine(turn);
            SaveFile.WriteLine(gerInc + " " + gerTot + " " + ger);//.Substring(6));
            SaveFile.WriteLine(sovInc + " " + sovTot + " " + sov);//.Substring(6));
            SaveFile.WriteLine(japInc + " " + japTot + " " + jap);//.Substring(6));
            SaveFile.WriteLine(usInc + " " + usTot + " " + us);//.Substring(6));
            SaveFile.WriteLine(chinInc + " " + chinTot + " " + chin); //.Substring(6));
            SaveFile.WriteLine(ukeInc + " " + ukeTot + " " + uke);//.Substring(6));
            SaveFile.WriteLine(ukpInc + " " + ukpTot + " " + ukp);//.Substring(6));
            SaveFile.WriteLine(itInc + " " + itTot + " " + it);//.Substring(6));
            SaveFile.WriteLine(anzInc + " " + anzTot + " " + anz);//.Substring(6));
            SaveFile.WriteLine(fraInc + " " + fraTot);

            SaveFile.Close();
            readFile2.Close();
        }

        private void saveEurope()
        {

        }
    }
}
