using UnityEngine;

public class pipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    public float heightOffset = 7f;
    private float timer = 0f;
    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (timer > spawnRate)
        {
            timer = 0f;
            spawnPipe();
            // Debug.Log("Pipe Spawned");
        }
        timer += Time.deltaTime;
    }

    void spawnPipe()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        float y = Random.Range(lowestPoint, highestPoint);

        Instantiate(pipe, new Vector3(transform.position.x, y, transform.position.z), transform.rotation);
    }
}
