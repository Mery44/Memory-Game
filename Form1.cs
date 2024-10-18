using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private PictureBox[,] CardsBoard;
        public Form1()
        {
            InitializeComponent();

            CardsBoard = new PictureBox[,]
            {
                { pb00, pb01, pb02, pb03 },
                { pb10, pb11, pb12, pb13 },
                { pb20, pb21, pb22, pb23 }
            };
            StartNewGame();
        }

        struct stGameStatus
        {
            public byte FlipCount;
            public byte Trials;
            public byte Score;
            public PictureBox FirstCard;   
            public PictureBox SecondCard;
            public double SpeedMultiplier;
        }
        public struct stTimer
        {
            public byte Seconds;
            public byte Minutes;
        }

        stGameStatus GameStatus;
        stTimer Timer;

        private enum enGameResult { InProgress, Won, Lost }
        private enGameResult GameResult;

        private int Counter;

        private enum enPlayCards { Pen ,Book ,Girl  ,Boy  ,Guitar, Basketball};

        private void StartNewGame()
        {
            Counter = 0;

            GameStatus.FlipCount = 0;
            GameStatus.Trials = 3;
            GameStatus.Score = 0;
            GameResult = enGameResult.InProgress;
            lblScore.Text =  GameStatus.Score + " / 6";
            pbScore.Value = 0;
            cmbSpeed.Text = "1.0x";
            nudTimer.Value = 1;
            lblSeconds.Text = "00";
            lblMinutes.Text = "00";
            lblTrials.Text = GameStatus.Trials.ToString();

            nudTimer.Enabled = true;
            cmbSpeed.Enabled = true;
            btnStart.Enabled = true;
            InitialPictureBoxes();
        }

        private void SetTimer()
        {
            // Calculate minutes and seconds
            Timer.Minutes = (byte)(Counter / 60);  // Integer division for minutes
            Timer.Seconds = (byte)(Counter % 60);  // Remainder for seconds

            // Update the labels for minutes and seconds
            lblMinutes.Text = Timer.Minutes.ToString("00");  // Format to always show two digits
            lblSeconds.Text = Timer.Seconds.ToString("00");

            // Check if the time has run out
            if (Counter <= 0)
            {
                timer1.Enabled = false;
                GameResult = enGameResult.Lost;
                ShowEndGameScreen();
            }
        }

        private void InitialPictureBoxes()
        {
            pb00.Tag = "Girl";
            pb01.Tag = "Guitar";
            pb02.Tag = "Pen";
            pb03.Tag = "Book";
            pb10.Tag = "Pen";
            pb11.Tag = "Book";
            pb12.Tag = "Boy";
            pb13.Tag = "Girl";
            pb20.Tag = "Boy";
            pb21.Tag = "Basketball";
            pb22.Tag = "Guitar";
            pb23.Tag = "Basketball";

            foreach(PictureBox pb in CardsBoard)
            {
                pb.Image = Resources.imgMemoryGameCardBG;
                pb.Enabled = false;
            }
        }

        private bool CheckMatch()
        {
            return (GameStatus.FirstCard.Tag.ToString() == GameStatus.SecondCard.Tag.ToString());
        }

        private void ShowEndGameScreen()
        {
            if(GameResult == enGameResult.Won)
                 MessageBox.Show("You won at" + lblMinutes.Text + ":" + lblSeconds.Text, "Result");
            else
                MessageBox.Show("You Lost!", "Result");

        }

        private void UpdateScore()
        {

            lblScore.Text = GameStatus.Score + " / 6";
            pbScore.Value = GameStatus.Score;

            if (GameStatus.Score == 6)
            {
                GameResult = enGameResult.Won;
                timer1.Enabled = false;
                ShowEndGameScreen();
            }
        }

        private void UpdateTrials()
        {
            MessageBox.Show($"Trial lost! You have {GameStatus.Trials} trials remaining.", "Trial Lost");
            lblTrials.Text = GameStatus.Trials.ToString();

            if (GameStatus.Trials == 0)
            {
                GameResult = enGameResult.Lost;
                timer1.Enabled = false;
                ShowEndGameScreen();
            }
        }

        private async void FlipCard(PictureBox pbCard)
        {
            
            
            // Prevent double-clicking the same card
            if (pbCard.Tag.ToString() == "FacedUp")
                MessageBox.Show("Card Is Faced Up", "Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);

            ShowCardImage(pbCard);

            GameStatus.FlipCount++;
            if (GameStatus.FlipCount == 1)
            {
                GameStatus.FirstCard = pbCard;
            }
            else if(GameStatus.FlipCount == 2)
            {
                GameStatus.SecondCard = pbCard;

                if (!CheckMatch())
                {
                    GameStatus.Trials--;

                    foreach (var card in CardsBoard)
                        card.Enabled = false;

                    await Task.Delay(1000);
                    GameStatus.FirstCard.Image = Resources.imgMemoryGameCardBG;
                    GameStatus.SecondCard.Image = Resources.imgMemoryGameCardBG;

                    foreach (var card in CardsBoard)
                        card.Enabled = true;

                    UpdateTrials();
                }
                else
                {
                    GameStatus.FirstCard.Tag = "FacedUp";
                    GameStatus.SecondCard.Tag = "FacedUp";
                    GameStatus.Score++;
                    UpdateScore();
                }

                GameStatus.FlipCount = 0;
            }

            

        }

        private void ShowCardImage(PictureBox pbCard)
        {
            if (Enum.TryParse(pbCard.Tag.ToString(), out enPlayCards card))
            {
                switch (card)
                {
                    case enPlayCards.Pen:
                        pbCard.Image = Resources.imgPen;
                        break;
                    case enPlayCards.Book:
                        pbCard.Image = Resources.imgBook;
                        break;
                    case enPlayCards.Girl:
                        pbCard.Image = Resources.imgGirl;
                        break;
                    case enPlayCards.Boy:
                        pbCard.Image = Resources.imgBoy;
                        break;
                    case enPlayCards.Guitar:
                        pbCard.Image = Resources.imgGuitar;
                        break;
                    case enPlayCards.Basketball:
                        pbCard.Image = Resources.imgBasketball;
                        break;
                    default:
                        MessageBox.Show("Image not found!");
                        break;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            FlipCard((PictureBox)sender);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            nudTimer.Enabled = false;
            cmbSpeed.Enabled = false;
            btnStart.Enabled = false;
            foreach (PictureBox pb in CardsBoard)
            {
                pb.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            StartNewGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter--;
            SetTimer();
        }

        private void nudTimer_ValueChanged(object sender, EventArgs e)
        {
            Counter = Convert.ToInt32(nudTimer.Value) * 60;
            lblMinutes.Text = nudTimer.Value.ToString("00");
        }

        private void cmbSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            double.TryParse(cmbSpeed.SelectedItem.ToString().Replace("x", ""), out GameStatus.SpeedMultiplier);
            timer1.Interval = (int)(1000 / GameStatus.SpeedMultiplier);
        }
    }
}
