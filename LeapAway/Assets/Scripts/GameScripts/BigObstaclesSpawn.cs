using UnityEngine;

public class BigObstaclesSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform _rightObs, _leftObs;
    public float _bigObstacleSpeed = 2f;
    //public ScoreIncrement _score;

    private void Awake()
    {
        //_score = GameObject.Find("ScoreIncrement").GetComponent<ScoreIncrement>();
    }

    void Start()
    {

        _rightObs.position = new Vector2(Random.Range(3.45f, 2.2f), 7.9f);
        _leftObs.position = new Vector2(Random.Range(-2.8f, -1.50f), 7.9f);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * _bigObstacleSpeed * Time.deltaTime);

        if(transform.position.y <= -7.25f)
        {
            Destroy(this.gameObject);
        }
        //if (_score._scorePoints >= 0)
        //{
        //    _bigObstacleSpeed = 3f;
        //}
    }
}
