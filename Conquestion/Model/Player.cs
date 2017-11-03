using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<GameSession> GamesPlayed { get; set; }

        public List<RoundAction> RoundsPlayed { get; set; }


    }
}
