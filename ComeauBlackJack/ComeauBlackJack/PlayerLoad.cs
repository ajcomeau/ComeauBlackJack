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

namespace ComeauBlackJack
{
    public partial class PlayerLoad : Form
    {
        struct GameRecord
        {
            public string PlayerName;
            public double PlayerScore;
            public string DatePlayed;
        }

        public bool GetPreviousScore;
        public double PlayerScore;
        public string LoadedPlayerName = "Guest";

        List<GameRecord> Scores = new List<GameRecord>();

        public PlayerLoad()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Get the score if requested.

            if(cboPlayer.SelectedItem != null && chkGetScore.Checked)
            {
                foreach (GameRecord gr in Scores)
                {
                    if(gr.PlayerName == cboPlayer.SelectedItem.ToString())
                        PlayerScore = gr.PlayerScore;
                }
            }
            else
            {
                PlayerScore = 1000;
            }

            // Close form
            this.Close();
        }

        private void PlayerLoad_Load(object sender, EventArgs e)
        {
            string[] scoreRecord;
            GameRecord recLine;

            using(StreamReader srScores = new StreamReader("Scores.csv"))
            {
                while (!srScores.EndOfStream)
                {
                    scoreRecord = srScores.ReadLine().Split(',');
                    recLine = new GameRecord();
                    recLine.PlayerName = scoreRecord[0].ToString();
                    recLine.PlayerScore = double.Parse(scoreRecord[1]);
                    recLine.DatePlayed = scoreRecord[2].ToString();
                    Scores.Add(recLine);
                }
            }

            foreach (GameRecord sr in Scores)
            {
                if (!cboPlayer.Items.Contains(sr.PlayerName))
                {
                    cboPlayer.Items.Add(sr.PlayerName);
                }
            }

        }

        private void chkGetScore_CheckedChanged(object sender, EventArgs e)
        {
            GetPreviousScore = chkGetScore.Checked;
        }

        private void cboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadedPlayerName = cboPlayer.SelectedItem.ToString();
        }
    }
}
