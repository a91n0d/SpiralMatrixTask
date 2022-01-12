using System;

#pragma warning disable CA1814

namespace SpiralMatrixTask
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Fills the matrix with natural numbers, starting from 1 in the top-left corner, increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix size.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Thrown when matrix size less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException($"Size of matrix '{size}' cannot be less or equal zero.", nameof(size));
            }

            int[,] matrix = new int[size, size];
            int i = 0, j = 0;
            for (int number = 1; number <= size * size; number++)
            {
                matrix[i, j] = number;
                if (i <= j + 1 && i + j < size - 1)
                {
                    j += 1;
                }
                else if (i < j && i + j >= size - 1)
                {
                    i += 1;
                }
                else if (i >= j && i + j > size - 1)
                {
                    j -= 1;
                }
                else if (i > j + 1 && i + j <= size - 1)
                {
                    i -= 1;
                }
            }

            return matrix;
        }
    }
}
