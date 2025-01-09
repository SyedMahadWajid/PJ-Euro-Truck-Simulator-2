using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlButton : MonoBehaviour
{
    [HideInInspector]
    public static ControlButton Instance;
    public Text CameraCount;
    public GameObject EngnBtn, mapbtn, rightmirror, leftmirror, rightmirrorFrame, leftmirrorFrame, failpnl, fillimage, fuelpnl, musicpanel, musicstopbtn, coinpnl, musicplaybtn, completepanel, pausepnl, Loadingpanel, kmh, kph, minimap, rcccanvas;
    int mirror = 0, musicL = 0, a;
    [Header("properties music")]
    public AudioClip[] audios;
    public AudioSource musicplay, EngnSound;
    public static bool main, enginestart, fuelfull, rewardedvideoGame, rewardedvideotool, toolclick, fuelclick;
    float alpha;
    public Slider volume;
    [Header("properties")]
    public GameObject[] Truck, buttons, traffic;
    public Text lvlcoins, TotalCoins, Coinspnltxt, fuelpnlcoins;
    public int clickCounter = 0;
    public Camera mycam;
    
                              
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        /*if(AdsManager.instance)
		{
            if(AdManager.ram_ok)
            {
                AdsManager.instance.hideAdmobTopRightBanner();
                AdsManager.instance.hideAdmobBottomRightBanner();
                AdsManager.instance.hideAdmobBottomLeftBanner();
            }
           
		}*/
       
        enginestart =false;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Truck[store.carNumber-1].SetActive(true);
        Truck[store.carNumber-1].gameObject.GetComponent<Rigidbody>().isKinematic = true;
        AudioListener.volume = 1.0f;
        mapbtn.SetActive(true);
        Coinspnltxt.text = PlayerPrefs.GetInt("coins").ToString();
        fuelpnlcoins.text = PlayerPrefs.GetInt("coins").ToString();
        StartCoroutine("soundcall");
        if (MenuScene.LevelNo >= 20)
        {
            kph.SetActive(false);
            kmh.SetActive(false);
            traffic[0].SetActive(false);
            traffic[1].SetActive(false);
        }
       
    }
     IEnumerator soundcall ()
	{
        musicplay.clip = audios[0];
        musicplay.Play();
        yield return new WaitForSeconds (150.0f);
        musicplay.clip = audios[1];
        musicplay.Play();
        yield return new WaitForSeconds (150.0f);
        musicplay.clip = audios[2];
        musicplay.Play();
        yield return new WaitForSeconds (150.0f);
        musicplay.clip = audios[3];
        musicplay.Play();
        StartCoroutine("soundcall");
    }
    public void watchvedio()
    {
        //fuelclick =true;
       /*if(AdManager.Instance)
       {
           if(AdManager.ram_ok)
            {
                AdManager.Instance.ShowInterstitial();
            }
       }*/
    }
    public void watchvedioTool()
    {
       // toolclick=true;
       /*if(AdManager.Instance)
       {
           if(AdManager.ram_ok)
            {
                AdManager.Instance.ShowInterstitial();
            }
       }*/
    }
    void Update()
    {
        if(a==1)
        {
            alpha = volume.value;
            foreach(GameObject btn in buttons){
            btn.transform.GetComponent<Image>().color = new Color (1f,1f,1f,alpha);
            }
        }  
      

        if(rewardedvideoGame){
            fuelpnlbtn1();
        }
        if(rewardedvideotool){
            coinpnlbtn1();
        }
    }
    IEnumerator EngnCal()
    {
        EngnSound.Play();
        yield return new WaitForSeconds(0.2f);
        EngnBtn.SetActive(false);
        enginestart=true;
        Truck[store.carNumber - 1].gameObject.GetComponent<Rigidbody>().isKinematic = false;
        Truck[store.carNumber - 1].GetComponent<RCC_CarControllerV3>().maxEngineSoundVolume = 5f;
    }
    IEnumerator enginestop()
    {
        yield return new WaitForSeconds(0.2f);
        
        Truck[store.carNumber - 1].gameObject.GetComponent<Rigidbody>().isKinematic = true;
        EngnSound.Stop();
        enginestart = false;
    }
        
    public void ButtonFunction(string button)
    {
        if(button == "EngineStart")
        {
            StartCoroutine("EngnCal");
        }
        if (button == "EngineStop")
        {
            Truck[store.carNumber - 1].GetComponent<RCC_CarControllerV3>().maxEngineSoundVolume = 0;
            Truck[store.carNumber - 1].GetComponent<RCC_CarControllerV3>().idleEngineSoundVolume = 0;
            StartCoroutine("enginestop");
        }

        if (button == "sidemirror"){
            if(mirror==0){
                rightmirror.SetActive(true);
                leftmirror.SetActive(false);
                rightmirrorFrame.SetActive(true);
                leftmirrorFrame.SetActive(false);
                mirror=1;
            }
            else if(mirror==1){
                rightmirror.SetActive(false);
                leftmirror.SetActive(true);
                rightmirrorFrame.SetActive(false);
                leftmirrorFrame.SetActive(true);
                mirror=2;
            }
            else if(mirror==2){
                rightmirror.SetActive(true);
                leftmirror.SetActive(true);
                rightmirrorFrame.SetActive(true);
                leftmirrorFrame.SetActive(true);
                mirror=3;
            }
            else if(mirror==3){
                rightmirror.SetActive(false);
                leftmirror.SetActive(false);
                rightmirrorFrame.SetActive(false);
                leftmirrorFrame.SetActive(false);
                mirror=0;
            }
        }
        if(button == "music")
        {
            if(musicpanel.activeInHierarchy)
            {
                musicpanel.SetActive(false);
            }
            else
            {
                musicpanel.SetActive(true);
            } 
        }
        if(button == "musicpuse"){
            musicplay.Stop();
            musicstopbtn.SetActive(true);
            musicplaybtn.SetActive(false);
        }
        if(button == "musicresume"){
            musicplay.Play();
            musicstopbtn.SetActive(false);
            musicplaybtn.SetActive(true);
        }
        if(button == "nextmusic"){
            if(musicL == audios.Length-1){
            }
            else{
                musicL++;
                musicplay.clip = audios[musicL];
                musicplay.Play();
            }
        }
        if(button == "previousmusic"){
            if(musicL == 0){
            }
            else{
                musicL--;
                musicplay.clip = audios[musicL];
                musicplay.Play();
            }
        }
    }
    public void Open_URL(string link) {
        Application.OpenURL(link);
    }
    public void complete()
    {
        GameObject.FindGameObjectWithTag("music").gameObject.GetComponent<AudioSource>().Stop();
        Truck[store.carNumber - 1].GetComponent<RCC_CarControllerV3>().maxEngineSoundVolume = 0;
        Truck[store.carNumber - 1].GetComponent<RCC_CarControllerV3>().idleEngineSoundVolume = 0;
        completepanel.SetActive(true);
        mapbtn.SetActive(false);
        rcccanvas.SetActive(false);
        if(MenuScene.LevelNo==0)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 2000);
            lvlcoins.text= "" + 2000;
        }
        if(MenuScene.LevelNo==1)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 3500);
            lvlcoins.text= "" + 3500;
        }
        if(MenuScene.LevelNo==2)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 3800);
            lvlcoins.text= "" + 3800;
        }
        if(MenuScene.LevelNo==3)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 4000);
            lvlcoins.text= "" + 4000;
        }
        if(MenuScene.LevelNo==4)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 4500);
            lvlcoins.text= "" + 4500;
        }
        if(MenuScene.LevelNo==5)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 4700);
            lvlcoins.text= "" + 4700;
        }
        if(MenuScene.LevelNo==6)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 5100);
            lvlcoins.text= "" + 5100;
        }
        if(MenuScene.LevelNo==7)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 5350);
            lvlcoins.text= "" + 5350;
        }
        if(MenuScene.LevelNo==8)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 5600);
            lvlcoins.text= "" + 5600;
        }
        if(MenuScene.LevelNo==9)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 5800);
            lvlcoins.text= "" + 5800;
        }
        if(MenuScene.LevelNo==10)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 6000);
            lvlcoins.text= "" + 6000;
        }
        if(MenuScene.LevelNo==11)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 6200);
            lvlcoins.text= "" + 6200;
        }
        if(MenuScene.LevelNo==12)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 6400);
            lvlcoins.text= "" + 6400;
        }
        if(MenuScene.LevelNo==13)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 6600);
            lvlcoins.text= "" + 6600;
        }
        if(MenuScene.LevelNo==14)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 6800);
            lvlcoins.text= "" + 6800;
        }
        if (MenuScene.LevelNo == 15)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 16)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 17)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 18)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 19)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 20)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 21)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 22)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 23)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 24)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 25)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 26)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 27)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 28)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        if (MenuScene.LevelNo == 29)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 1000);
            lvlcoins.text = "" + 1000;
        }
        TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
       
    }
    public void coin()
    {
        coinpnl.SetActive(true);
    }
    public void fuel()
    {
        fuelpnl.SetActive(true);
        Truck[store.carNumber-1].GetComponent<Rigidbody>().drag=2.0f;
    }
    public void fuelclose()
    {
        fuelpnl.SetActive(false);
        Truck[store.carNumber-1].GetComponent<Rigidbody>().drag=0.05f;
    }
      public void fail()
    {
        failpnl.SetActive(true);
        mapbtn.SetActive(false);
    }
    public void coinpnlbtn()
    {
        if(PlayerPrefs.GetInt("coins") >= 500){
            coinpnl.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 500);
            Coinspnltxt.text = PlayerPrefs.GetInt("coins").ToString();
            PlayerScript.Instance.barrierOpn();
        }
    }
    public void coinpnlbtn1()
    {
        rewardedvideotool=false;
        PlayerScript.Instance.barrierOpn();
        coinpnl.SetActive(false);
    }
    public void fuelpnlbtn()
    {
        if(PlayerPrefs.GetInt("coins") >= 500){
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 500); 
            fuelpnlcoins.text = PlayerPrefs.GetInt("coins").ToString(); 
            fuelfull=true;
        }
    }
    public void fuelpnlbtn1()
    {
        fuelfull=true;
        rewardedvideoGame=false;
    }
    public void cancel()
    {
        AudioListener.volume = 1.0f;
        fuelpnl.SetActive(false);
        gameObject.GetComponent<Rigidbody>().drag=0.05f;
    }
    public void changealpha()
    {
        a = 1;
    }
    public void restart()
    {
        AudioListener.volume = 1.0f;
       
      SceneManager.LoadScene("city");
    }
    public void next()
    {
        Loadingpanel.SetActive(true);
	    completepanel.SetActive(false);
        StartCoroutine ("nextcall");
    }
    public void Home()
    {
        AudioListener.volume = 1.0f;
        main= true;
		SceneManager.LoadScene("Menu");
        /*if(AdsManager.instance)
        {
            if(AdManager.ram_ok)
            {
                AdsManager.instance.hideAdmobBottomLeftBanner();
            }
			
		}*/
	}
    public void Pause()
    {
        Time.timeScale = 0.01f;
        AudioListener.volume = 0.0f;
	    pausepnl.SetActive(true);
        mapbtn.SetActive(false);
	}
    public void resume()
    {
        Time.timeScale = 1;
        AudioListener.volume = 1.0f;
		pausepnl.SetActive(false);
        if (MenuScene.LevelNo <= 19)
        {
            mapbtn.SetActive(true);
        }
        else
        {
            mapbtn.SetActive(false);
        }
       
        /*
        if(AdsManager.instance)
        {
            if(AdManager.ram_ok)
            {
                AdsManager.instance.hideAdmobBottomLeftBanner ();
		        AdsManager.instance.hideAdmobTopRightBanner ();
            }
			
		}*/
        
	}
    IEnumerator nextcall ()
	{
        yield return new WaitForSeconds (3.0f);
        /*if(AdsManager.instance)
            {
                if(AdManager.ram_ok)
                {
                    AdsManager.instance.showAdMobBannerBottomLeft();
                }
            }*/
        
		yield return new WaitForSeconds (1.0f);
		MenuScene.LevelNo++;
		if(MenuScene.LevelNo>=29)
        {
			SceneManager.LoadScene("Menu");
            /*if(AdsManager.instance)
            {
                if(AdManager.ram_ok)
                {
                    AdsManager.instance.hideAdmobBottomLeftBanner ();
                }
		    }*/
           
		}
		else
        {
            SceneManager.LoadScene("city");
		}	
	}
    IEnumerator homecall ()
	{
        yield return new WaitForSeconds (0.1f);
        main= true;
        SceneManager.LoadScene("Menu");
        pausepnl.SetActive(false);
	}
    public void ButtonClick()
    {
        clickCounter++;

        switch (clickCounter)
        {
            case 1:
                RCC.SetMobileController(RCC_Settings.MobileController.TouchScreen);
                break;
            case 2:
                RCC.SetMobileController(RCC_Settings.MobileController.Gyro);
                break;
            case 3:
                RCC.SetMobileController(RCC_Settings.MobileController.SteeringWheel);
                clickCounter = 0;
                break;


        }
    }
    public void map()
    {
        clickCounter++;

        switch (clickCounter)
        {
            case 1:
                minimap.GetComponent<bl_MiniMap>().MiniMapPosition = new Vector3(-478, 300f, 0);
                kmh.SetActive(false);
               
                break;
            case 2:
                minimap.GetComponent<bl_MiniMap>().MiniMapPosition = new Vector3(-342.5f, 300f, 0);
              
                kmh.SetActive(true);
                clickCounter = 0;
                break;
                
            //case 3:
            //    minimap.GetComponent<bl_MiniMap>().MiniMapPosition = new Vector3(-342.5f, 300f, 0);
            //    kmh.SetActive(true);
               

        }
       
    }
    public void carad(string link)
    {
        Application.OpenURL(link);
                
    }
    public void BusAd(string link)
    {
        Application.OpenURL(link);

    }
    public void dragup()
    {
        Truck[store.carNumber - 1].GetComponent<Rigidbody>().drag = 0.1f;
    }
    public void dragdown()
    {
        Truck[store.carNumber - 1].GetComponent<Rigidbody>().drag = 0.05f;
    }
}
