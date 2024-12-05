namespace QuizMaker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            ConstructorTab = new TabPage();
            saveQuizButton = new Button();
            addQuestionButton = new Button();
            correctAnswerGroup = new GroupBox();
            correctAnswer4 = new RadioButton();
            correctAnswer2 = new RadioButton();
            correctAnswer3 = new RadioButton();
            correctAnswer1 = new RadioButton();
            answer4TextBox = new TextBox();
            answer3TextBox = new TextBox();
            answer2TextBox = new TextBox();
            answer1TextBox = new TextBox();
            answer4 = new Label();
            answer3 = new Label();
            answer2 = new Label();
            answer1 = new Label();
            questionTextBox = new TextBox();
            label1 = new Label();
            QuizTab = new TabPage();
            loadQuizButton = new Button();
            nextQuestionButton = new Button();
            answerGroup = new GroupBox();
            quizAnswer4 = new RadioButton();
            quizAnswer2 = new RadioButton();
            quizAnswer3 = new RadioButton();
            quizAnswer1 = new RadioButton();
            questionLabel = new Label();
            tabControl1.SuspendLayout();
            ConstructorTab.SuspendLayout();
            correctAnswerGroup.SuspendLayout();
            QuizTab.SuspendLayout();
            answerGroup.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Controls.Add(ConstructorTab);
            tabControl1.Controls.Add(QuizTab);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // ConstructorTab
            // 
            resources.ApplyResources(ConstructorTab, "ConstructorTab");
            ConstructorTab.BackColor = SystemColors.AppWorkspace;
            ConstructorTab.Controls.Add(saveQuizButton);
            ConstructorTab.Controls.Add(addQuestionButton);
            ConstructorTab.Controls.Add(correctAnswerGroup);
            ConstructorTab.Controls.Add(answer4TextBox);
            ConstructorTab.Controls.Add(answer3TextBox);
            ConstructorTab.Controls.Add(answer2TextBox);
            ConstructorTab.Controls.Add(answer1TextBox);
            ConstructorTab.Controls.Add(answer4);
            ConstructorTab.Controls.Add(answer3);
            ConstructorTab.Controls.Add(answer2);
            ConstructorTab.Controls.Add(answer1);
            ConstructorTab.Controls.Add(questionTextBox);
            ConstructorTab.Controls.Add(label1);
            ConstructorTab.Name = "ConstructorTab";
            // 
            // saveQuizButton
            // 
            resources.ApplyResources(saveQuizButton, "saveQuizButton");
            saveQuizButton.BackColor = SystemColors.HotTrack;
            saveQuizButton.ForeColor = SystemColors.ButtonFace;
            saveQuizButton.Name = "saveQuizButton";
            saveQuizButton.UseVisualStyleBackColor = false;
            saveQuizButton.Click += saveQuizButton_Click;
            // 
            // addQuestionButton
            // 
            resources.ApplyResources(addQuestionButton, "addQuestionButton");
            addQuestionButton.BackColor = SystemColors.Highlight;
            addQuestionButton.ForeColor = SystemColors.ButtonFace;
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.UseVisualStyleBackColor = false;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // correctAnswerGroup
            // 
            resources.ApplyResources(correctAnswerGroup, "correctAnswerGroup");
            correctAnswerGroup.Controls.Add(correctAnswer4);
            correctAnswerGroup.Controls.Add(correctAnswer2);
            correctAnswerGroup.Controls.Add(correctAnswer3);
            correctAnswerGroup.Controls.Add(correctAnswer1);
            correctAnswerGroup.Name = "correctAnswerGroup";
            correctAnswerGroup.TabStop = false;
            // 
            // correctAnswer4
            // 
            resources.ApplyResources(correctAnswer4, "correctAnswer4");
            correctAnswer4.Name = "correctAnswer4";
            correctAnswer4.TabStop = true;
            correctAnswer4.UseVisualStyleBackColor = true;
            // 
            // correctAnswer2
            // 
            resources.ApplyResources(correctAnswer2, "correctAnswer2");
            correctAnswer2.Name = "correctAnswer2";
            correctAnswer2.TabStop = true;
            correctAnswer2.UseVisualStyleBackColor = true;
            // 
            // correctAnswer3
            // 
            resources.ApplyResources(correctAnswer3, "correctAnswer3");
            correctAnswer3.Name = "correctAnswer3";
            correctAnswer3.TabStop = true;
            correctAnswer3.UseVisualStyleBackColor = true;
            // 
            // correctAnswer1
            // 
            resources.ApplyResources(correctAnswer1, "correctAnswer1");
            correctAnswer1.Name = "correctAnswer1";
            correctAnswer1.TabStop = true;
            correctAnswer1.UseVisualStyleBackColor = true;
            // 
            // answer4TextBox
            // 
            resources.ApplyResources(answer4TextBox, "answer4TextBox");
            answer4TextBox.Name = "answer4TextBox";
            // 
            // answer3TextBox
            // 
            resources.ApplyResources(answer3TextBox, "answer3TextBox");
            answer3TextBox.Name = "answer3TextBox";
            // 
            // answer2TextBox
            // 
            resources.ApplyResources(answer2TextBox, "answer2TextBox");
            answer2TextBox.Name = "answer2TextBox";
            // 
            // answer1TextBox
            // 
            resources.ApplyResources(answer1TextBox, "answer1TextBox");
            answer1TextBox.Name = "answer1TextBox";
            // 
            // answer4
            // 
            resources.ApplyResources(answer4, "answer4");
            answer4.Name = "answer4";
            // 
            // answer3
            // 
            resources.ApplyResources(answer3, "answer3");
            answer3.Name = "answer3";
            // 
            // answer2
            // 
            resources.ApplyResources(answer2, "answer2");
            answer2.Name = "answer2";
            // 
            // answer1
            // 
            resources.ApplyResources(answer1, "answer1");
            answer1.Name = "answer1";
            // 
            // questionTextBox
            // 
            resources.ApplyResources(questionTextBox, "questionTextBox");
            questionTextBox.Name = "questionTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // QuizTab
            // 
            resources.ApplyResources(QuizTab, "QuizTab");
            QuizTab.BackColor = SystemColors.AppWorkspace;
            QuizTab.Controls.Add(loadQuizButton);
            QuizTab.Controls.Add(nextQuestionButton);
            QuizTab.Controls.Add(answerGroup);
            QuizTab.Controls.Add(questionLabel);
            QuizTab.Name = "QuizTab";
            // 
            // loadQuizButton
            // 
            resources.ApplyResources(loadQuizButton, "loadQuizButton");
            loadQuizButton.BackColor = Color.Navy;
            loadQuizButton.ForeColor = SystemColors.HighlightText;
            loadQuizButton.Name = "loadQuizButton";
            loadQuizButton.UseVisualStyleBackColor = false;
            loadQuizButton.Click += loadQuizButton_Click;
            // 
            // nextQuestionButton
            // 
            resources.ApplyResources(nextQuestionButton, "nextQuestionButton");
            nextQuestionButton.BackColor = Color.SteelBlue;
            nextQuestionButton.ForeColor = SystemColors.HighlightText;
            nextQuestionButton.Name = "nextQuestionButton";
            nextQuestionButton.UseVisualStyleBackColor = false;
            nextQuestionButton.Click += nextQuestionButton_Click;
            // 
            // answerGroup
            // 
            resources.ApplyResources(answerGroup, "answerGroup");
            answerGroup.Controls.Add(quizAnswer4);
            answerGroup.Controls.Add(quizAnswer2);
            answerGroup.Controls.Add(quizAnswer3);
            answerGroup.Controls.Add(quizAnswer1);
            answerGroup.Name = "answerGroup";
            answerGroup.TabStop = false;
            // 
            // quizAnswer4
            // 
            resources.ApplyResources(quizAnswer4, "quizAnswer4");
            quizAnswer4.Name = "quizAnswer4";
            quizAnswer4.TabStop = true;
            quizAnswer4.UseVisualStyleBackColor = true;
            // 
            // quizAnswer2
            // 
            resources.ApplyResources(quizAnswer2, "quizAnswer2");
            quizAnswer2.Name = "quizAnswer2";
            quizAnswer2.TabStop = true;
            quizAnswer2.UseVisualStyleBackColor = true;
            // 
            // quizAnswer3
            // 
            resources.ApplyResources(quizAnswer3, "quizAnswer3");
            quizAnswer3.Name = "quizAnswer3";
            quizAnswer3.TabStop = true;
            quizAnswer3.UseVisualStyleBackColor = true;
            // 
            // quizAnswer1
            // 
            resources.ApplyResources(quizAnswer1, "quizAnswer1");
            quizAnswer1.Name = "quizAnswer1";
            quizAnswer1.TabStop = true;
            quizAnswer1.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            resources.ApplyResources(questionLabel, "questionLabel");
            questionLabel.Name = "questionLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 45, 45);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MainForm";
            tabControl1.ResumeLayout(false);
            ConstructorTab.ResumeLayout(false);
            ConstructorTab.PerformLayout();
            correctAnswerGroup.ResumeLayout(false);
            correctAnswerGroup.PerformLayout();
            QuizTab.ResumeLayout(false);
            answerGroup.ResumeLayout(false);
            answerGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage ConstructorTab;
        private TabPage QuizTab;
        private TextBox questionTextBox;
        private Label label1;
        private GroupBox correctAnswerGroup;
        private RadioButton correctAnswer1;
        private TextBox answer4TextBox;
        private TextBox answer3TextBox;
        private TextBox answer2TextBox;
        private TextBox answer1TextBox;
        private Label answer4;
        private Label answer3;
        private Label answer2;
        private Label answer1;
        private RadioButton correctAnswer4;
        private RadioButton correctAnswer2;
        private RadioButton correctAnswer3;
        private Button addQuestionButton;
        private Button saveQuizButton;
        private GroupBox answerGroup;
        private Label questionLabel;
        private RadioButton quizAnswer4;
        private RadioButton quizAnswer2;
        private RadioButton quizAnswer3;
        private RadioButton quizAnswer1;
        private Button loadQuizButton;
        private Button nextQuestionButton;
    }
}
