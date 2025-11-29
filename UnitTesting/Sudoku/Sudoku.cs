using System.Linq;

namespace UnitTesting.Sudoku
{
    public static class Sudoku
    {

        public static bool ValidSolution(int[][] matrix)
        {

            bool containsZero = matrix.Any(row => row.Contains(0));
            if (containsZero) return false;

            return true;

        }

    }
}
