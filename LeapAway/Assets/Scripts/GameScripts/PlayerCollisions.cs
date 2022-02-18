using UnityEngine;
using System.Collections;

public class PlayerCollisions : MonoBehaviour
{
    public bool isGameOver;
    public PlayerJumpMechanics _player;
    [SerializeField]
    private GameObject _shield;
    public ScoreIncrement _score;

    private void Awake()
    {
        _shield.SetActive(false);    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            Time.timeScale = 0.25f;
            isGameOver = true;
        }

        if(other.tag == "Shield")
        {
            Destroy(other.gameObject);
            _shield.SetActive(true);
            StartCoroutine(RemoveShield());
        }

        if(other.tag == "Speed")
        {
            Destroy(other.gameObject);
            _score._speed = 10f;
            StartCoroutine(ResetSpeedTimeScale());
        }

        if(other.tag == "FreeMove")
        {
            Destroy(other.gameObject);
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            StartCoroutine(RemoveFreeMove());
            
        }
    }

    IEnumerator ResetSpeedTimeScale()
    {
        yield return new WaitForSeconds(7.0f);
        _score._speed = 3f;
    }

    IEnumerator RemoveShield()
    {
        yield return new WaitForSeconds(7.0f);
        _shield.SetActive(false);
    }

    IEnumerator RemoveFreeMove()
    {
        yield return new WaitForSeconds(7.0f);
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }

}
