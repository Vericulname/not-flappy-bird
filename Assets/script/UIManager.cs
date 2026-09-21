using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Start Game");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
