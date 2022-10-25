using System;
namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
{
    private TerminalService _terminalService = new TerminalService();
    private Library _library = new Library();
    private HiddenWord _hiddenWord;
    bool _isPlaying = true;
    public char guess;

    /// <summary>
    /// Constructs a new instance of Director.
    /// </summary>
    public Director()
    {
    }

    /// <summary>
    /// Starts the game
    /// </summary>
    public void StartGame()
    {
        string diff = _terminalService.ReadText("What difficulty: hard or easy? [h/e]");

        _library.getWord(diff);
        _hiddenWord = new HiddenWord(_library.hiddenWord);
        _hiddenWord.drawState();
        while (_isPlaying)
        {
            GetInputs();
            DoUpdates();
            DoOutputs();
        }
    }

    /// <summary>
    /// Gets the user's guess
    /// </summary>
    private void GetInputs()
    {
        guess = _terminalService.ReadText("Guess a letter: ").ToCharArray()[0];
    }

    /// <summary>
    /// Passes guess over to method
    /// Receives answer whether game is over
    /// </summary>
    private void DoUpdates()
    {
        _hiddenWord.guessCharacter(guess);
        _isPlaying = _hiddenWord.checkGameContinue();
    }

    /// <summary>
    /// Draws state of game
    /// </summary>
    private void DoOutputs()
    {
        _hiddenWord.drawState();
        if (_isPlaying == false)
            {
                _terminalService.WriteText("Game over!");
            }
    }
}
}