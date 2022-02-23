using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraShake : MonoBehaviour
{
    public Camera cam;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Obstacle")
        {
            StartCoroutine(Shake(.1f, .02f));
        }
    }

    IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = cam.transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            cam.transform.localPosition = new Vector3(x, y,transform.position.z);

            elapsed += Time.deltaTime;
            yield return null;
        }
        cam.transform.localPosition = originalPos;
    }
}
