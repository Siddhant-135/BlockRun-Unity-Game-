using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    bool gameEnded = false;
    public AudioManager audioManager;

    public void gameOver()
    {
        if(!gameEnded)
        {
            gameEnded = true;
            if (audioManager != null)
                audioManager.playGameOver();
            Debug.Log("Game Over");
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
