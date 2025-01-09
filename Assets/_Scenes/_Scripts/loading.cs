using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
[SerializeField]
	string sceneName;

	void OnEnable ()
	{
		Time.timeScale = 1;
		StartCoroutine ("Loading");
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}

	IEnumerator Loading ()
	{
		yield return new WaitForSeconds (6f);
		SceneManager.LoadScene (sceneName);
	}
}
