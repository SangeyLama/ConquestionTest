using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MapNode
    {
        public int Id { get; set; }
        public List<MapNode> ConnectedNodes { get; set; }
        public bool IsStartingNode { get; set; }
        public Player occupiedBy { get; set; }

    }
}
