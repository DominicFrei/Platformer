using UnityEngine;

public class PlatformMovePlayer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(transform);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }
}
