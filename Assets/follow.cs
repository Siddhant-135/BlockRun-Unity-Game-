using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform player;
    void Update()
    {
        transform.position = new Vector3(player.position.x - 10, player.position.y +5, player.position.z * 0.7f);
    }
}
