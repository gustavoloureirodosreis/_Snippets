// Controls whether the game is paused with a private bool changed by a public one.
// Game timeScale is modified accordingly.
private bool _pause;
public bool pause {
    get { return _pause; }
    set {
        _pause = value;
        Time.timeScale = (_pause) ? 0f : 1f;
    }
}