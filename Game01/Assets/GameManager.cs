using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool condition = false;
	public float restartDelay = 1f;
	public GameObject levelCompletePanel;

	public void LevelComplete() {
		//Debug.Log("Level Completed!");
		levelCompletePanel.SetActive(true);
	}

	public void EndGame () {
		if (condition == false){
			condition = true;
			Invoke("Restart", restartDelay);
		}		
	}
	
	// Update is called once per frame
	void Restart () {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
