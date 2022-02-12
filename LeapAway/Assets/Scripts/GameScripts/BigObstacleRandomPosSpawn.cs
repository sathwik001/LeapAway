using UnityEngine;

public class BigObstacleRandomPosSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform _obstacle1,_obstacle2,_leftObstacleUp,_rightObstacleUp, _leftObstacleDown, _rightObstacleDown;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0f, 17.05f);
        _leftObstacleUp.position = new Vector2(Random.Range(-1.75f, -3.25f), 10.3f);
        _rightObstacleUp.position = new Vector2(Random.Range(2.75f, 4.1f), 10.3f);
        _leftObstacleDown.position = new Vector2(Random.Range(-1.75f, -3.25f),5.3f);
        _rightObstacleDown.position = new Vector2(Random.Range(2.75f, 4.1f), 5.3f);

        _obstacle1.position = new Vector2(Random.Range(-1.5f, 1.5f),9.09f);
        _obstacle2.position = new Vector2(Random.Range(-1.5f, 1.5f),6.6f);
    }

}
