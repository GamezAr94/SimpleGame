using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour
{

    public PlayerMovement script;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            script.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}