using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Transform player;
	public Vector3 positionOffset;

	
	
	// Update is called once per frame
	void Update () {
		transform.position = player.position - positionOffset;
	}
}
