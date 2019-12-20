using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour
{

    public PlayerMovement script;
    public Score score;
    public bool alive = false;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            script.enabled = false;
            score.setStillPlaying(ref alive);
        }
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Environment")
        {
            score.setStillPlaying(ref alive);
        }
    }
}