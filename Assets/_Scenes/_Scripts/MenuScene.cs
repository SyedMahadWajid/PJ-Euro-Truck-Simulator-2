using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MenuScene : MonoBehaviour
{
   
    [Header("properties of gamobjects")]
   
    public GameObject[] cams, Panels, bg, qualitytext, Qlines, Shlines, shadowtext, cameratxt, cameralines, lvlimg, levellock, selectimg;
    
    public GameObject Startscene, MainCam, SkipBtn, musicstopbtn, musicplaybtn, storescene, Menuscene, coinbar;
    
    public static int LevelNo, camfar, controlNumber, trafiiclevel;
    
    int carNumber, shadowNumber;
   // [HideInInspector]
    public Text TotalCoins;
   
    public Light light;
   
    public AudioSource musicplay;
   
    int musicL = 0;
   
    [Header("properties of misics")]
    public AudioClip[] audios;
    
    public static bool resetall;
    void Start()
    {
        
        TotalCoins.text = PlayerPrefs.GetInt("coins").ToString("120000");
       
        //PlayerPrefs.DeleteAll();
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Time.timeScale = 1;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        
        if (PlayerPrefs.GetInt("startscene") == 1)
        {
            Menuscene.SetActive(false);
            Panels[1].SetActive(true);
            Panels[12].SetActive(false);
        }
        
        
        if (PlayerPrefs.GetInt("privacy") == 1)
        {
            Panels[12].SetActive(false);
        }
       
        if (resetall)
        {
            MainCam.SetActive(true);
            Panels[4].SetActive(true);
            if (PlayerPrefs.GetInt("start") == 1)
            {
                Menuscene.SetActive(false);
            }
            PlayerPrefs.SetInt("start", 0);
            Menuscene.SetActive(false);
            resetall = false;

        }
        if (ControlButton.main)
        {
            coinbar.SetActive(true);
            Panels[1].SetActive(true);
            MainCam.SetActive(true);
            ControlButton.main = false;
        }
        //else
        //{
           
        //}
        carNumber = 0;
        controlNumber = 1;
        //if (PlayerPrefs.GetInt("once") == 0)
        //{
        //    PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 10000);
        //    PlayerPrefs.SetInt("once", 1);
        //}
        if (SystemInfo.systemMemorySize > 5120)
        {
            camfar = 3;
            QualitySettings.SetQualityLevel(2, true);
        }
        if (SystemInfo.systemMemorySize > 3072)
        {
            camfar = 2;
            QualitySettings.SetQualityLevel(2, true);
        }
        if (SystemInfo.systemMemorySize > 2050 && SystemInfo.systemMemorySize < 3072)
        {
            camfar = 1;
            QualitySettings.SetQualityLevel(1, true);
        }
        if (SystemInfo.systemMemorySize < 2050)
        {
           camfar = 0;
            QualitySettings.SetQualityLevel(0, true);
        }
        //////////////////////////////////////////////////////
        if (PlayerPrefs.GetInt("l1") == 1)
        {
            levellock[0].SetActive(false);
            selectimg[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2") == 1)
        {
            levellock[1].SetActive(false);
            selectimg[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l3") == 1)
        {
            levellock[2].SetActive(false);
            selectimg[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l4") == 1)
        {
            levellock[3].SetActive(false);
            selectimg[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l5") == 1)
        {
            levellock[4].SetActive(false);
            selectimg[4].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l6") == 1)
        {
            levellock[5].SetActive(false);
            selectimg[5].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l7") == 1)
        {
            levellock[6].SetActive(false);
            selectimg[6].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l8") == 1)
        {
            levellock[7].SetActive(false);
            selectimg[7].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l9") == 1)
        {
            levellock[8].SetActive(false);
            selectimg[8].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l10") == 1)
        {
            levellock[9].SetActive(false);
            selectimg[9].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l11") == 1)
        {
            levellock[10].SetActive(false);
            selectimg[10].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l12") == 1)
        {
            levellock[11].SetActive(false);
            selectimg[11].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l13") == 1)
        {
            levellock[12].SetActive(false);
            selectimg[12].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l14") == 1)
        {
            levellock[13].SetActive(false);
            selectimg[13].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l15") == 1)
        {
            levellock[14].SetActive(false);
            selectimg[14].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l16") == 1)
        {
            levellock[15].SetActive(false);
            selectimg[15].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l17") == 1)
        {
            levellock[16].SetActive(false);
            selectimg[16].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l18") == 1)
        {
            levellock[17].SetActive(false);
            selectimg[17].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l19") == 1)
        {
            levellock[18].SetActive(false);
            selectimg[18].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l20") == 1)
        {
            //levellock[19].SetActive(false);
            selectimg[19].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l21") == 1)
        {
            levellock[20].SetActive(false);
            selectimg[20].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l22") == 1)
        {
            levellock[21].SetActive(false);
            selectimg[21].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l23") == 1)
        {
            levellock[22].SetActive(false);
            selectimg[22].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l24") == 1)
        {
            levellock[23].SetActive(false);
            selectimg[23].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l25") == 1)
        {
            levellock[24].SetActive(false);
            selectimg[24].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l26") == 1)
        {
            levellock[25].SetActive(false);
            selectimg[25].SetActive(false);

        }
        if (PlayerPrefs.GetInt("l27") == 1)
        {
            levellock[26].SetActive(false);
            selectimg[26].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l28") == 1)
        {
            levellock[27].SetActive(false);
            selectimg[27].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l29") == 1)
        {
            levellock[28].SetActive(false);
            selectimg[28].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l30") == 1)
        {
            //levellock[29].SetActive(false);
            selectimg[29].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d1") == 1)
        {
            levellock[30].SetActive(false);
            selectimg[30].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d2") == 1)
        {
            levellock[31].SetActive(false);
            selectimg[31].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d3") == 1)
        {
            levellock[32].SetActive(false);
            selectimg[32].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d4") == 1)
        {
            levellock[33].SetActive(false);
            selectimg[33].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d5") == 1)
        {
            levellock[34].SetActive(false);
            selectimg[34].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d6") == 1)
        {
            levellock[35].SetActive(false);
            selectimg[35].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d7") == 1)
        {
            levellock[36].SetActive(false);
            selectimg[36].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d8") == 1)
        {
            levellock[37].SetActive(false);
            selectimg[37].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d9") == 1)
        {
            levellock[38].SetActive(false);
            selectimg[38].SetActive(false);
        }
        if (PlayerPrefs.GetInt("l2d10") == 1)
        {
            selectimg[39].SetActive(false);
            levellock[39].SetActive(false);
        }

        /*if (AdManager.ram_ok)
        {
            if (AdManager.ram_ok)
            {
                AdsManager.instance.showAdMobBannerTopLeft();
                AdsManager.instance.showAdMobBannerTopRight();
                AdsManager.instance.hideAdmobTopBanner();
            }
        }*/
    }
    public void privacy()
    {
        PlayerPrefs.SetInt("privacy", 1);
        {
            Panels[12].SetActive(false);
            StartCoroutine("camcall");
        }
    }
    void Update()
    {
        TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
        
        if(shadowNumber==0)
          {
            PlayerPrefs.SetInt("shadow", 0);
           light.shadows = LightShadows.Soft;
          }
          if(shadowNumber==1)
          {
              PlayerPrefs.SetInt("shadow", 1);
            light.shadows = LightShadows.Hard;
          }
          if(shadowNumber==2)
          {
            PlayerPrefs.SetInt("shadow", 2);
            light.shadows = LightShadows.None;
          }
        if (Input.GetKeyDown(KeyCode.Insert))
        {
            SceneManager.LoadScene(2);
        }
    }
    IEnumerator camcall ()
	{
        cams[0].SetActive(true);
        yield return new WaitForSeconds (3.0f);
        SkipBtn.SetActive(true);
		yield return new WaitForSeconds (10.0f);
        Panels[0].SetActive(true);
        yield return new WaitForSeconds (2.0f);
        cams[0].SetActive(false);
        cams[1].SetActive(true);
        yield return new WaitForSeconds (5.0f);
        Panels[0].SetActive(false);
        yield return new WaitForSeconds (0.1f);
        SkipBtn.SetActive(false);
        Panels[1].SetActive(true);
        cams[1].SetActive(false);
        MainCam.SetActive(true);
        if(PlayerPrefs.GetInt("profile")==0)
        {
            Panels[6].SetActive(true); 
            PlayerPrefs.SetInt("profile",1);
        }
         coinbar.SetActive(true);
	}
    public void ButtonFunction(string ButtonName)
	{
		if(ButtonName=="skip")
		{
            SkipBtn.SetActive(false);
            Startscene.SetActive(false);
            cams[0].SetActive(true);
            cams[1].SetActive(true);
            MainCam.SetActive(true);
            Panels[0].SetActive(false);
            if(PlayerPrefs.GetInt("profile")==0)
        {
            Panels[6].SetActive(true); 
            PlayerPrefs.SetInt("profile",1);
        }
        
        else{
            Panels[1].SetActive(true);
        }
         coinbar.SetActive(true);
            StopCoroutine("camcall");
        }
       if(ButtonName=="play")
		{
            Panels[9].SetActive(true);
            Panels[1].SetActive(false);
            coinbar.SetActive(true);
            storescene.SetActive(true);
            Menuscene.SetActive(false);
            PlayerPrefs.SetInt("startscene", 1);
            {
                Menuscene.SetActive(false);
            }
        }
        if(ButtonName=="LEVELBACK")
		{
            Panels[9].SetActive(true);
            Panels[2].SetActive(false);
            storescene.SetActive(true);
            Menuscene.SetActive(false);
            coinbar.SetActive(true);
            /*if(AdsManager.instance)
            {
                if(AdManager.ram_ok)
                {
                    AdsManager.instance.hideAdmobBottomLeftBanner();
                    AdsManager.instance.hideAdmobBottomRightBanner();
                }  
            }*/
        }
        if(ButtonName=="profileback")
		{
            Panels[1].SetActive(true);
            Panels[6].SetActive(false);
        }
         if(ButtonName=="profile")
		{
            Panels[1].SetActive(false);
            Panels[6].SetActive(true);
        }
        if(ButtonName=="settings")
		{
            Panels[4].SetActive(true);
            Panels[1].SetActive(false);
            coinbar.SetActive(false);
           /*if(AdsManager.instance)
           {
                if(AdManager.ram_ok)
                {
                    AdsManager.instance.hideAdmobTopLeftBanner();
                    AdsManager.instance.hideAdmobTopRightBanner();
                }
		    }*/
        }
        if(ButtonName=="settingback")
		{
            Panels[1].SetActive(true);
            Panels[4].SetActive(false);
            coinbar.SetActive(true);
           /*if(AdsManager.instance)
           {
                if(AdManager.ram_ok)
                {
                    AdsManager.instance.showAdMobBannerTopLeft();
                    AdsManager.instance.showAdMobBannerTopRight();
                }
		   }*/
        }
        if(ButtonName=="jobback")
		{
            Panels[2].SetActive(true);
            Panels[8].SetActive(false);
          /*if(AdsManager.instance)
          {
                if(AdManager.ram_ok)
                {
                    AdsManager.instance.hideAdmobBottomLeftBanner();
                    AdsManager.instance.hideAdmobBottomRightBanner();
                }
		    }*/
        }
        if(ButtonName=="storeback")
		{
            Panels[1].SetActive(true);
            Panels[9].SetActive(false);
            storescene.SetActive(false);
            Menuscene.SetActive(false);
            coinbar.SetActive(true);

        }
        if(ButtonName == "musicpuse")
        {
            musicplay.Stop();
            musicstopbtn.SetActive(true);
            musicplaybtn.SetActive(false);
        }
        if(ButtonName == "musicresume")
        {
            musicplay.Play();
            musicstopbtn.SetActive(false);
            musicplaybtn.SetActive(true);
        }
        if(ButtonName == "nextmusic")
        {
            if(musicL == audios.Length-1){
            }
            else{
                musicL++;
                musicplay.clip = audios[musicL];
                musicplay.Play();
            }
        }
        if(ButtonName == "previousmusic")
        {
            if(musicL == 0){
            }
            else{
                musicL--;
                musicplay.clip = audios[musicL];
                musicplay.Play();
            }
        }
        if(ButtonName == "rate"){
			Application.OpenURL ("https://play.google.com/store/apps/details?id=com.rs.euro.truck.simulator.driving.game.free");
		}
        if(ButtonName == "pp"){
			Application.OpenURL ("http://royalgamers17.blogspot.com/2018/09/privacy-policy-contents.html#more");
		}
		if(ButtonName == "AD"){
			Application.OpenURL ("https://play.google.com/store/apps/details?id=com.aps.extreme.gt.car.stunt.driving.games&hl=en");
		}
		if(ButtonName == "more"){
			Application.OpenURL ("https://play.google.com/store/apps/dev?id=8509087224415485371");
		}
    } 
    public void Open_URL(string link) {
        Application.OpenURL(link);
    }   
    public void LevelFunction(int LevelName)
    {
        LevelNo=LevelName;
        foreach(GameObject levelsimg in lvlimg){
          //levelsimg.SetActive(false);
        }
        //lvlimg[LevelNo].SetActive(true);
	}
    public void Levelselection(int Lvl)
    {
       trafiiclevel = Lvl;
        //foreach (GameObject levelsimg in lvlimg)
        //{
        //    levelsimg.SetActive(false);
        //}
        StartCoroutine(Delay());
       
    }
    IEnumerator Delay()
    {
       Screen.orientation = ScreenOrientation.Portrait;
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("trafficmode1");
    }
    public GameObject trafficPanel;
    public void Traffic()
    {
        Panels[11].SetActive(true);
        StartCoroutine(Wait());
        /*AdsManager.instance.hideAdmobTopLeftBanner();
        AdsManager.instance.hideAdmobTopRightBanner();
        AdsManager.instance.showAdMobBannerTop();*/

       }
    public void Trafficback()
    {
        Panels[11].SetActive(false);
        Panels[10].SetActive(true);
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        /*AdsManager.instance.showAdMobBannerTopLeft();
        AdsManager.instance.showAdMobBannerTopRight();
        AdsManager.instance.hideAdmobTopBanner();*/
    }
    
        public IEnumerator Wait()
    {
        yield return new WaitForSeconds(0f);
        Panels[10].SetActive(false);
        //trafficPanel.SetActive(true);
        Screen.orientation = ScreenOrientation.Portrait;
    }
    public void reset()
    {
        resetall=true;
        SceneManager.LoadScene("Menu");
        
    }
    public void selectlvl()
    {
        Panels[8].SetActive(true);
        Panels[2].SetActive(false);	
        /*if(AdsManager.instance)
        {
            if(AdManager.ram_ok)
            {
                AdsManager.instance.showAdMobBannerBottomLeft();
                AdsManager.instance.showAdMobBannerBottomRight();
            }
		}*/
    }
    public void selectjob()
    {
        Panels[3].SetActive(true);
        Panels[8].SetActive(false);
       /*if(AdsManager.instance)
       {
			if(AdManager.ram_ok)
            {
                AdManager.Instance.ShowInterstitial ();
                AdsManager.instance.showAdMobBannerBottomLeft();
                AdsManager.instance.showAdMobBannerBottomRight();
            }
		}	*/
    }
     public void selectstore()
    {
        Panels[10].SetActive(true);
        Panels[9].SetActive(false);
        storescene.SetActive(false);
        Menuscene.SetActive(false);
        coinbar.SetActive(false);
    }

    public void CarNumberIncrease() 
    {
        if (carNumber >= 0 && carNumber < 3)
            carNumber++;
            bg[carNumber].SetActive(true);
            bg[carNumber-1].SetActive(false);
            qualitytext[carNumber].SetActive(true);
            qualitytext[carNumber-1].SetActive(false);
            Qlines[carNumber].SetActive(true);
            Qlines[carNumber-1].SetActive(false);
    }
    public void CarNumberDecrease()
    {
        if (carNumber <= 3 && carNumber > 0)
            carNumber--;
            bg[carNumber].SetActive(true);
            bg[carNumber+1].SetActive(false);
            qualitytext[carNumber].SetActive(true);
            qualitytext[carNumber+1].SetActive(false);
            Qlines[carNumber].SetActive(true);
            Qlines[carNumber+1].SetActive(false);
    }
     public void shadowIncrease() 
    {
        if (shadowNumber >= 0 && shadowNumber < 2)
            shadowNumber++;
            shadowtext[shadowNumber].SetActive(true);
            shadowtext[shadowNumber-1].SetActive(false);
            Shlines[shadowNumber].SetActive(true);
            Shlines[shadowNumber-1].SetActive(false);
    }
     public void shadowDecrease() 
    {
        if (shadowNumber <= 2 && shadowNumber >0)
            shadowNumber--;
            shadowtext[shadowNumber].SetActive(true);
            shadowtext[shadowNumber+1].SetActive(false);
            Shlines[shadowNumber].SetActive(true);
            Shlines[shadowNumber+1].SetActive(false);
    }
    public void camerafarIncrease() 
    {
        if (camfar >= 0 && camfar < 2)
            camfar++;
            cameratxt[camfar].SetActive(true);
            cameratxt[camfar-1].SetActive(false);
            cameralines[camfar].SetActive(true);
            cameralines[camfar-1].SetActive(false);
    }
    public void camerafarDecrease() 
    {
        if (camfar <= 2 && camfar > 0)
            camfar--;
            cameratxt[camfar].SetActive(true);
            cameratxt[camfar+1].SetActive(false);
            cameralines[camfar].SetActive(true);
            cameralines[camfar+1].SetActive(false);
    }
    public void Exit(){
        /*if(AdsManager.instance)
        {
			if(AdManager.ram_ok)
            {
                AdsManager.instance.showAdMobBannerBottomLeft ();
            }
        }*/
        Panels[1].SetActive(false);
		Panels[5].SetActive(true);
	}
    public void yes(){
        Application.Quit ();
	}
    public void no(){
        /*if(AdsManager.instance)
        {
			if(AdManager.ram_ok)
            {
                AdsManager.instance.hideAdmobBottomLeftBanner ();
            }
        }*/
        Panels[1].SetActive(true);
		Panels[5].SetActive(false);
	}
      public void controlIncrease() 
    {
        if (controlNumber >= 0 && controlNumber < 1)
            controlNumber++;
           
    }
    public void controlDecrease() 
    {
        if (controlNumber <= 1 && controlNumber >0)
            controlNumber--;
          
    }
    public void BtnControl() 
    {
        RCC.SetMobileController(RCC_Settings.MobileController.TouchScreen);
    }
    public void steeringControl() 
    {
        RCC.SetMobileController(RCC_Settings.MobileController.SteeringWheel);
    }
    public void gyroControl() 
    {
        RCC.SetMobileController (RCC_Settings.MobileController.Gyro);
    }
    public void Adds(string url)
    {
        Application.OpenURL(url);
    }

    

}
