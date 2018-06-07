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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadPlayer = new System.Windows.Forms.Button();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.panelDealer = new System.Windows.Forms.Panel();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblDealerHandValue = new System.Windows.Forms.Label();
            this.lblPlayerHandValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            this.SourceDeck.Images.SetKeyName(44, "Ace_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(45, "Ace_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(46, "Ace_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(47, "Ace_Spades.bmp");
            this.SourceDeck.Images.SetKeyName(48, "Backface_Blue.bmp");
            this.SourceDeck.Images.SetKeyName(49, "Backface_Red.bmp");
            this.SourceDeck.Images.SetKeyName(50, "Joker_Black.bmp");
            this.SourceDeck.Images.SetKeyName(51, "Joker_Red.bmp");
            this.SourceDeck.Images.SetKeyName(52, "King_Clubs.bmp");
            this.SourceDeck.Images.SetKeyName(53, "King_Diamonds.bmp");
            this.SourceDeck.Images.SetKeyName(54, "King_Hearts.bmp");
            this.SourceDeck.Images.SetKeyName(55, "King_Spades.bmp");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePlayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // changePlayerToolStripMenuItem
            // 
            this.changePlayerToolStripMenuItem.Name = "changePlayerToolStripMenuItem";
            this.changePlayerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.changePlayerToolStripMenuItem.Text = "Change &Player";
            this.changePlayerToolStripMenuItem.Click += new System.EventHandler(this.ChangePlayer_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dealToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // dealToolStripMenuItem
            // 
            this.dealToolStripMenuItem.Name = "dealToolStripMenuItem";
            this.dealToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.dealToolStripMenuItem.Text = "&Deal";
            this.dealToolStripMenuItem.Click += new System.EventHandler(this.DealHand_Click);
            // 
            // btnLoadPlayer
            // 
            this.btnLoadPlayer.Location = new System.Drawing.Point(532, 233);
            this.btnLoadPlayer.Name = "btnLoadPlayer";
            this.btnLoadPlayer.Size = new System.Drawing.Size(95, 23);
            this.btnLoadPlayer.TabIndex = 2;
            this.btnLoadPlayer.Text = "Change Player";
            this.btnLoadPlayer.UseVisualStyleBackColor = true;
            this.btnLoadPlayer.Click += new System.EventHandler(this.ChangePlayer_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(537, 33);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(77, 17);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Playing as:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(537, 59);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(49, 17);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // panelPlayer
            // 
            this.panelPlayer.Location = new System.Drawing.Point(75, 233);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(451, 145);
            this.panelPlayer.TabIndex = 5;
            // 
            // panelDealer
            // 
            this.panelDealer.Location = new System.Drawing.Point(74, 62);
            this.panelDealer.Name = "panelDealer";
            this.panelDealer.Size = new System.Drawing.Size(451, 145);
            this.panelDealer.TabIndex = 6;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(208, 33);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 7;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.DealHand_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(71, 39);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(56, 20);
            this.lblDealer.TabIndex = 8;
            this.lblDealer.Text = "Dealer";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(71, 210);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(62, 20);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "(Player)";
            // 
            // lblDealerHandValue
            // 
            this.lblDealerHandValue.AutoSize = true;
            this.lblDealerHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerHandValue.Location = new System.Drawing.Point(531, 183);
            this.lblDealerHandValue.Name = "lblDealerHandValue";
            this.lblDealerHandValue.Size = new System.Drawing.Size(0, 24);
            this.lblDealerHandValue.TabIndex = 10;
            // 
            // lblPlayerHandValue
            // 
            this.lblPlayerHandValue.AutoSize = true;
            this.lblPlayerHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHandValue.Location = new System.Drawing.Point(532, 354);
            this.lblPlayerHandValue.Name = "lblPlayerHandValue";
            this.lblPlayerHandValue.Size = new System.Drawing.Size(0, 24);
            this.lblPlayerHandValue.TabIndex = 11;
            // 
            // BlackJackTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 411);
            this.Controls.Add(this.lblPlayerHandValue);
            this.Controls.Add(this.lblDealerHandValue);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.panelDealer);
            this.Controls.Add(this.panelPlayer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnLoadPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJackTable";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.BlackJackTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList SourceDeck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnLoadPlayer;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dealToolStripMenuItem;
        private System.Windows.Forms.Panel panelPlayer;
        private System.Windows.Forms.Panel panelDealer;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblDealerHandValue;
        private System.Windows.Forms.Label lblPlayerHandValue;
    }
}

