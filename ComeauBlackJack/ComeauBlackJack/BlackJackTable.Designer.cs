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
            this.hitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MiscImagery = new System.Windows.Forms.ImageList(this.components);
            this.DealerPicture = new System.Windows.Forms.PictureBox();
            this.PlayerPicture = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DealerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.dealToolStripMenuItem,
            this.hitToolStripMenuItem,
            this.standToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // dealToolStripMenuItem
            // 
            this.dealToolStripMenuItem.Name = "dealToolStripMenuItem";
            this.dealToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.dealToolStripMenuItem.Text = "&Deal";
            this.dealToolStripMenuItem.Click += new System.EventHandler(this.DealHand_Click);
            // 
            // hitToolStripMenuItem
            // 
            this.hitToolStripMenuItem.Enabled = false;
            this.hitToolStripMenuItem.Name = "hitToolStripMenuItem";
            this.hitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.hitToolStripMenuItem.Text = "&Hit";
            this.hitToolStripMenuItem.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // standToolStripMenuItem
            // 
            this.standToolStripMenuItem.Enabled = false;
            this.standToolStripMenuItem.Name = "standToolStripMenuItem";
            this.standToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.standToolStripMenuItem.Text = "&Stand";
            this.standToolStripMenuItem.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // btnLoadPlayer
            // 
            this.btnLoadPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPlayer.Location = new System.Drawing.Point(564, 82);
            this.btnLoadPlayer.Name = "btnLoadPlayer";
            this.btnLoadPlayer.Size = new System.Drawing.Size(133, 27);
            this.btnLoadPlayer.TabIndex = 2;
            this.btnLoadPlayer.Text = "Change Player";
            this.btnLoadPlayer.UseVisualStyleBackColor = true;
            this.btnLoadPlayer.Click += new System.EventHandler(this.ChangePlayer_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayerName.Location = new System.Drawing.Point(564, 34);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(94, 19);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Playing as:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblScore.Location = new System.Drawing.Point(564, 60);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(60, 19);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // panelPlayer
            // 
            this.panelPlayer.Location = new System.Drawing.Point(102, 243);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(451, 145);
            this.panelPlayer.TabIndex = 5;
            // 
            // panelDealer
            // 
            this.panelDealer.Location = new System.Drawing.Point(101, 63);
            this.panelDealer.Name = "panelDealer";
            this.panelDealer.Size = new System.Drawing.Size(451, 145);
            this.panelDealer.TabIndex = 6;
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.ForeColor = System.Drawing.Color.Red;
            this.btnDeal.Location = new System.Drawing.Point(564, 259);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(95, 26);
            this.btnDeal.TabIndex = 3;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.DealHand_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.ForeColor = System.Drawing.Color.Yellow;
            this.lblDealer.Location = new System.Drawing.Point(98, 37);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(64, 19);
            this.lblDealer.TabIndex = 8;
            this.lblDealer.Text = "Dealer:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayer.Location = new System.Drawing.Point(98, 218);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(67, 19);
            this.lblPlayer.TabIndex = 9;
            this.lblPlayer.Text = "(Player)";
            // 
            // lblDealerHandValue
            // 
            this.lblDealerHandValue.AutoSize = true;
            this.lblDealerHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerHandValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblDealerHandValue.Location = new System.Drawing.Point(166, 36);
            this.lblDealerHandValue.Name = "lblDealerHandValue";
            this.lblDealerHandValue.Size = new System.Drawing.Size(21, 20);
            this.lblDealerHandValue.TabIndex = 10;
            this.lblDealerHandValue.Tag = "test";
            this.lblDealerHandValue.Text = "--";
            // 
            // lblPlayerHandValue
            // 
            this.lblPlayerHandValue.AutoSize = true;
            this.lblPlayerHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHandValue.ForeColor = System.Drawing.Color.Yellow;
            this.lblPlayerHandValue.Location = new System.Drawing.Point(166, 218);
            this.lblPlayerHandValue.Name = "lblPlayerHandValue";
            this.lblPlayerHandValue.Size = new System.Drawing.Size(21, 20);
            this.lblPlayerHandValue.TabIndex = 11;
            this.lblPlayerHandValue.Text = "--";
            // 
            // btnHit
            // 
            this.btnHit.Enabled = false;
            this.btnHit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(564, 305);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(95, 26);
            this.btnHit.TabIndex = 4;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // btnStand
            // 
            this.btnStand.Enabled = false;
            this.btnStand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(564, 346);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(95, 26);
            this.btnStand.TabIndex = 5;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // txtBet
            // 
            this.txtBet.BackColor = System.Drawing.Color.PaleGreen;
            this.txtBet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBet.Location = new System.Drawing.Point(473, 33);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(79, 26);
            this.txtBet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(409, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bet:  $";
            // 
            // MiscImagery
            // 
            this.MiscImagery.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MiscImagery.ImageStream")));
            this.MiscImagery.TransparentColor = System.Drawing.Color.Transparent;
            this.MiscImagery.Images.SetKeyName(0, "BlackJack.jpg");
            this.MiscImagery.Images.SetKeyName(1, "Bust.jpg");
            // 
            // DealerPicture
            // 
            this.DealerPicture.Location = new System.Drawing.Point(11, 63);
            this.DealerPicture.Name = "DealerPicture";
            this.DealerPicture.Size = new System.Drawing.Size(85, 85);
            this.DealerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DealerPicture.TabIndex = 16;
            this.DealerPicture.TabStop = false;
            // 
            // PlayerPicture
            // 
            this.PlayerPicture.Location = new System.Drawing.Point(11, 243);
            this.PlayerPicture.Name = "PlayerPicture";
            this.PlayerPicture.Size = new System.Drawing.Size(85, 85);
            this.PlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayerPicture.TabIndex = 17;
            this.PlayerPicture.TabStop = false;
            // 
            // BlackJackTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(762, 411);
            this.Controls.Add(this.PlayerPicture);
            this.Controls.Add(this.DealerPicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBet);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
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
            ((System.ComponentModel.ISupportInitialize)(this.DealerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem hitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standToolStripMenuItem;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList MiscImagery;
        private System.Windows.Forms.PictureBox DealerPicture;
        private System.Windows.Forms.PictureBox PlayerPicture;
    }
}

