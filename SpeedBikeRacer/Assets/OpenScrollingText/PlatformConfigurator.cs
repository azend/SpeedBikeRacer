using UnityEngine;
using System.Collections;

public class PlatformConfigurator : MonoBehaviour {

	public GameObject standardCamera;
	public GameObject diveCamera;

	// Use this for initialization
	void Start () {
#if UNITY_ANDROID
		ConfigureForDive();
#else
		ConfigureForStandard();
#endif
	}

	private void ConfigureForStandard() {
		DisableCamera (diveCamera);

	}
	
	private void ConfigureForDive() {
		DisableCamera (standardCamera);
	}

	private void DisableCamera(GameObject cameraObject) {
		Camera[] cameras = cameraObject.GetComponentsInChildren<Camera> ();
		foreach (Camera camera in cameras) {
			Debug.Log(camera.name);
			camera.enabled = false;
		}
	}
}
