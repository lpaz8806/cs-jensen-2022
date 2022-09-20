namespace L05Classes;

/// <summary>
/// Represents a SlotsMachine.
///
/// The game consist of generating 3 random numbers from 1 to 9 <see cref="Random"/>.
/// If these three numbers are the same, let's call this number theWinningNumber, the
/// player wins, otherwise the player looses.
///
/// It is required to connect a BankAccount in order to be able to start playing
/// The connected account must have enough funds to at least being able to play
/// one move
///
/// When the player wins, the connected account is credited with pricePerMove
/// multiplied by theWinningNumber
///
/// When the player looses, the connected account is debited with pricePerMove
///
/// Enjoy and play responsibly!
/// Sponsored by SvenskaSpel (c)2057
/// </summary>
class SlotsMachine
{
    public SlotsMachine(BankAccount account, decimal pricePerMove)
    {
        
    }
    
    /// <summary>
    /// Plays another round and returns theWinningNumber or 0 if there was no win
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception">When the connected account has not enough funds to play</exception>
    public int Play()
    {
        throw new NotImplementedException();
    }
}