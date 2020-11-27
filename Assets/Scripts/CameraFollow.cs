using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject player = default;
    [SerializeField] float minimumXPosition = 8f;
    [SerializeField] float offsetToPlayer = 3f;

    void Update()
    {
        if (player)
        {
            float x = player.transform.position.x + offsetToPlayer;
            if (x < minimumXPosition)
            {
                x = minimumXPosition;
            }
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
        }
    }
}
