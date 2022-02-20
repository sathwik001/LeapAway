using UnityEngine;

public class DifficultManager : MonoBehaviour
{
    public ScoreIncrement _score;

    void Update()
    {
        if(_score._scorePoints >= 0f && _score._scorePoints <= 75f)
        {
            FindObjectOfType<SmallObstacleSpawn>()._smallObstacleSpeed = 2f;
            FindObjectOfType<BigObstaclesSpawn>()._bigObstacleSpeed = 2f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._smallObstacleDelay = 3.0f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bigObstacleDelay = 3.0f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bulletSpawnDelay = 6.0f;
        }
        else if (_score._scorePoints >= 75f && _score._scorePoints <= 150f)
        {
            FindObjectOfType<SmallObstacleSpawn>()._smallObstacleSpeed = 2.5f;
            FindObjectOfType<BigObstaclesSpawn>()._bigObstacleSpeed = 2.5f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._smallObstacleDelay = 2.75f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bigObstacleDelay = 2.5f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bulletSpawnDelay = 5.5f;
        }
        else if (_score._scorePoints >= 150f && _score._scorePoints <= 225f)
        {
            FindObjectOfType<SmallObstacleSpawn>()._smallObstacleSpeed = 3f;
            FindObjectOfType<BigObstaclesSpawn>()._bigObstacleSpeed = 3f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._smallObstacleDelay = 2.25f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bigObstacleDelay = 2.0f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bulletSpawnDelay = 5.0f;
        }
        else if (_score._scorePoints >= 225f && _score._scorePoints <= 300f)
        {

            FindObjectOfType<SmallObstacleSpawn>()._smallObstacleSpeed = 3.5f;
            FindObjectOfType<BigObstaclesSpawn>()._bigObstacleSpeed = 3.5f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._smallObstacleDelay = 1.75f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bigObstacleDelay = 1.5f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bulletSpawnDelay = 4.5f;
        }
        else if (_score._scorePoints >= 300f && _score._scorePoints <= 375f)
        {

            FindObjectOfType<SmallObstacleSpawn>()._smallObstacleSpeed = 3.75f;
            FindObjectOfType<BigObstaclesSpawn>()._bigObstacleSpeed = 3.75f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._smallObstacleDelay = 1.55f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bigObstacleDelay = 1.25f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bulletSpawnDelay = 4.25f;
        }
        else if (_score._scorePoints >= 375f && _score._scorePoints <= 500f)
        {

            FindObjectOfType<SmallObstacleSpawn>()._smallObstacleSpeed = 4.0f;
            FindObjectOfType<BigObstaclesSpawn>()._bigObstacleSpeed = 4.0f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._smallObstacleDelay = 1.20f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bigObstacleDelay = 1.0f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bulletSpawnDelay = 4.0f;
        }
        else if (_score._scorePoints >= 500f)
        {
            FindObjectOfType<SmallObstacleSpawn>()._smallObstacleSpeed = 4f;
            FindObjectOfType<BigObstaclesSpawn>()._bigObstacleSpeed = 4f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._smallObstacleDelay = 1.20f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bigObstacleDelay = 1.0f;
            GameObject.Find("SpawnManager").GetComponent<SpawnManagerr>()._bulletSpawnDelay = 4.0f;
        }
    }
}
