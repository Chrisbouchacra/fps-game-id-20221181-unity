
    using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public void StartGame() => SceneManager.LoadScene("Game"); // Transition to gameplay
    public void GoToMenu() => SceneManager.LoadScene("Menu");
    public void Restart() => SceneManager.LoadScene("Game");
}
}
