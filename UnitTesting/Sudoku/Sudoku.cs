namespace UnitTesting.Sudoku
{
    public static class Sudoku
    {

        public static bool ValidSolution(int[][] matrix)
        {

            bool cantContinue = matrix.Any(row => row.Contains(0));
            if (cantContinue) return false;

            cantContinue = HasDuplicateNumbersOnRowOrColumn(matrix);
            if (cantContinue) return false;

            cantContinue = HasDuplicateNumbersOnBlocks(matrix);
            if (cantContinue) return false;

            return true;

        }

        private static bool HasDuplicateNumbersOnRowOrColumn(int[][] matrix)
        {

            for (int i = 0; i < matrix.Length; i++)
            {

                var row = new HashSet<int>(matrix[i]);
                if (row.Count != 9) return true;

                var column = new HashSet<int>();

                for (int j = 0; j < matrix.Length; j++)
                {

                    column.Add(matrix[j][i]);

                }

                if (column.Count != 9) return true;

            }

            return false;

        }

        private static bool HasDuplicateNumbersOnBlocks(int[][] matrix)
        {

            for (int rowStart = 0; rowStart < matrix.Length; rowStart += 3)
            {

                for (int colStart = 0; colStart < matrix[rowStart].Length; colStart += 3)
                {

                    var block = new HashSet<int>();

                    for (int i = 0; i < 3; i++)
                    {

                        for (int j = 0; j < 3; j++)
                        {

                            int current = matrix[rowStart + i][colStart + j];
                            block.Add(current);

                        }

                    }

                    if (block.Count != 9) return true;

                }

            }

            return false;

        }

    }
}
