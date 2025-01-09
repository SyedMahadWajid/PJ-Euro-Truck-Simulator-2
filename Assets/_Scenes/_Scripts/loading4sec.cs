using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading4sec : MonoBehaviour
{
[SerializeField]
	string sceneName;

	void OnEnable ()
	{
		Time.timeScale = 1;
		StartCoroutine ("Loading");
	}

	IEnumerator Loading ()
	{
		yield return new WaitForSeconds (4f);
		SceneManager.LoadScene (sceneName);
	}
}
