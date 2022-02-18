using UnityEngine;
using TMPro;

public class ScoreIncrement : MonoBehaviour
{
    public float _speed = 3f;
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    public int _scorePoints;

    // Start is called before the first frame update
    void Start()
    {
        _scorePoints = 0;
        _scoreText.text = "Score : " + _scorePoints;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
        _scorePoints = ((int)transform.position.y);
        _scoreText.text = "Score : " + _scorePoints;
    }
}
