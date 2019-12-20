using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

	void OnCollisionEnter()
    {
        Debug.Log("Hit Something.");
    }
}
