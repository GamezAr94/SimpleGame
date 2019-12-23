using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	bool gameHasEnded = false;
	public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("You Won!");
        completeLevelUI.SetActive(true);
    }
	public void EndGame()
    {
    	if(gameHasEnded == false){
    		if(gameHasEnded == false){
    			gameHasEnded = true;
        		Debug.Log("GameOver");
    		}
    	}
        Invoke("Restart",restartDelay);
    }

    void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	
}
