using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMove movement;
    public manager manager;

    void OnCollisionEnter(Collision info)
    {
        if (info.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            manager.gameOver();
        }
    }
}
