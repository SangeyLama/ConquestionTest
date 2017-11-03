using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Answer
    {
        public int Id { get; set; }
        public bool isValid { get; set; }
        public string AnswerText { get; set; }

        public List<RoundAction> RoundsUsedIn { get; set; }

    }
}
