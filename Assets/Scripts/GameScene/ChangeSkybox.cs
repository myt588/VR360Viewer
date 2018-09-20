using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeSkybox : MonoBehaviour {

	public SetupStage setup;
	public void changeSkybox() {
		GameConfig.currentStage += 1;
		if (GameConfig.currentStage > GameConfig.stages_tokyo.Length / 5 - 1) {
			SceneManager.LoadScene (3); 
		} else {
//			Material mat = Resources.Load("/Stage Nature/Stage" + GameConfig.currentStage.ToString(), typeof(Material)) as Material;
//			RenderSettings.skybox = mat;
			setup.setupScene ();
		}
	}
}
