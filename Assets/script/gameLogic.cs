using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    [ContextMenu("Add Score")]

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
    public void RestartGame()
    {
        score = 0;
        Debug.Log("Restart Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        // Debug.Log("Game Over");
        gameOverPanel.SetActive(true);
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
