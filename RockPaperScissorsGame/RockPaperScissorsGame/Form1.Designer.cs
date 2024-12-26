namespace RockPaperScissorsGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            imageList1 = new ImageList(components);
            robotBox = new PictureBox();
            playerBox = new PictureBox();
            groupBox1 = new GroupBox();
            btn3 = new RadioButton();
            btn2 = new RadioButton();
            btn1 = new RadioButton();
            button1 = new Button();
            winnerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)robotBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "rock.png");
            imageList1.Images.SetKeyName(1, "paper.png");
            imageList1.Images.SetKeyName(2, "scissors.png");
            // 
            // robotBox
            // 
            robotBox.Location = new Point(837, 36);
            robotBox.Name = "robotBox";
            robotBox.Size = new Size(382, 375);
            robotBox.SizeMode = PictureBoxSizeMode.AutoSize;
            robotBox.TabIndex = 0;
            robotBox.TabStop = false;
            // 
            // playerBox
            // 
            playerBox.Location = new Point(39, 36);
            playerBox.Name = "playerBox";
            playerBox.Size = new Size(382, 375);
            playerBox.SizeMode = PictureBoxSizeMode.AutoSize;
            playerBox.TabIndex = 1;
            playerBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn3);
            groupBox1.Controls.Add(btn2);
            groupBox1.Controls.Add(btn1);
            groupBox1.Location = new Point(506, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 229);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Your choose:";
            // 
            // btn3
            // 
            btn3.AutoSize = true;
            btn3.Location = new Point(16, 164);
            btn3.Name = "btn3";
            btn3.Size = new Size(127, 36);
            btn3.TabIndex = 2;
            btn3.TabStop = true;
            btn3.Text = "Scissors";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.AutoSize = true;
            btn2.Location = new Point(16, 113);
            btn2.Name = "btn2";
            btn2.Size = new Size(104, 36);
            btn2.TabIndex = 1;
            btn2.TabStop = true;
            btn2.Text = "Paper";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.AutoSize = true;
            btn1.Location = new Point(16, 59);
            btn1.Name = "btn1";
            btn1.Size = new Size(95, 36);
            btn1.TabIndex = 0;
            btn1.TabStop = true;
            btn1.Text = "Rock";
            btn1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI Emoji", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(487, 350);
            button1.Name = "button1";
            button1.Size = new Size(294, 90);
            button1.TabIndex = 3;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // winnerLabel
            // 
            winnerLabel.AutoSize = true;
            winnerLabel.Font = new Font("Segoe UI", 14F);
            winnerLabel.Location = new Point(522, 281);
            winnerLabel.Name = "winnerLabel";
            winnerLabel.Size = new Size(0, 51);
            winnerLabel.TabIndex = 4;
            winnerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(1261, 452);
            Controls.Add(winnerLabel);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(playerBox);
            Controls.Add(robotBox);
            Name = "Form1";
            Text = "RockPaperScissors";
            ((System.ComponentModel.ISupportInitialize)robotBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox robotBox;
        private PictureBox playerBox;
        private GroupBox groupBox1;
        private RadioButton btn3;
        private RadioButton btn2;
        private RadioButton btn1;
        private Button button1;
        private Label winnerLabel;
    }
}
