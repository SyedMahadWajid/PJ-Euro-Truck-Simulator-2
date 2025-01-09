using UnityEngine;
using System.Collections;

public class LevelLock : MonoBehaviour {


	void OnEnable () {
        	//print(PlayerPrefs.GetInt ("levels"));
            if(MenuScene.LevelNo==0){
		     PlayerPrefs.SetInt("l1",1);
	         }
			else if(MenuScene.LevelNo==1){
		     PlayerPrefs.SetInt("l2",1);
	         }
            else if(MenuScene.LevelNo==2){
		     PlayerPrefs.SetInt("l3",1);
	         }
			else if(MenuScene.LevelNo==3){
		     PlayerPrefs.SetInt("l4",1);
	         }
            else if(MenuScene.LevelNo==4){
		     PlayerPrefs.SetInt("l5",1);
	         }
			else if(MenuScene.LevelNo==5){
		     PlayerPrefs.SetInt("l6",1);
	         }
            else if(MenuScene.LevelNo==6){
		     PlayerPrefs.SetInt("l7",1);
	         }
			else if(MenuScene.LevelNo==7){
		     PlayerPrefs.SetInt("l8",1);
	         }
            else if(MenuScene.LevelNo==8){
		     PlayerPrefs.SetInt("l9",1);
	        }
            else if(MenuScene.LevelNo==9){
		     PlayerPrefs.SetInt("l10",1);
	        }
			else if(MenuScene.LevelNo==10){
		     PlayerPrefs.SetInt("l11",1);
	        }
			else if(MenuScene.LevelNo==11){
		     PlayerPrefs.SetInt("l12",1);
	        }
			else if(MenuScene.LevelNo==12){
		     PlayerPrefs.SetInt("l13",1);
	        }
		else if(MenuScene.LevelNo==13){
		     PlayerPrefs.SetInt("l14",1);
	        }
		else if (MenuScene.LevelNo == 14)
		{
			PlayerPrefs.SetInt("l15", 1);
		}
		else if (MenuScene.LevelNo == 15)
		{
			PlayerPrefs.SetInt("l16", 1);
		}
		else if (MenuScene.LevelNo == 16)
		{
			PlayerPrefs.SetInt("l17", 1);
		}
		else if (MenuScene.LevelNo == 17)
		{
			PlayerPrefs.SetInt("l18", 1);
		}
		else if (MenuScene.LevelNo == 18)
		{
			PlayerPrefs.SetInt("l19", 1);
		}
		else if (MenuScene.LevelNo == 19)
		{
			PlayerPrefs.SetInt("l20", 1);
		}
		else if (MenuScene.LevelNo == 20)
		{
			PlayerPrefs.SetInt("l21", 1);
		}
		else if (MenuScene.LevelNo == 21)
		{
			PlayerPrefs.SetInt("l22", 1);
		}
		else if (MenuScene.LevelNo == 22)
		{
			PlayerPrefs.SetInt("l23", 1);
		}
		else if (MenuScene.LevelNo == 23)
		{
			PlayerPrefs.SetInt("l24", 1);
		}
		else if (MenuScene.LevelNo == 24)
		{
			PlayerPrefs.SetInt("l25", 1);
		}
		else if (MenuScene.LevelNo == 25)
		{
			PlayerPrefs.SetInt("l26", 1);
		}
		else if (MenuScene.LevelNo == 26)
		{
			PlayerPrefs.SetInt("l27", 1);
		}
		else if (MenuScene.LevelNo == 27)
		{
			PlayerPrefs.SetInt("l28", 1);
		}
		else if (MenuScene.LevelNo == 28)
		{
			PlayerPrefs.SetInt("l29", 1);
		}
		else if (MenuScene.LevelNo == 29)
		{
			PlayerPrefs.SetInt("l30", 1);
		}
	}

}
