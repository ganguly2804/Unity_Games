using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour {

	public void StartGameFunction() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
}
