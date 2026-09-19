using UnityEngine;

public class MiddleTrigger : MonoBehaviour
{
    public gameLogic gameLogic;
    private int playerLayer;
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();
        playerLayer = LayerMask.NameToLayer("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == playerLayer)
        {
            Debug.Log("Middle Trigger");
        }
        gameLogic.AddScore(1);
    }
}

