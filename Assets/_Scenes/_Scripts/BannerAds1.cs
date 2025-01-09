using UnityEngine;
using System.Collections;

public class BannerAds1 : MonoBehaviour 
{
	public GameObject pausebtn;
	void OnEnable () {
		/*if(AdsManager.instance)
		{
			if(AdManager.ram_ok)
            {
				AdsManager.instance.showAdMobRectangleBannerBottomLeft();
				AdManager.Instance.ShowInterstitial();
			}
		}*/
		pausebtn.SetActive(false);
	}
}
