
namespace CousrseSchedule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCourses = 2;
            int[][] prerequisites = [[1, 0],[0,1]];
            bool res = CanFinish(numCourses, prerequisites);
            Console.WriteLine(res);
        }
        //this is a problem about checking circle or ring in a graph.
        private static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            //build a graph 
            Graph courses= new Graph(numCourses);
            foreach(var course in prerequisites)
            {
                courses.AddEdge(course[0], course[1]);
            }


            return !courses.IsCyclic();
            

        }


        public class Graph
        {
            private int _vertices;
            private List<int>[] _adjacencyList;
            public Graph(int vertices)
            {
                _vertices = vertices;
                _adjacencyList = new List<int>[vertices];
                for(int i =0; i< vertices;i++)
                {
                    _adjacencyList[i]=new List<int>();
                }
                
            }
            public void AddEdge(int v, int w)
            {
                _adjacencyList[v].Add(w);
            }

            private bool IsCyclicUtil(int v, bool[] visited, bool[] recursionStack)
            {
                if (visited[v] == false)
                {
                    visited[v] = true;
                    recursionStack[v] = true;

                    foreach (var neighbour in _adjacencyList[v])
                    {
                        if (!visited[neighbour] && IsCyclicUtil(neighbour, visited, recursionStack))
                            return true;
                        else if (recursionStack[neighbour])
                            return true;
                    }
                }
                recursionStack[v] = false;
                return false;
            }

            public bool IsCyclic()
            {
                bool[] visited = new bool[_vertices];
                bool[] recursionStack = new bool[_vertices];
                for (int i = 0; i < _vertices; i++)
                    if (IsCyclicUtil(i, visited, recursionStack))
                        return true;

                return false;
            }
        }



       
    }
}
