namespace RockPaperScissorsGame
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random(); 

        public Form1()
        {
            InitializeComponent();
           

            
            robotBox.Image = imageList1.Images[0]; 
            playerBox.Image = imageList1.Images[0];
        }

        
        private int GetComputerChoice()
        {
            return rnd.Next(0, 3); 
        }

        
        private void ShowComputerChoice(int computerChoice)
        {
            robotBox.Image = imageList1.Images[computerChoice]; 
        }

      
        private int GetPlayerChoice()
        {
            
            if (btn1.Checked) return 0; 
            if (btn2.Checked) return 1; 
            if (btn3.Checked) return 2; 

            return 0; 
        }

        
        private void ShowPlayerChoice(int playerChoice)
        {
            playerBox.Image = imageList1.Images[playerChoice];
        }

        
        private void ShowWinnerText(int playerChoice, int computerChoice, Label winnerLabel)
        {
            
            if (playerChoice < 0 || playerChoice > 2 || computerChoice < 0 || computerChoice > 2)
            {
                winnerLabel.Text = "Invalid input. Choices should be between 0 (Rock), 1 (Paper), and 2 (Scissors).";
                return;
            }

            
            string[] choices = { "Rock", "Paper", "Scissors" };

            string playerChoiceText = choices[playerChoice];
            string computerChoiceText = choices[computerChoice];

            
            if (playerChoice == computerChoice)
            {
                winnerLabel.Text = "It's a draw!";
                winnerLabel.ForeColor = Color.Blue;
            }
            else if ((playerChoice == 0 && computerChoice == 2) ||
                     (playerChoice == 2 && computerChoice == 1) || 
                     (playerChoice == 1 && computerChoice == 0))   
            {
                winnerLabel.Text = "Player wins!";
                winnerLabel.ForeColor = Color.Green;
            }
            else
            {
                winnerLabel.Text = "Computer wins!";
                winnerLabel.ForeColor = Color.Red;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            int playerChoice = GetPlayerChoice();

           
            ShowPlayerChoice(playerChoice);

            
            int computerChoice = GetComputerChoice();

            
            ShowComputerChoice(computerChoice);

            
            ShowWinnerText(playerChoice, computerChoice, winnerLabel);
        }
    }
}
