using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBreakBehaviour : MonoBehaviour
{
    public ParticleSystem _particles;

    private void Start()
    {
        _particles.Stop();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "PlayerLaser")
        {
            Destroy(other.gameObject);
            StartCoroutine(BreakObstacle());
        }
    }

    IEnumerator BreakObstacle()
    {
        _particles.Play();
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(_particles.main.startLifetime.constantMax);
        Destroy(this.gameObject);
    }
}
