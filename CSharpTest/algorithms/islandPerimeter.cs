using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.algorithms
{
    public class IslandPerimeter
    {
        public int CaclculateIslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            if (grid == null) return perimeter;
            int rows = grid.Length;
            int cols = grid[0].Length;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; cols++)
                {
                    if (grid[r][c] == 1)
                    {
                        perimeter += 4;
                        if (r > 0)
                        {
                            if (grid[r-1][c] == 1)
                            {
                                perimeter -= 2; 
                            }
                        }
                        if (c > 0)
                        {
                            if (grid[r][c - 1] == 1)
                            {
                                perimeter -= 2;
                            }
                        }
                    }
                }
            } 

            return perimeter;
        }
    }
}
