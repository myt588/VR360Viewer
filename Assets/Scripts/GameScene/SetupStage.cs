using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetupStage : MonoBehaviour {

	public Text A;
	public Text B;
	public Text C;
	public Text D;
	public Text stageText;
	// Use this for initialization
	void Awake () {
		setupScene ();
	}

	public void setupScene() {
		Material mat = Resources.Load(GameConfig.stageName + "/Stage" + GameConfig.currentStage.ToString(), typeof(Material)) as Material;
		RenderSettings.skybox = mat;
//		Debug.Log (GameConfig.currentStage);
		stageText.text = GameConfig.currentStage.ToString () + "/" + (GameConfig.stages_tokyo.Length / 5 - 1).ToString();
		A.text = GameConfig.stages_tokyo [GameConfig.currentStage, 1];
		B.text = GameConfig.stages_tokyo [GameConfig.currentStage, 2];
		C.text = GameConfig.stages_tokyo [GameConfig.currentStage, 3];
		D.text = GameConfig.stages_tokyo [GameConfig.currentStage, 4];
	}

}
