using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

   
    public class manger2dscene : MonoBehaviour
    {
        public GameObject[] traffic, player,levels,panels_2d;
    public GameObject directionallight,speedbtn;
    public Material skynight;


    private void Start()
    {
       
        Application.targetFrameRate = 0;
        Time.timeScale = 0f;
        AudioListener.volume = 1;
        levels[MenuScene.trafiiclevel].SetActive(true);
        panels_2d[MenuScene.trafiiclevel].SetActive(true);
        if (MenuScene.trafiiclevel == 4)
        {
            directionallight.SetActive(false);
            RenderSettings.skybox = skynight;
        }
    }

    public void speedup()
        {
        for (int i = 0; i < traffic.Length; i++)
        {
            traffic[i].GetComponent<WaypointMover>().movementSpeed = 40f;

        }
        for (int i = 0; i < player.Length; i++)
        {
            player[i].GetComponent<WaypointMover>().movementSpeed = 40f;

        }


    }
    public void speeddown()
    {
        for (int i = 0; i < traffic.Length; i++)
        {
            traffic[i].GetComponent<WaypointMover>().movementSpeed = 25f;

        }
        for (int i = 0; i < player.Length; i++)
        {
            player[i].GetComponent<WaypointMover>().movementSpeed = 25f;

        }

    }
    public void home()
    {
        SceneManager.LoadScene(1);   
    }
    public void restart()
    {
        SceneManager.LoadScene("2dmode");
    }
    public void next()
    {
        MenuScene.trafiiclevel ++;
        if (MenuScene.trafiiclevel >=10)
        {
            SceneManager.LoadScene(1);

        }
        else
        {
            SceneManager.LoadScene("2dmode");
        }
    }
    public void playbtn()
    {
        Time.timeScale = 1;
    }
}
