using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public Playermovement Movement;
   


    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Obstacle")

        {
         Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

            
             
        }

    }
}


