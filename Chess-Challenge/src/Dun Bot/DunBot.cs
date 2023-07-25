using ChessChallenge.API;

public class DunBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        System.Random rnd = new System.Random();
        Move[] moves = board.GetLegalMoves();
        return moves[rnd.Next(moves.Length - 1)];
    }

    // private int miniMax(Board board, int depth, bool maximizePlayer, int alpha, int beta) {
    //     if (depth == 0 || board.IsInCheckmate()) {
    //         return evaluate(board);
    //     }

    //     Move[] moves = board.GetLegalMoves();

    //     if (maximizePlayer)
    //     {
    //         int bestScore = int.MinValue;

    //         foreach (Move move in moves)
    //         {
    //             board.MakeMove(move);
    //             int score = MiniMax(board, depth - 1, false, alpha, beta);
    //             board.UndoMove();

    //             bestScore = Math.Max(bestScore, score);
    //             alpha = Math.Max(alpha, score);

    //             if (beta <= alpha)
    //                 break;
    //         }

    //         return bestScore;
    //     }
    //     else
    //     {
    //         int bestScore = POSITIVE_INFINITY;

    //         foreach (Move move in moves)
    //         {
    //             board.MakeMove(move);
    //             int score = MiniMax(board, depth - 1, true, alpha, beta);
    //             board.UndoMove();

    //             bestScore = Math.Min(bestScore, score);
    //             beta = Math.Min(beta, score);

    //             if (beta <= alpha)
    //                 break;
    //         }

    //         return bestScore;
    //     }
    // }

    private int evaluate(Board board) {

        return 0;
    }
}