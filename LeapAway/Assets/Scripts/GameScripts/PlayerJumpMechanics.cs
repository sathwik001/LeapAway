using UnityEngine;
using DG.Tweening;
using System.Collections;
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
        }
    }

    public void OnLeftButtonClicked()
    {
        transform.DOPunchScale(new Vector3(0.05f, 0.05f, 0.05f), 0.1f);
        StartCoroutine(PlayerScaleBack());
        rb2D.velocity = new Vector2(0.0f, _jumpForce);
        rb2D.AddForce(new Vector2(-_directionForce, 0f));
        FindObjectOfType<AudioMaanger>().Play("PlayerJump");
    }

    public void OnRightButtonClicked()
    {
        transform.DOPunchScale(new Vector3(0.05f, 0.05f, 0.05f), 0.1f);
        StartCoroutine(PlayerScaleBack());
        rb2D.velocity = new Vector2(0.0f, _jumpForce);
        rb2D.AddForce(new Vector2(_directionForce,0f));
        FindObjectOfType<AudioMaanger>().Play("PlayerJump");
    }

    IEnumerator PlayerScaleBack()
    {
        while (true)
        {
            transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
            yield return new WaitForSeconds(10f);
        }
    }
}
