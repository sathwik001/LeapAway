using UnityEngine;

public class ShieldBehaviour : MonoBehaviour
{
    public float _speed = 4f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);

        if(transform.position.y <= -5.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
