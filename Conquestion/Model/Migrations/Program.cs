using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Migrations
{
    class Program
    {
        public static void Main(string[] args)
        {
            GameSession game = new GameSession { Id=1, GameName="Test"};
            Player player1 = new Player {Id=1, Name="Sangey", Email="sl@ucn.dk" };
            Player player2 = new Player { Id = 2, Name = "Tamas", Email = "tm@ucn.dk" };
            game.Players.Add(player1);
            game.Players.Add(player2);
            QuestionSet qSet = new QuestionSet { Id = 1, Title = "Computer Science", Description = "Numbers and shit" };
            Question q1 = new Question { Id = 1, QuestionText = "What number do arrays start at" };
            Answer a1 = new Answer { Id = 1, AnswerText = "0", isValid = true };
            Answer a2 = new Answer { Id = 2, AnswerText = "1", isValid = false };
            Answer a3 = new Answer { Id = 3, AnswerText = "2", isValid = false };
            Answer a4 = new Answer { Id = 4, AnswerText = "3", isValid = false};
            q1.Answers.Add(a1);
            q1.Answers.Add(a2);
            q1.Answers.Add(a3);
            q1.Answers.Add(a4);
            qSet.Questions.Add(q1);
            game.QuestionSet = qSet;
        }
    }
}
