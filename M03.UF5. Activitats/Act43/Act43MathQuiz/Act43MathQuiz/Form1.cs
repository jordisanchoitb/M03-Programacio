using System.Media;

namespace Act43MathQuiz
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        SoundPlayer correctAnswer = new SoundPlayer(@"..\..\..\correct.wav");
        SoundPlayer gameOver = new SoundPlayer(@"..\..\..\gameover.wav");
        SoundPlayer win = new SoundPlayer(@"..\..\..\win.wav");
        int addend1, addent2;
        int minuend, subtrahend;
        int multiplicand, multiplier;
        int dividend, divisor;
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            // Reset the colors
            timeLabel.BackColor = Color.White;
            sum.BackColor = Color.White;
            difference.BackColor = Color.White;
            product.BackColor = Color.White;
            quotient.BackColor = Color.White;

            addend1 = randomizer.Next(51);
            addent2 = randomizer.Next(51);
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addent2.ToString();
            sum.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            divisor = randomizer.Next(2, 11);
            int tempQuotient = randomizer.Next(2, 11);
            dividend = divisor * tempQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addent2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
                sum.BackColor = Color.LightGreen;
                difference.BackColor = Color.LightGreen;
                product.BackColor = Color.LightGreen;
                quotient.BackColor = Color.LightGreen;
                timeLabel.BackColor = Color.LightGreen;
                win.Play();
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                startButton.Enabled = true;
                if (addend1 + addent2 != sum.Value)
                {
                    sum.BackColor = Color.Red;
                }
                if (minuend - subtrahend != difference.Value)
                {
                    difference.BackColor = Color.Red;
                }
                if (multiplicand * multiplier != product.Value)
                {
                    product.BackColor = Color.Red;
                }
                if (dividend / divisor != quotient.Value)
                {
                    quotient.BackColor = Color.Red;
                }
                sum.Value = addend1 + addent2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                timeLabel.BackColor = Color.Red;
                gameOver.Play();
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            if (!startButton.Enabled)
            {
                if (addend1 + addent2 == sum.Value)
                {
                    sum.BackColor = Color.LightGreen;
                    correctAnswer.Play();
                }
                else
                {
                    sum.BackColor = Color.White;
                }

                if (minuend - subtrahend == difference.Value)
                {
                    difference.BackColor = Color.LightGreen;
                    correctAnswer.Play();
                }
                else
                {
                    difference.BackColor = Color.White;
                }

                if (multiplicand * multiplier == product.Value)
                {
                    product.BackColor = Color.LightGreen;
                    correctAnswer.Play();
                }
                else
                {
                    product.BackColor = Color.White;
                }

                try
                {
                    if (dividend / divisor == quotient.Value)
                    {
                        quotient.BackColor = Color.LightGreen;
                        correctAnswer.Play();
                    }
                    else
                    {
                        quotient.BackColor = Color.White;
                    }
                } catch (DivideByZeroException)
                {
                    quotient.BackColor = Color.White;
                }
            }
            
        }
    }
}
