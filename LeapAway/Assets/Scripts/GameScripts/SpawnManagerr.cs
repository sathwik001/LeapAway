using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerr : MonoBehaviour
{
    [SerializeField]
    private GameObject _bigObstacles,_smallObstacles,_rocket;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BigObstacles());
        StartCoroutine(SmallObstaclesSpawn());
        StartCoroutine(BulletSpawn());
    }

    IEnumerator BigObstacles()
    {
        while (true)
        {
            Vector2 bigPosSpawn = new Vector2(0f, 7.9f);
            Instantiate(_bigObstacles, bigPosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }
    }
    
    IEnumerator SmallObstaclesSpawn()
    {
        yield return new WaitForSeconds(1.5f);
        while (true)
        {
            Vector2 smallPosSpawn = new Vector2(0f, 7f);
            Instantiate(_smallObstacles, smallPosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }
    }

    IEnumerator BulletSpawn()
    {
        yield return new WaitForSeconds(15f);
        while (true)
        {
            Vector2 bulletPosSpawn = new Vector2(Random.Range(-2.5f, 2.5f), 5.45f);
            Instantiate(_rocket, bulletPosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(7.0f);
        }
    }
}
