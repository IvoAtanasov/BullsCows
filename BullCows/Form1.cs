using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullCows
{
    public partial class GameBullsCows : Form
    {
        private string NumberToGuess;
        private int attempCounter=0;
        public GameBullsCows()
        {
            InitializeComponent();
        }

        private void txtGenerate_Click(object sender, EventArgs e)
        {
            List<char> possibleDigets = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            StringBuilder numberinmind = new StringBuilder();
            Random rdn = new Random();
            AppendGuess(rdn,ref numberinmind, ref possibleDigets, 1, 10);
            AppendGuess(rdn, ref numberinmind, ref possibleDigets, 0, 9);
            AppendGuess(rdn, ref numberinmind, ref possibleDigets, 0,8);
            AppendGuess(rdn, ref numberinmind, ref possibleDigets, 0,7);
            NumberToGuess = numberinmind.ToString();
            txtTry.Enabled = true;
            btnCheck.Enabled = true;
            

        }
        private void AppendGuess(Random rdn , ref StringBuilder numberinmind,ref List<char> possibleDigets,int from , int to)
        {
            int index = rdn.Next(from, to);
            numberinmind.Append(possibleDigets[index].ToString());
            possibleDigets.RemoveAt(index);          
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string attemp = txtTry.Text;
            int attempInt;
            bool correctAttemp = true;
            if (attemp.Length != 4)
            {
                lblError.Text = "Трябва да се въведе число с 4 символа!";
                correctAttemp = false;
            }
            if (int.TryParse(attemp, out attempInt))
            {
                if (attempInt < 1000 || attempInt > 9999)
                {
                    lblError.Text = "Трябва да е между 1000 и 9999!";
                    correctAttemp = false;
                }
            }
            else {
                lblError.Text = "Не е число";
                correctAttemp = false;
            }
            if (correctAttemp)
            {
                attempCounter++;
                lblTry.Text = "Опит"+ (attempCounter+1).ToString();
                
                Play( attemp);
            }
        }

        private void Play(string attemp)
        {
            int bulls=0;
            int cows=0;
            for (int i = 0; i < 4; i++)
            {
                if (attemp[i] == NumberToGuess[i])
                {
                    bulls++;
                    
                }
                else if (NumberToGuess.Contains(attemp[i].ToString()))
                {
                    cows++;
                }
            }
            if (bulls == 4)
            {
                lblError.Text = "Позна!";
            }
            gameBoard.AppendText(Environment.NewLine);
            gameBoard.AppendText(String.Format("Опит{3} : {0} | бикове {1} ; крави {2} ", attemp, bulls, cows,attempCounter));
          
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblError.Text = NumberToGuess;
        }
    }
}
