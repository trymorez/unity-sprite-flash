using System.Collections;
using UnityEngine;

public class SpriteShake : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 origPos = transform.position;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.position = new Vector3(origPos.x + x, origPos.y + y, origPos.z);

            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = origPos;
    }
}
