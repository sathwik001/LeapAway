using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallObstacleSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform _topObs, _downObs;

    // Start is called before the first frame update
    void Start()
    {
        _topObs.position = new Vector2(Random.Range(-0.8f, 1.1f), 8.8f);
        _downObs.position = new Vector2(Random.Range(-0.8f, 1.1f), 7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * 1.5f * Time.deltaTime);

        if(transform.position.y <= -7.11f)
        {
            Destroy(this.gameObject);
        }
    }
}
