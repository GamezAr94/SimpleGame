using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public bool stillPlaying;
	public Text scoreText;
	
	void Start()
    {
		stillPlaying = true;
    }
	// Update is called once per frame
	void Update () {
		if(stillPlaying)
		scoreText.text = player.position.z.ToString("0");
	}

	public void setStillPlaying(ref bool playing)
    {
		stillPlaying = playing;
	}
	

}
