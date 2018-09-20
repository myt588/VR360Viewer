using UnityEngine;
using System.Collections;

public class SetStage : MonoBehaviour {

	public void setStageName(string name)
	{
		GameConfig.stageName = name;
	}
}
