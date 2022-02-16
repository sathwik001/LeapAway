using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigObstaclesSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform _rightObs, _leftObs;

    // Start is called before the first frame update
    void Start()
    {
        _rightObs.position = new Vector2(Random.Range(3.45f, 2.2f), 7.9f);
        _leftObs.position = new Vector2(Random.Range(-2.8f, -1.50f), 7.9f);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * 1.5f * Time.deltaTime);

        if(transform.position.y <= -5.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
