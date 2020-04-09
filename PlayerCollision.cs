using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collisionInfo)
    {   
        if (collisionInfo.collider.tag =="Obstacle") {

            //Debug.Log("we hit cube");

            movement.enabled = false;

            FindObjectOfType<GameManager>().GameOver();

        }
    }
    
}
