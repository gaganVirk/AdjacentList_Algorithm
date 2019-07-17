using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacentList_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("AdjList.txt");
            Console.SetIn(reader);

            int size = Convert.ToInt32(Console.ReadLine());
            List<Vertex> vertices = new List<Vertex>();

            for(int v = 0; v < size; v++)
            {
                vertices.Add(new Vertex(v));
            }

            string line = Console.ReadLine();
            while(line != "-1 -1")
            {
                string[] array = line.Split(' ');
                int token1 = int.Parse(array[0]);
                int token2 = int.Parse(array[1]);
                vertices[token1].AddNeighbour(vertices[token2]);
                line = Console.ReadLine();
            }

            foreach(Vertex v in vertices)
            {
                Console.WriteLine("{0}", v.ToString());
            }
          
            Console.ReadLine();
        }
    }
}
