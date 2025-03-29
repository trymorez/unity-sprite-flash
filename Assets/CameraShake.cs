using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] Canvas canvas;

    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 origPos = transform.localPosition;
        Vector3 origCanvasPos = canvas.transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, origPos.z);
            canvas.transform.localPosition = new Vector3(x, y, origCanvasPos.z);

            elapsed += Time.deltaTime;
            yield return null;
        }

        transform.localPosition = origPos;
        canvas.transform.localPosition = origCanvasPos;
    }
}
