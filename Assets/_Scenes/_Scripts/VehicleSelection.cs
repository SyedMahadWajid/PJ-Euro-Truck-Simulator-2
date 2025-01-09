using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VehicleSelection : MonoBehaviour
{
    public GameObject[] Panel, Vehicle,hoods, lockhoods;
    public int[] VehiclePrice,hoodprice;
    public GameObject lockImage, buyButton, selectButton,BtnRight,BtnLeft;
    public Text totalCoins, price,hoodvalue;
    public static int _index,hoodindex;

    public GameObject buybtnhoods;
    //public AudioSource music, sound;
    //public GameObject rccCam, startCam, _drag;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        PlayerPrefs.SetInt("Vehicle0", 1);
        totalCoins.text = PlayerPrefs.GetInt("TotalCash").ToString();
        //music.volume = PlayerPrefs.GetFloat("MusicVolume");
        //sound.volume = PlayerPrefs.GetFloat("SoundVolume");
        //StartCoroutine(ChangeOfCameras());

        if (PlayerPrefs.GetInt("UnlockAllCars") == 1)
        {
            for (int i = 0; i < Vehicle.Length; i++)
            {
                PlayerPrefs.SetInt("Vehicle" + i, 1);
            }
        }


        SetVehicle();
        Sethoods();
        //AdsManager.Instance.ShowBanner_TopLeft();
        //AdsManager.Instance.ShowBanner_TopRight();
        //AdsManager.Instance.HideAdmobBanner_BottomLeft();
    }

    //IEnumerator ChangeOfCameras()
    //{
    //    yield return new WaitForSeconds(3.0f);
    //    startCam.SetActive(false);
    //    _drag.SetActive(true);
    //    rccCam.GetComponent<Camera>().enabled = true;
    //}

    public void Left()
    {
        if (_index > 0)
        {
            _index--;
        }
        if (_index <= 0)
        {
            print("ok8");
            //BtnLeft.SetActive(false);
            //BtnRight.SetActive(true);
        }
        SetVehicle();
    }

    public void Right()
    {
        if (_index < Vehicle.Length - 1)
        {
            _index++;
        }
        if (_index >= 9)
        {
            //BtnRight.SetActive(false);
            //BtnLeft.SetActive(true);
        }
        SetVehicle();
    }
    
    public void Buy()
    {
        if (PlayerPrefs.GetInt("Vehicle" + _index) != 1)
        {
            if (PlayerPrefs.GetInt("TotalCash") >= VehiclePrice[_index])
            {
                PlayerPrefs.SetInt("TotalCash", PlayerPrefs.GetInt("TotalCash") - VehiclePrice[_index]);
                PlayerPrefs.SetInt("Vehicle" + _index, 1);
                Panel[1].SetActive(true);
            }
            else
            {
                Panel[0].SetActive(true);
            }
        }

        SetVehicle();
    }

    public void Ok()
    {
        Panel[0].SetActive(false);
        Panel[1].SetActive(false);
    }

    public void SelectVehicle()
    {
        SceneManager.LoadScene("LevelSelection");
    }


    // Update is called once per frame
    void SetVehicle()
    {
        if (PlayerPrefs.GetInt("Vehicle" + _index) != 1)
        {
            price.text = VehiclePrice[_index].ToString();
            lockImage.SetActive(true);
            buyButton.SetActive(true);
            selectButton.SetActive(false);
        }
        else
        {
            price.text = "Owned";
            lockImage.SetActive(false);
            buyButton.SetActive(false);
            selectButton.SetActive(true);
        }
        totalCoins.text = PlayerPrefs.GetInt("TotalCash").ToString();
        DisableAllVehicles();
        Vehicle[_index].SetActive(true);
       // Spec[_index].SetActive(true);
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }

   
    void DisableAllVehicles()
    {
        for(int i = 0; i < Vehicle.Length; i++)
        {
            Vehicle[i].SetActive(false);
           // Spec[i].SetActive(false);
        }
    }
    public void buyhoods()
    {
        if (PlayerPrefs.GetInt("hood" + hoodindex) != 1)
        {
            if (PlayerPrefs.GetInt("TotalCash") >= hoodprice[hoodindex])
            {
                PlayerPrefs.SetInt("TotalCash", PlayerPrefs.GetInt("TotalCash") - hoodprice[hoodindex]);
                PlayerPrefs.SetInt("hood" + hoodindex, 1);
                //Panel[1].SetActive(true);
            }
            else
            {
                Panel[0].SetActive(true);
            }
            Sethoods();
        }
    }
    void Sethoods()
    {
        if (PlayerPrefs.GetInt("hood" + hoodindex) != 1)
        {
            hoodvalue.text = hoodprice[hoodindex].ToString();
            lockhoods[hoodindex].SetActive(true);
            buybtnhoods.SetActive(true);
            selectButton.SetActive(false);
        }
        else
        {
            hoodvalue.text = "Owned";
            lockhoods[hoodindex].SetActive(false);
            buybtnhoods.SetActive(false);
            selectButton.SetActive(true);
        }
        totalCoins.text = PlayerPrefs.GetInt("TotalCash").ToString();
        DisableAllhoods();
       hoods[hoodindex].SetActive(true);
        // Spec[_index].SetActive(true);
    }
    void DisableAllhoods()
    {
        for (int i = 0; i < hoods.Length; i++)
        {
            hoods[i].SetActive(false);
            // Spec[i].SetActive(false);
        }
    }
}
