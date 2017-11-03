using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GameSession
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public List<Round> Rounds { get; set; }
        public List<Player> Players { get; set; }
        public Map Map { get; set; }
        public QuestionSet QuestionSet { get; set; }
        public List<Question> QuestionsAsked { get; set; }


    }
}
