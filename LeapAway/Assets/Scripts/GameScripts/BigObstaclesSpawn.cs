using UnityEngine;

public class BigObstaclesSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform _rightObs, _leftObs;
    public float _bigObstacleSpeed = 2f;
    //private Vector2 _screenBounds;
    //public ScoreIncrement _score;

    void Start()
    {

        _rightObs.position = new Vector2(Random.Range(3.45f, 2.2f), 7.9f);
        _leftObs.position = new Vector2(Random.Range(-2.8f, -1.50f), 7.9f);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * _bigObstacleSpeed * Time.deltaTime);

        if (transform.position.y <= -7.25f)
        {
            Destroy(this.gameObject);
        }
        //_screenBounds = Camera.main.WorldToScreenPoint(transform.position);
        //if(_screenBounds.y * 5  < 0)
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
