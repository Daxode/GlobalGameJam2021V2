using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Uwu : MonoBehaviour {
	public RenderPipelineAsset exampleAssetA;
	public RenderPipelineAsset exampleAssetB;

	void Update() {
		if (Input.GetKeyDown(KeyCode.A)) {
			GraphicsSettings.renderPipelineAsset = exampleAssetA;
			Debug.Log("Active render pipeline asset is: " + GraphicsSettings.renderPipelineAsset.name);
		}
		else if (Input.GetKeyDown(KeyCode.B)) {
			GraphicsSettings.renderPipelineAsset = exampleAssetB;
			Debug.Log("Active render pipeline asset is: " + GraphicsSettings.renderPipelineAsset.name);
		}
	}
}