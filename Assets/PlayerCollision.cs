using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            Debug.Log("We hit an obstacle");
            movement.enabled = false;
        }
    }
}
