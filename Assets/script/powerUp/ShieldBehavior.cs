using System.Collections;
using UnityEngine;

public class ShieldBehavior : MonoBehaviour
{
    private GameObject player;
    public float duration = 5f;
    // private bool isActive = false;
    private int playerLayer = 3;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");



    }

    // Update is called once per frame
    void Update()
    {
        // if (isActive)
        // {
        //     Debug.Log("Shield Activated");
        //     duration -= Time.deltaTime;
        //     Debug.Log("Shield Duration: " + duration);
        //     if (duration < 0)
        //     {
        //         isActive = false;
        //         player.GetComponent<playerScript>().isShieldActive = false;
        //         player.GetComponent<Collider2D>().enabled = true;
        //         // Destroy(gameObject);
        //         Debug.Log("Shield Deactivated");
        //     }
        // }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == playerLayer)
        {
            // isActive = true;
            player.GetComponent<playerScript>().isShieldActive = true;
            // player.GetComponent<Collider2D>().enabled = false;
            // StartCoroutine(ActivateShield());
            Destroy(gameObject);

        }

    }





}
