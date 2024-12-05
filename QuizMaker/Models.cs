using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class Question
    {
        public string Text { get; set; } // Текст вопроса
        public Dictionary<int, string> Answers { get; set; } // Ответы в виде словаря
        public int CorrectAnswerIndex { get; set; } // Индекс правильного ответа
    }

    public class Quiz
    {
        public string Title { get; set; } // Название теста
        public List<Question> Questions { get; set; } // Список вопросов
    }
}
