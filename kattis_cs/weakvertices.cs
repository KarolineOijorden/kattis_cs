namespace kattis_cs
{
    class weakvertices
    {
        static void Main(string[] args)
        {
            int n;
            while ((n = int.Parse(Console.ReadLine())) != -1)
            {
                bool[] strongVertices = new bool[n];
                int[,] adjMatrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    int[] row = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));
                    for (int j = 1; j < row.Length; j++)
                    {
                        adjMatrix[i, j] = row[j];
                    }
                }

                for (int i = 0; i < n - 2; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (adjMatrix[i, j] == 1)
                        {
                            for (int k = j + 1; k < n; k++)
                            {
                                if (adjMatrix[i, k] == 1)
                                {
                                    if (adjMatrix[j, k] == 1)
                                    {
                                        strongVertices[i] = true;
                                        strongVertices[j] = true;
                                        strongVertices[k] = true;
                                    }
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    if (!strongVertices[i])
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
