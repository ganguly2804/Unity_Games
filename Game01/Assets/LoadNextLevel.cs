﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour {

	public void LoadLevel() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
