using UnityEngine;
using UnityEngine.UI;

public class ShieldCircle : MonoBehaviour
{
    public GameObject _player;
    public Slider _slider;

    private void Update()
    {
        transform.position = _player.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            _slider.value = 0;
            Destroy(other.gameObject);
            gameObject.SetActive(false);
        }
    }
}
