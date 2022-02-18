using UnityEngine;

public class DifficultManager : MonoBehaviour
{
    public SmallObstacleSpawn _smallObstacle;
    public BigObstaclesSpawn _bigObstacle;
    public ScoreIncrement _score;

    // Start is called before the first frame update
    void Start()
    {
        _score = GameObject.Find("ScoreIncrement").GetComponent<ScoreIncrement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_score._scorePoints >= 0 )
        {
            GameObject.Find("SmallObstacles").GetComponent<SmallObstacleSpawn>()._smallObstacleSpeed = 3f;
            GameObject.Find("BigObstacles").GetComponent<BigObstaclesSpawn>()._bigObstacleSpeed = 3f;
        }
    }
}
