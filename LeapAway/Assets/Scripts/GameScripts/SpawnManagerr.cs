using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerr : MonoBehaviour
{
    [SerializeField]
    private GameObject _obstacles, _obstacles2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Obstacles());
        StartCoroutine(Obstacles2());
    }

    IEnumerator Obstacles()
    {
        while (true)
        {
            Vector2 drosSpawn = new Vector2(0f, 0f);
            Instantiate(_obstacles, drosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
    IEnumerator Obstacles2()
    {
        while (true)
        {
            Vector2 drosSpawn = new Vector2(0f, 5f);
            Instantiate(_obstacles2, drosSpawn, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
