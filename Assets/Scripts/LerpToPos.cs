using UnityEngine;

public class LerpToPos : MonoBehaviour
{
    [HideInInspector] public Vector3 targetPos = Vector3.zero;
    public float smoothing = 0.05f;

    private void Start()
    {
        if(targetPos == Vector3.zero)
            targetPos = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
    }
}