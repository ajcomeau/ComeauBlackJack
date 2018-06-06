namespace ComeauBlackJack
{
    partial class BlackJackTable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackTable));
            this.SourceDeck = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lstHand = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCardsLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceDeck
            // 
            this.SourceDeck.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SourceDeck.ImageStream")));
            this.SourceDeck.TransparentColor = System.Drawing.Color.Transparent;
            this.SourceDeck.Images.SetKeyName(0, "2_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(2, "2_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(3, "2_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(4, "3_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(6, "3_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(7, "3_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(8, "4_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(10, "4_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(11, "4_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(12, "5_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(14, "5_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(15, "5_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(16, "6_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(18, "6_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(19, "6_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(20, "7_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(22, "7_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(23, "7_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(24, "8_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(26, "8_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(27, "8_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(28, "9_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(30, "9_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(31, "9_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(32, "10_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(34, "10_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(35, "10_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(36, "Jack_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(37, "Jack_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(38, "Jack_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(39, "Jack_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(40, "Queen_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(41, "Queen_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(42, "Queen_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(43, "Queen_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(44, "King_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(45, "King_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(46, "King_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(47, "King_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(48, "Ace_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(49, "Ace_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(50, "Ace_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(51, "Ace_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(52, "Backface_Blue.bmp");
            this.SourceDeck.Images.SetKeyName(53, "Backface_Red.bmp");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lstHand
            // 
            this.lstHand.FormattingEnabled = true;
            this.lstHand.Location = new System.Drawing.Point(12, 27);
            this.lstHand.Name = "lstHand";
            this.lstHand.Size = new System.Drawing.Size(120, 303);
            this.lstHand.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblCardsLeft
            // 
            this.lblCardsLeft.AutoSize = true;
            this.lblCardsLeft.Location = new System.Drawing.Point(142, 316);
            this.lblCardsLeft.Name = "lblCardsLeft";
            this.lblCardsLeft.Size = new System.Drawing.Size(0, 13);
            this.lblCardsLeft.TabIndex = 4;
            // 
            // BlackJackTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 395);
            this.Controls.Add(this.lblCardsLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJackTable";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJackTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList SourceDeck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lstHand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCardsLeft;
    }
}

