using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class completeplayer : MonoBehaviour
{
    public PLAYER2 mnger;
    public manger2dscene manager;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="finishcube")
        {
            print("okooo");
            StartCoroutine(completepanel());
            
        }
    }
    IEnumerator completepanel()

    {
        yield return new WaitForSeconds(3f);
        manager.panels_2d[MenuScene.trafiiclevel].SetActive(false);
        GameObject.FindGameObjectWithTag("bg").gameObject.GetComponent<AudioSource>().Stop();
        mnger.complatep.SetActive(true);
        manager.speedbtn.SetActive(false);

    }
}
