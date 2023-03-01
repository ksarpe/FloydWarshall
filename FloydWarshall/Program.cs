using System;

namespace FloydWarshall
{
    class Program
    {
        readonly static int INF = 99999, V = 4;

        // two-dim array as parameter
        void floydWarshall(int [,] graph) {

            int[,] dist = new int[V, V]; // empty array for distances values

            int i, j, k;
            //initialize distance array
            //the same as graph array
            //as shortest path from vertex
            //to the same vertex its it itself
            for (i = 0; i < V; i++) {
                for(j = 0; j < V; j++) {
                    dist[i, j] = graph[i, j];
                }
            }

            for (k = 0; k < V; k++) {               
                for (i = 0; i < V; i++) {
                    for (j = 0; j < V; j++) {
                        Console.WriteLine("Checking " + (i+1) + " to " + (j+1) + " through " + (k+1));
                        Console.WriteLine(dist[i, k] + " + " + dist[k, j] + " < " + dist[i, j]);
                        if (dist[i, k] + dist[k, j] < dist[i, j]) {
                            dist[i, j] = dist[i, k] + dist[k, j];
                            Console.WriteLine(" result: true");
                        }
                    }
                }
            }


        }

        public static void Main(string[] args) {
            int[,] graph = { { 0, 3, INF, 5 },
                             { 2, 0, INF, 4 },
                             { INF, 1, 0, INF },
                             { INF, INF, 2, 0 } };

            Program a = new Program();

            // Function call
            a.floydWarshall(graph);
            Console.ReadLine();
        }

    }
}
