using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvelelovk2dmode : MonoBehaviour
{
    private void OnEnable()
    {
		if (MenuScene.trafiiclevel == 0)
		{
			PlayerPrefs.SetInt("l2d1", 1);
		}
		else if (MenuScene.trafiiclevel == 1)
		{
			PlayerPrefs.SetInt("l2d2", 1);
		}
		else if (MenuScene.trafiiclevel == 2)
		{
			PlayerPrefs.SetInt("l2d3", 1);
		}
		else if (MenuScene.trafiiclevel == 3)
		{
			PlayerPrefs.SetInt("l2d4", 1);
		}
		else if (MenuScene.trafiiclevel == 4)
		{
			PlayerPrefs.SetInt("l2d5", 1);
		}
		else if (MenuScene.trafiiclevel == 5)
		{
			PlayerPrefs.SetInt("l2d6", 1);
		}
		else if (MenuScene.trafiiclevel == 6)
		{
			PlayerPrefs.SetInt("l2d7", 1);
		}
		else if (MenuScene.trafiiclevel == 7)
		{
			PlayerPrefs.SetInt("l2d8", 1);
		}
		else if (MenuScene.trafiiclevel == 8)
		{
			PlayerPrefs.SetInt("l2d9", 1);
		}
		else if (MenuScene.trafiiclevel == 9)
		{
			PlayerPrefs.SetInt("l2d10", 1);
		}
		
	}
}
