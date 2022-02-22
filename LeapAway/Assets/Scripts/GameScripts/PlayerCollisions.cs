using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollisions : MonoBehaviour
{
    public bool isGameOver;
    public PlayerJumpMechanics _player;
    [SerializeField]
    private GameObject _shield;
    public ScoreIncrement _score;
    public GameObject _playerBullet;
    public bool isShooting,isfreeMoveActive,_isShieldActive;
    public Slider _bulletSpawnerSlider,_freeMoveSlider,_shieldSlider;
    private float _laserShootCount,_freeMoveCount,_shieldCount;

    private void Awake()
    {
        _shield.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            Time.timeScale = 0.25f;
            isGameOver = true;
        }

        if(other.tag == "Shield")
        {
            FindObjectOfType<AudioMaanger>().Play("CollectSound");
            _shieldCount = 7f;
            _shieldSlider.value = _shieldCount;
            Destroy(other.gameObject);
            _isShieldActive = true;
            _shield.SetActive(true);
            StartCoroutine(ShieldBool());
            StartCoroutine(RemoveShield());

        }

        if(other.tag == "PlayerBullets")
        {
            FindObjectOfType<AudioMaanger>().Play("CollectSound");
            _laserShootCount = 4f;
            _bulletSpawnerSlider.value = _laserShootCount;
            Destroy(other.gameObject);
            isShooting = true;
            StartCoroutine(BulletTrueBool());
            StartCoroutine(IsShootingOff());
        }

        if(other.tag == "FreeMove")
        {
            FindObjectOfType<AudioMaanger>().Play("CollectSound");
            _freeMoveCount = 7f;
            _freeMoveSlider.value = _freeMoveCount;
            Destroy(other.gameObject);
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            isfreeMoveActive = true;
            StartCoroutine(FreeMoveBool());
            StartCoroutine(RemoveFreeMove());

        }
    }

    IEnumerator BulletTrueBool()
    {
        while (isShooting)
        {
            Instantiate(_playerBullet, _player.transform.position, Quaternion.identity);
            FindObjectOfType<AudioMaanger>().Play("PlayerShoot");
            _laserShootCount -= 0.15f;
            _bulletSpawnerSlider.value = _laserShootCount;
            yield return new WaitForSeconds(0.15f);
        }
    }
    IEnumerator FreeMoveBool()
    {
        while (isfreeMoveActive)
        {
            FindObjectOfType<SmallObstacleSpawn>().transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 126);
            FindObjectOfType<SmallObstacleSpawn>().transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 126);
            FindObjectOfType<BigObstaclesSpawn>().transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 126);
            FindObjectOfType<BigObstaclesSpawn>().transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 126);
            _freeMoveCount -= 0.15f;
            _freeMoveSlider.value = _freeMoveCount;
            yield return new WaitForSeconds(0.15f);
        }
    }
    IEnumerator ShieldBool()
    {
        while (_isShieldActive)
        {
            _shieldCount -= 0.15f;
            _shieldSlider.value = _shieldCount;
            yield return new WaitForSeconds(0.15f);
        }
    }

    IEnumerator IsShootingOff()
    {
        yield return new WaitForSeconds(4.0f);
        isShooting = false;
    }

    IEnumerator RemoveShield()
    {
        yield return new WaitForSeconds(7.0f);
        _isShieldActive = false;
        _shieldCount = 0f;
        _shieldSlider.value = _shieldCount;
        _shield.SetActive(false);
    }

    IEnumerator RemoveFreeMove()
    {
        yield return new WaitForSeconds(7.0f);
        isfreeMoveActive = false;
        _freeMoveCount = 0f;
        _freeMoveSlider.value = _freeMoveCount;
        FindObjectOfType<SmallObstacleSpawn>().transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
        FindObjectOfType<SmallObstacleSpawn>().transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
        FindObjectOfType<BigObstaclesSpawn>().transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
        FindObjectOfType<BigObstaclesSpawn>().transform.GetChild(1).gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 255);
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }

}
