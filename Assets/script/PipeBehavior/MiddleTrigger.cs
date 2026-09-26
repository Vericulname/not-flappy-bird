using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
    public gameLogic gameLogic;
    private int playerLayer = 3;
    void Start()

    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();


    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == playerLayer)
        {
            // Debug.Log("Middle Trigger");
            gameLogic.AddScore(1);
        }

    }
}

