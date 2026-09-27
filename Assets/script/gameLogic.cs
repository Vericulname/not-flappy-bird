using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    private AudioManager audioManager;
    private bool gameOverHandled;
    [ContextMenu("Add Score")]

    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
        audioManager.PlayScoreSfx();
    }
    public void RestartGame()
    {
        score = 0;
        Debug.Log("Restart Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        if (gameOverHandled)
        {
            return;
        }

        gameOverHandled = true;
        // Debug.Log("Game Over");
        gameOverPanel.SetActive(true);
        audioManager.PlayGameOverSfx();
    }


    // public void UseLaser()
    // {
    //     Debug.Log("Use Laser");
    //     // Implement laser functionality here
    // }
    // public void UseShield()
    // {
    //     Debug.Log("Use Shield");
    //     // Implement shield functionality here
    // }
}
