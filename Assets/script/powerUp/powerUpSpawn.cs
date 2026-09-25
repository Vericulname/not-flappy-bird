using NUnit.Framework.Internal;
using UnityEngine;

public class powerUpSpawn : MonoBehaviour
{

    public GameObject LaserPowerUp;
    public GameObject ShieldPowerUp;
    private int spawnRate = 1;
    void Start()
    {

        if (Random.Range(0, spawnRate) == 0)
        {
            SpawnPowerUp();
            // Debug.Log("PowerUp Spawned");
        }
    }

    void SpawnPowerUp()
    {
        // if (Random.Range(0, 2) == 0)
        // {

        Instantiate(LaserPowerUp, gameObject.transform);
        // }
        // else
        // {
        //     Instantiate(ShieldPowerUp, gameObject.transform);
        // }
    }


}
