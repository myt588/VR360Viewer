using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnToMain : MonoBehaviour {

	public void returnToMain()
	{
		GameConfig.sceneTracker = 1;
		GameConfig.currentStage = 1;
		SceneManager.LoadScene (0); 
	}
}
