using System.Linq;

namespace UnitTesting.Sudoku
{
    public static class Sudoku
    {

        public static bool ValidSolution(int[][] matrix)
        {

            bool cantContinue = matrix.Any(row => row.Contains(0));
            if (cantContinue) return false;

            cantContinue = HasDuplicateNumbersOnRow(matrix);
            if(cantContinue) return false;

            return true;

        }

        private static bool HasDuplicateNumbersOnRow(int[][] matrix)
        {

            for (int i = 0;  i < matrix.Length; i++)
            {
                var row = new HashSet<int>(matrix[i]);

                if (row.Count != 9) return true;

            }

            return false;

        }

    }
}
