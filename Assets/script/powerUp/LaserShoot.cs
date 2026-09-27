using UnityEngine;

public class LaserShoot : MonoBehaviour
{

    private gameLogic gameLogic;
    private AudioManager audioManager;
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Logic").GetComponent<gameLogic>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            Destroy(collision.gameObject);
            // Debug.Log("Obstacle Destroyed");
            gameLogic.AddScore(1);
        }
        // Debug.Log("Laser Hit: " + collision.gameObject.name);
    }

}
