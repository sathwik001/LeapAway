using UnityEngine;

public class PlayerJumpMechanics : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float _directionForce = 75f;
    public float _jumpForce = 5f;
    public bool isGameOver;


    private void Awake()
    {
        Time.timeScale = 1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(0f, 0f);
        isGameOver = false;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position.y >= 4.7f)
        {
            transform.position = new Vector2(transform.position.x, 4.7f);
        }
        if(transform.position.x >= 2.56f)
        {
            transform.position = new Vector2(2.56f, transform.position.y);
        }
        if(transform.position.x <= -2.56f)
        {
            transform.position = new Vector2(-2.56f, transform.position.y);
        }

        if(transform.position.y <= -5.3)
        {
            Time.timeScale = 0.25f;
            isGameOver = true;
            Destroy(this.gameObject);
        }
    }

    public void OnLeftButtonClicked()
    {
        rb2D.velocity = new Vector2(0.0f, _jumpForce);
        rb2D.AddForce(new Vector2(-_directionForce, 0f));
        FindObjectOfType<AudioMaanger>().Play("PlayerJump");
    }

    public void OnRightButtonClicked()
    {
        rb2D.velocity = new Vector2(0.0f, _jumpForce);
        rb2D.AddForce(new Vector2(_directionForce,0f));
        FindObjectOfType<AudioMaanger>().Play("PlayerJump");
    }


}
