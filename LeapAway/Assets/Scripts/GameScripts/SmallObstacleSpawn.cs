using UnityEngine;

public class SmallObstacleSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform _topObs, _downObs;
    public float _smallObstacleSpeed = 2f;


    void Start()
    {
        _topObs.position = new Vector2(Random.Range(-0.8f, 1.1f), 8.8f);
        _downObs.position = new Vector2(Random.Range(-0.8f, 1.1f), 7f);
    }

    void Update()
    {
        transform.Translate(Vector2.down * _smallObstacleSpeed * Time.deltaTime);

        if(transform.position.y <= -9.11f)
        {
            Destroy(this.gameObject);
        }
    }
}
