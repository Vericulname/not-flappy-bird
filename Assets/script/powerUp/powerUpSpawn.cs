using NUnit.Framework.Internal;
using UnityEngine;

public class powerUpSpawn : MonoBehaviour
{

    public GameObject LaserPowerUp;
    public GameObject ShieldPowerUp;
    public int spawnRate;
    void Start()
    {

        if (Random.Range(0, spawnRate) == 0)
        {
            SpawnPowerUp();
            // Debug.Log("PowerUp Spawned");
        }
        // Debug.Log("PowerUp spawn rate:" + spawnRate);
    }

    void SpawnPowerUp()
    {
        if (Random.Range(0, 2) == 0)
        {

            Instantiate(LaserPowerUp, gameObject.transform);
        }
        else
        {
            Instantiate(ShieldPowerUp, gameObject.transform);
        }
    }


}
