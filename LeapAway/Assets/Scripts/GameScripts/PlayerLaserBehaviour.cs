using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaserBehaviour : MonoBehaviour
{
    private float _speed = 4f;
    public Transform _player;

    private void Awake()
    {
        _player = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Start()
    {
        transform.position = _player.position;
    }

    void Update()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
        if(transform.position.y >= 5.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
