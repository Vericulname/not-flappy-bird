using UnityEngine;

public class LaserBehavior : MonoBehaviour
{
    public float chargeTime = 5f;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.GetComponent<playerScript>().isLaserActive = true;
            Destroy(gameObject);
            // Debug.Log("Laser Activated");
        }
    }
}
