using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour
{
    public int score;
    public Text scoreText;
    [ContextMenu("Add Score")]
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = score.ToString();
    }
}
