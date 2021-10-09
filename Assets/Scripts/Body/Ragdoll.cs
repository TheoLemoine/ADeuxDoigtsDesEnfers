using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll : MonoBehaviour
{
    private Vector2 defaultPosition;
    bool isDoingRagdoll = false;
    public void DoRagdoll()
    {
        if (isDoingRagdoll) return;
        isDoingRagdoll = true;
        defaultPosition = transform.position;
        gameObject.SetActive(true);
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(1 * Random.Range(-1.0f, 1.0f), 1);
        StartCoroutine("DoingRagdoll");
    }

    public void UndoRagdoll()
    {
        if (!isDoingRagdoll) return;
        isDoingRagdoll = false;
        transform.position = defaultPosition;
        gameObject.SetActive(false);

    }

    private IEnumerator DoingRagdoll()
    {
        float timer = 0;
        // Init.
        while (timer < 3)
        { // Clock.
            timer += Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
        UndoRagdoll();
    }
}
