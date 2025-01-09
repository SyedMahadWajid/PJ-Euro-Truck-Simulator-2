using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelbar : MonoBehaviour {
	Image healthBar;
	float maxhealth=100f;
	public static float health;
	public static float Gethealth;
	
	void Start () {
		healthBar = GetComponent<Image> ();
		health = maxhealth;
	}

	void Update () {
		healthBar.fillAmount = health / maxhealth;
		if(ControlButton.fuelfull){
			if(healthBar.fillAmount<=1){
				ControlButton.Instance.fuelclose();
				if(health>=100){
					//ControlButton.Instance.fuelclose();
					AudioListener.volume = 1.0f;
					ControlButton.fuelfull=false;
				}
				else{
					health += 1.0f;
				}
			}
		}
		if(healthBar.fillAmount <= 0.05){
			AudioListener.volume = 0.0f;
			ControlButton.Instance.fuel();
		}
		else if(ControlButton.fuelfull == false){
			health -= 0.001f;
		}
	}
}

