namespace AxisAndAlliesCalculator
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEurope = new System.Windows.Forms.Button();
            this.btnPasific = new System.Windows.Forms.Button();
            this.btnGloabal = new System.Windows.Forms.Button();
            this.btnTut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLaod = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.cbGame = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Axis and Allies";
            // 
            // btnEurope
            // 
            this.btnEurope.Location = new System.Drawing.Point(51, 37);
            this.btnEurope.Name = "btnEurope";
            this.btnEurope.Size = new System.Drawing.Size(108, 23);
            this.btnEurope.TabIndex = 1;
            this.btnEurope.Text = "European Theater";
            this.btnEurope.UseVisualStyleBackColor = true;
            this.btnEurope.Visible = false;
            this.btnEurope.Click += new System.EventHandler(this.btnEurope_Click);
            // 
            // btnPasific
            // 
            this.btnPasific.Location = new System.Drawing.Point(51, 66);
            this.btnPasific.Name = "btnPasific";
            this.btnPasific.Size = new System.Drawing.Size(108, 23);
            this.btnPasific.TabIndex = 2;
            this.btnPasific.Text = "Pacific Theater";
            this.btnPasific.UseVisualStyleBackColor = true;
            this.btnPasific.Visible = false;
            this.btnPasific.Click += new System.EventHandler(this.btnPasific_Click);
            // 
            // btnGloabal
            // 
            this.btnGloabal.Location = new System.Drawing.Point(51, 95);
            this.btnGloabal.Name = "btnGloabal";
            this.btnGloabal.Size = new System.Drawing.Size(108, 23);
            this.btnGloabal.TabIndex = 3;
            this.btnGloabal.Text = "Gloabal";
            this.btnGloabal.UseVisualStyleBackColor = true;
            this.btnGloabal.Visible = false;
            this.btnGloabal.Click += new System.EventHandler(this.btnGloabal_Click);
            // 
            // btnTut
            // 
            this.btnTut.Location = new System.Drawing.Point(51, 124);
            this.btnTut.Name = "btnTut";
            this.btnTut.Size = new System.Drawing.Size(108, 23);
            this.btnTut.TabIndex = 4;
            this.btnTut.Text = "Tutorial";
            this.btnTut.UseVisualStyleBackColor = true;
            this.btnTut.Click += new System.EventHandler(this.btnTut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(51, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLaod
            // 
            this.btnLaod.Location = new System.Drawing.Point(51, 66);
            this.btnLaod.Name = "btnLaod";
            this.btnLaod.Size = new System.Drawing.Size(108, 23);
            this.btnLaod.TabIndex = 7;
            this.btnLaod.Text = "Load Game";
            this.btnLaod.UseVisualStyleBackColor = true;
            this.btnLaod.Click += new System.EventHandler(this.btnLaod_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(51, 37);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(108, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbGame
            // 
            this.cbGame.FormattingEnabled = true;
            this.cbGame.Items.AddRange(new object[] {
            "Game 1",
            "Game 2",
            "Game 3",
            "Game 4",
            "Game 5"});
            this.cbGame.Location = new System.Drawing.Point(51, 97);
            this.cbGame.Name = "cbGame";
            this.cbGame.Size = new System.Drawing.Size(108, 21);
            this.cbGame.TabIndex = 8;
            this.cbGame.SelectedIndexChanged += new System.EventHandler(this.cbGame_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 180);
            this.Controls.Add(this.cbGame);
            this.Controls.Add(this.btnLaod);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTut);
            this.Controls.Add(this.btnGloabal);
            this.Controls.Add(this.btnPasific);
            this.Controls.Add(this.btnEurope);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEurope;
        private System.Windows.Forms.Button btnPasific;
        private System.Windows.Forms.Button btnGloabal;
        private System.Windows.Forms.Button btnTut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLaod;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbGame;
    }
}

