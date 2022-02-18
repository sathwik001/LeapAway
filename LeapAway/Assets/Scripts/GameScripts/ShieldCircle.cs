using UnityEngine;

public class ShieldCircle : MonoBehaviour
{
    public GameObject _player;

    private void Update()
    {
        transform.position = _player.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);

        }
    }
}
