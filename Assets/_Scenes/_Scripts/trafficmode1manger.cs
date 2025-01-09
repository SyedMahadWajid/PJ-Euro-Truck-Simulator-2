using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace TurnTheGameOn.SimpleTrafficSystem
{


    public class trafficmode1manger : MonoBehaviour
    {
        public static trafficmode1manger tf;
        int clickCounter;
        public Sprite green, red;
        public GameObject button1, completepanel, failpanel,d1,aitraffic_controller,ai2 ,PauseBtn,startpanel;
        public GameObject[] greenbuttons, redbuttons, parkinggate, levels;
        public SpawnRandomFromPool[] S;
        public AITrafficPool pool1;
        public Text carsno;
      
        private void Start()
        {
           
            Time.timeScale = 2f;
            AudioListener.volume = 1;
            levels[MenuScene.trafiiclevel].SetActive(true);
            tf = this;
           
            if (MenuScene.trafiiclevel == 0)
            {
                StartCoroutine(level0());
            }
            if (MenuScene.trafiiclevel == 1)
            {
                StartCoroutine(level1());

            }
            if (MenuScene.trafiiclevel == 2)
            {
                StartCoroutine(level2());

            }
            if (MenuScene.trafiiclevel == 6)
            {
                d1.SetActive(false);
               

            }
            if (MenuScene.trafiiclevel == 9)
            {
                d1.SetActive(false);
                aitraffic_controller.GetComponent<AITrafficController>()._AITrafficPool = pool1;
            }
            if (PlayerPrefs.GetInt("panel") == 1)
            {
                startpanel.SetActive(false);
            }
           
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
            /*AdsManager.instance.hideAdmobTopRightBanner();*/
        }
      
        public void failcal()
        {
                Time.timeScale = 0f;
                failpanel.SetActive(true);
                PauseBtn.SetActive(false);
                /*AdsManager.instance.showAdMobRectangleBannerBottomLeft();
                AdManager.Instance.ShowInterstitial();*/

            
        }
        IEnumerator level0()
        {
            yield return new WaitForSeconds(5f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(8f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(8f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(8f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(8f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(8f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1.5f);
            S[0].GetComponent<SpawnRandomFromPool>().spawnCars = false;

        }
        IEnumerator level1()
        {
            yield return new WaitForSeconds(20f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            S[2].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            S[2].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(10f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            S[2].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            S[2].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(10f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(5f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(5f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(5f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(2f);
            S[1].GetComponent<SpawnRandomFromPool>().spawnCars = false;


        }
        IEnumerator level2()
        {
            yield return new WaitForSeconds(20f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1.5f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(10f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1.5f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(10f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1.5f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(10f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1.5f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = false;
            yield return new WaitForSeconds(12f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = true;
            yield return new WaitForSeconds(1.5f);
            S[3].GetComponent<SpawnRandomFromPool>().spawnCars = false;
           


        }
        
    

        public void buttonchange()
        {
            clickCounter++;

            switch (clickCounter)
            {
                case 1:

                    foreach (GameObject gbtn in greenbuttons)
                    {
                        gbtn.SetActive(true);
                        parkinggate[0].GetComponent<Animator>().SetBool("close", true);
                        parkinggate[1].GetComponent<Animator>().SetBool("close", true);
                        parkinggate[2].GetComponent<Animator>().SetBool("close", true);
                        parkinggate[3].GetComponent<Animator>().SetBool("close", true);
                        parkinggate[4].GetComponent<Animator>().SetBool("close", true);
                        parkinggate[5].GetComponent<Animator>().SetBool("close", true);
                        parkinggate[6].GetComponent<Animator>().SetBool("close", true);
                        parkinggate[7].GetComponent<Animator>().SetBool("close", true);

                    }
                    foreach (GameObject rbtn in redbuttons)
                    {
                        rbtn.SetActive(false);
                    }

                    button1.gameObject.GetComponent<Image>().sprite = green;
                    break;
                case 2:
                    foreach (GameObject gbtn in greenbuttons)
                    {
                        gbtn.SetActive(false);
                    }
                    foreach (GameObject rbtn in redbuttons)
                    {
                        rbtn.SetActive(true);
                        parkinggate[0].GetComponent<Animator>().SetBool("close", false);
                        parkinggate[1].GetComponent<Animator>().SetBool("close", false);
                        parkinggate[2].GetComponent<Animator>().SetBool("close", false);
                        parkinggate[3].GetComponent<Animator>().SetBool("close", false);
                        parkinggate[4].GetComponent<Animator>().SetBool("close", false);
                        parkinggate[5].GetComponent<Animator>().SetBool("close", false);
                        parkinggate[6].GetComponent<Animator>().SetBool("close", false);
                        parkinggate[7].GetComponent<Animator>().SetBool("close", false);
                    }
                    button1.gameObject.GetComponent<Image>().sprite = red;
                    clickCounter = 0;
                    break;

            }
        }
        public void home()
        {
            SceneManager.LoadScene(1);
            /*AdsManager.instance.hideAdmobBottomLeftBanner();
            AdsManager.instance.hideAdmobTopRightBanner();*/
        }
        public void restart()
        {
            SceneManager.LoadScene(3);
            /*AdsManager.instance.hideAdmobBottomLeftBanner();*/
        }
        public void pause()
        {
            Time.timeScale = 0 ;
            button1.SetActive(false);
            PauseBtn.SetActive(false);
            /*AdManager.Instance.ShowInterstitial();
            AdsManager.instance.showAdMobRectangleBannerBottomLeft();*/
        }

        public void resume()
        {
            Time.timeScale = 2;
            button1.SetActive(true);
            PauseBtn.SetActive(true);
            /*AdsManager.instance.hideAdmobBottomLeftBanner();*/
        }
        public void next()
        {
            MenuScene.trafiiclevel++;
            if (MenuScene.trafiiclevel >= 10)
            {
                SceneManager.LoadScene(1);
                /*AdsManager.instance.hideAdmobBottomLeftBanner();
                AdsManager.instance.hideAdmobTopBanner();*/
            }
            else
            {
                SceneManager.LoadScene("trafficmode1");
                /*AdsManager.instance.hideAdmobBottomLeftBanner();*/
                
            }
        }
        public void startpanelbtn()
        {
            PlayerPrefs.SetInt("panel", 1);
            {
                startpanel.SetActive(false);
                
            }
        }
    }
}
