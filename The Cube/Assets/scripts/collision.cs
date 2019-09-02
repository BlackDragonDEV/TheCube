using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{   public moving movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            FindObjectOfType<GameManagerScript>().EndGame();
            movement.enabled = false;
        }
    }
}
