namespace LeetCodeProblems;

public static class Problem7_ValidSudoku
{
    public static bool IsValidSudoku(char[][] board)
    {
        HashSet<char> nums = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
        for (int i = 0; i < board.Length; ++i)
        {
            HashSet<char> row = [];
            HashSet<char> col = [];
            for (int j = 0; j < board[i].Length; ++j)
            {
                if (row.TryGetValue(board[i][j], out char _))
                {
                    if (!nums.TryGetValue(board[i][j], out char _))
                    {
                        continue;
                    }
                    return false;
                }

                if (col.TryGetValue(board[j][i], out char _))
                {
                    if (!nums.TryGetValue(board[j][i], out char _))
                    {
                        continue;
                    }
                    return false;
                }

                if (board[i][j] != '.')
                {
                    row.Add(board[i][j]);
                }

                if (board[j][i] != '.')
                {
                    col.Add(board[j][i]);
                }
            }
        }

        List<HashSet<char>> boxes = new(board.Length);
        for (int i = 0; i < board.Length; ++i)
        {
            boxes.Add([]);
        }

        for (int i = 0; i < board.Length; ++i)
        {
            for (int j = 0; j < board.Length; ++j)
            {
                int boxIndex = ((i / 3) * 3) + (j / 3);

                if (boxes[boxIndex].TryGetValue(board[i][j], out char _))
                {
                    return false;
                }

                if (board[i][j] != '.')
                {
                    boxes[boxIndex].Add(board[i][j]);
                }
            }
        }

        return true;
    }
}
