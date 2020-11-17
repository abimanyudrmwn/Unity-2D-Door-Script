using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneDoorChange : MonoBehaviour
{
    public int LevelToLoad; // Var Integer untuk Load Level 1 pada Game
	private int currentSceneIndex; // Untuk mengetahui Index Scene
	
	void Start()
	{
		
	}
	
	void OnTriggerEnter2D(Collider2D col) // Ketika Player Menyentuh Collider 2D Dalam Game
	{
		if (col.CompareTag("Player")) // Handler untuk mengetahui Collider Player
		{
				currentSceneIndex = SceneManager.GetActiveScene().buildIndex; // Detect Scene yang ada
				PlayerPrefs.SetInt("SavedScene", currentSceneIndex); // Scene di Save
				SceneManager.LoadScene(LevelToLoad); // Lalu Scene akan berpindah ke Level 1
		}
	}	
	
}