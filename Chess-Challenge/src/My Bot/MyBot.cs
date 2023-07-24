using ChessChallenge.API;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        // am I attacked? (A piece is safe only as long as it defended by the same number of pieces that are attacking it, If your opponent attacks one of your pieces, count the number of your pieces that defend it immediately to make sure that it is safe)
        // can I capture with gain?
        // otherwise golden rules
        // 1. position in center
        // 2. complete development as quickly as possible (castling on either the kingside or queenside; moving all minor pieces (knights and bishops) from the first rank; connecting the rooks by moving the queen from the first rank.)
        // 3. Castle as soon as you can; if you have reached move 8 and have not castled, you have broken this rule.
        // 4. Try to always keep your rooks connected
        // 5. Rooks belong in open files
        // 6. When your king is under direct attack, exchange as many pieces as possible.
        // 7. When attacking your opponent's king directly, avoid exchanging pieces; you will need them for your attack to be successful
        
        // do random move
        System.Random rnd = new System.Random();
        Move[] moves = board.GetLegalMoves();
        return moves[rnd.Next(moves.Length - 1)];

        // am I attacked?
        if (board.IsInCheck()) {
            // defense king || move king || take attacker
        } else {
            // for each square board.SquareIsAttackedByOpponent
        }

    }
}