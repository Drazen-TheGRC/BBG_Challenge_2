using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    void SpawnRandomBall()
    {
        // Spawn random ball at random position
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // Random delay before next spawn
        float nextDelay = Random.Range(3f, 5f);
        Invoke("SpawnRandomBall", nextDelay);
    }
}

