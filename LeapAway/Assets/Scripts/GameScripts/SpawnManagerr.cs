using System.Collections;
using UnityEngine;

public class SpawnManagerr : MonoBehaviour
{
    [SerializeField]
    private GameObject _bigObstacles,_smallObstacles,_rocket,_shield,_speedObject,_freeMoveObject;
    public float _bigObstacleDelay, _smallObstacleDelay, _bulletSpawnDelay;
    public float _shieldSpawnDelay = 10f;
    public float _speedSpawnDelay = 15f;
    public float _freeMoveSpawnDelay = 20f;

    void Start()
    {
        StartCoroutine(BigObstacles());
        StartCoroutine(SmallObstaclesSpawn());
        StartCoroutine(BulletSpawn());
        StartCoroutine(ShieldSpawn());
        StartCoroutine(PlayerBulletSpawn());
        StartCoroutine(FreeMoveSpawn());
    }

    IEnumerator BigObstacles()
    {
        while (true)
        {
            Vector2 bigPosSpawn = new Vector2(0f, 7.9f);
            Instantiate(_bigObstacles, bigPosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_bigObstacleDelay);
        }
    }
    
    IEnumerator SmallObstaclesSpawn()
    {
        yield return new WaitForSeconds(1.5f);
        while (true)
        {
            Vector2 smallPosSpawn = new Vector2(0f, 7f);
            Instantiate(_smallObstacles, smallPosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_smallObstacleDelay);
        }
    }

    IEnumerator BulletSpawn()
    {
        yield return new WaitForSeconds(7f);
        while (true)
        {
            Vector2 bulletPosSpawn = new Vector2(Random.Range(-2.5f, 2.5f), 15.44f);
            Instantiate(_rocket, bulletPosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_bulletSpawnDelay);
        }
    }

    IEnumerator ShieldSpawn()
    {
        yield return new WaitForSeconds(Random.Range(10,15));
        while (true)
        {
            Vector2 shieldposToSpawn = new Vector2(Random.Range(-2.25f, 2.25f), 5.5f);
            Instantiate(_shield, shieldposToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_shieldSpawnDelay);
        }
    }

    IEnumerator PlayerBulletSpawn()
    {
        yield return new WaitForSeconds(Random.Range(15, 20));
        while (true)
        {
            Vector2 playerBulletposToSpawn = new Vector2(Random.Range(-2.35f, 2.35f), 5.5f);
            Instantiate(_speedObject, playerBulletposToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_speedSpawnDelay);
        }
    }

    IEnumerator FreeMoveSpawn()
    {
        yield return new WaitForSeconds(Random.Range(25, 30));
        while (true)
        {
            Vector2 freeMoveposToSpawn = new Vector2(Random.Range(-2.35f, 2.35f), 5.5f);
            Instantiate(_freeMoveObject, freeMoveposToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(_freeMoveSpawnDelay);
        }
    }
}
