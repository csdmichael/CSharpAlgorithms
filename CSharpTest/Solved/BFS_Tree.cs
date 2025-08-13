using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.Solved
{
    public class BFS_Tree
    {
        public static void LeftTree(Node root)
        {
            string[] result = new string[] { };

            if (root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    int n = queue.Count;

                    for (int i = 1; i <= n; i++)
                    {
                        Node temp = queue.Dequeue();
                        if (i == 1)
                            Console.Write(temp.Value + " ");

                        if (temp.Left != null)
                        {
                            queue.Enqueue(temp.Left);
                        }

                        if (temp.Right != null)
                        {
                            queue.Enqueue(temp.Right);
                        }
                    }
                }
            }

        }

        public static void RightTree(Node root)
        {
            string[] result = new string[] { };

            if (root != null)
            {
                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(root);

                while (queue.Count > 0)
                {
                    int n = queue.Count;

                    for (int i = 1; i <= n; i++)
                    {
                        Node temp = queue.Dequeue();
                        if (i == n)
                            Console.Write(temp.Value + " ");

                        if (temp.Left != null)
                        {
                            queue.Enqueue(temp.Left);
                        }

                        if (temp.Right != null)
                        {
                            queue.Enqueue(temp.Right);
                        }
                    }
                }
            }

        }
    }
}
