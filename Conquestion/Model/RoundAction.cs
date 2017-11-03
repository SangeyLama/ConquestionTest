using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RoundAction
    {
        public int Id { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public MapNode ContestedNode { get; set; }
        public Question RoundQuestion { get; set; }
        public List<Answer> AnswersDisplayed { get; set; }
        public List<PlayerAnswer> PlayerAnswers { get; set; }


    }
}
