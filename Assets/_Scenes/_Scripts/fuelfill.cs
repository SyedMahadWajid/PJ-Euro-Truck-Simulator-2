using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelfill : MonoBehaviour
{
	Image healthBar;
	// float maxhealth=100f;
	// float health;
	// public GameObject fuelpnl;

	void OnEnable(){
		healthBar = GetComponent<Image> ();
		healthBar.fillAmount=fuelbar.Gethealth;
	}

	void Update () {
		if(ControlButton.fuelfull){
			print("kkkk");
			print(fuelbar.Gethealth);
			fuelbar.Gethealth += 0.4f;
			healthBar.fillAmount =fuelbar.Gethealth;
		}
		if(healthBar.fillAmount>=1){
			ControlButton.Instance.fuelclose();
		}
		// healthBar.fillAmount = health / maxhealth;
		// health += 0.4f;

	}
}
