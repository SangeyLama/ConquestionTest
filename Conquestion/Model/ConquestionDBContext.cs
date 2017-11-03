using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConquestionDBContext : DbContext
    {
        public DbSet<GameSession> GameSessions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<MapNode> MapNodes { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAnswer> PlayerAnswers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionSet> QuestionSets { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<RoundAction> RoundActions { get; set; }

        public ConquestionDBContext() : base("name=ConquestionDBConnection")
        {
            
        }
    }
}
