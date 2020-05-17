using UnityEngine;

public class LevelComplete : MonoBehaviour {

	void OnTriggerEnter(Collider collisionInfo) {
		if (collisionInfo.GetComponent<Collider>().name == "Player") {
			FindObjectOfType<GameManager>().LevelComplete();	
		}	
	}
}
