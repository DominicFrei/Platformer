using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab = default;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals(enemyPrefab.gameObject.name))
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            StartCoroutine(ResetPlayerPosition());
        }
    }

    IEnumerator ResetPlayerPosition()
    {
        yield return new WaitForSeconds(2f);
        transform.position = Vector3.zero;
        gameObject.GetComponent<Renderer>().enabled = true;
    }

}
