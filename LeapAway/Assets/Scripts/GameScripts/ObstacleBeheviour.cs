using UnityEngine;

public class ObstacleBeheviour : MonoBehaviour
{
    public PlayerJumpMechanics _player;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<PlayerJumpMechanics>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.isTouched)
        {
            transform.Translate(Vector2.down * 3f * Time.deltaTime);
            _player.isTouched = false;
        }
        if(transform.position.y <= -15f)
        {
            Destroy(this.gameObject);
        }
    }
}
