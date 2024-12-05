using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
namespace QuizMaker
{
    public partial class MainForm : Form
    {
        private List<Question> questions = new List<Question>();
        private Quiz currentQuiz;
        private int currentQuestionIndex = 0;
        private int correctAnswerCount = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var question = new Question
            {
                Text = questionTextBox.Text,
                Answers = new Dictionary<int, string>
                {
                    { 0, answer1TextBox.Text },
                    { 1, answer2TextBox.Text },
                    { 2, answer3TextBox.Text },
                    { 3, answer4TextBox.Text }
                },
                CorrectAnswerIndex = correctAnswerGroup.Controls.OfType<RadioButton>().ToList().FindIndex(r => r.Checked)
            };

            questions.Add(question);
            MessageBox.Show("Question has been added");
        }

        private void saveQuizButton_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0)
            {
                MessageBox.Show("You have not added any questions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quiz = new Quiz
            {
                Title = questionTextBox.Text,
                Questions = questions
            };

            SaveQuizToFile("quiz.json", quiz);
        }
        private void SaveQuizToFile(string filePath, Quiz quiz)
        {
            try
            {
                var json = System.Text.Json.JsonSerializer.Serialize(quiz);
                File.WriteAllText(filePath, json);
                MessageBox.Show("Test saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Quiz LoadQuizFromFile(string filePath)
        {
            try
            {
                var json = File.ReadAllText(filePath);
                return System.Text.Json.JsonSerializer.Deserialize<Quiz>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void DisplayCurrentQuestion()
        {
            if (currentQuiz == null || currentQuiz.Questions.Count == 0)
                return;

            var question = currentQuiz.Questions[currentQuestionIndex];
            questionLabel.Text = question.Text;

            var radioButtons = answerGroup.Controls.OfType<RadioButton>().ToList();
            int i = 0;

            foreach (var answer in question.Answers.OrderBy(a => a.Key)) // Гарантируем порядок по ключу
            {
                if (i < radioButtons.Count)
                {
                    radioButtons[i].Text = answer.Value;
                    radioButtons[i].Checked = false;
                    i++;
                }
            }
        }

        private void loadQuizButton_Click(object sender, EventArgs e)
        {
            try
            {
                currentQuiz = LoadQuizFromFile("quiz.json");

                if (currentQuiz.Questions.Count == 0)
                {
                    MessageBox.Show("No questions in the test!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentQuestionIndex = 0; // Начинаем с первого вопроса
                correctAnswerCount = 0;  // Сбрасываем счетчик правильных ответов
                DisplayCurrentQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Test boot error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            if (currentQuiz == null || currentQuestionIndex >= currentQuiz.Questions.Count)
                return;

            var selectedAnswerText = answerGroup.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked)?.Text;

            var correctAnswerText = currentQuiz.Questions[currentQuestionIndex]
                                   .Answers[currentQuiz.Questions[currentQuestionIndex].CorrectAnswerIndex];

            if (selectedAnswerText == correctAnswerText)
            {
                correctAnswerCount++;
            }

            currentQuestionIndex++;

            if (currentQuestionIndex >= currentQuiz.Questions.Count)
            {
                MessageBox.Show($"Test completed! Your result: {correctAnswerCount} of {currentQuiz.Questions.Count}",
                                "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentQuestionIndex = 0;
                correctAnswerCount = 0;
                questionLabel.Text = "Take the test again or load a new one!";
            }
            else
            {
                DisplayCurrentQuestion();
            }
        }
    }
}
