using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacles;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObstacleSpawn());
    }

    IEnumerator ObstacleSpawn()
    {
        while (true)
        {
            Vector2 posToSpawn = new Vector2(0f, 7.05f);
            Instantiate(_obstacles, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }

}
