using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentList_Algo
{
    class Vertex
    {
        public int Id { get; set; }
        List<Vertex> adj = new List<Vertex>();

        public Vertex(int id)
        {
            this.Id = id;
        }

        public void AddNeighbour(Vertex v)
        {
            adj.Add(v);
        }

        public override string ToString()
        {
            string s = string.Format("{0}: ", Id);
            foreach(Vertex v in adj)
            {
                s += string.Format(" {0}", v.Id);
            }
            return s;
        }
    }
}
