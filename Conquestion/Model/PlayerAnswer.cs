using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PlayerAnswer
    {
        public int Id { get; set; }
        public Answer AnswerGiven { get; set; }
        public string Timestamp { get; set; }

    }
}
