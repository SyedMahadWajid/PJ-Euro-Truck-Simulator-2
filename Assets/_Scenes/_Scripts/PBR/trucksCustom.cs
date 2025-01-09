using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trucksCustom : MonoBehaviour
{
    public truckObj[] trucks;
    public Transform[] campos;
    public GameObject selctBtn, buyBtn,notenough,cam,priceimage;
    string currentCustomPanel;
    public Transform[] hoodsPanelButtons;
    public float speed;
    public  static bool grillpos,originalpos,interiorpos,hoodpos=false;
    public camerascript camera1;
    public Text priceobj;
    // Start is called before the first frame update
    void Start(){
        Time.timeScale = 1f;
        //PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 10000);
        saveOnStart();
        
    }
    
    public void saveOnStart()
    {
        for(int i=0; i < trucks.Length; i++)
        {
            string currentHoodPref = string.Concat((i) + "truck_currentHood");
            string hoodPref = string.Concat(PlayerPrefs.GetInt(currentHoodPref) + "_hoodLockTruck_" + (i).ToString());
            if(PlayerPrefs.GetInt(hoodPref) == 1)
            { 
                 trucks[i].hoods[PlayerPrefs.GetInt(currentHoodPref)].SetActive(true);
            }
        }
        for (int j = 0; j < trucks.Length; j++)
        {
            string currentGrillPref = string.Concat((j) + "truck_currentGrill");
            string grillPref = string.Concat(PlayerPrefs.GetInt(currentGrillPref) + "_GrillLockTruck_" + (j).ToString());
            if (PlayerPrefs.GetInt(grillPref) == 2)
            {
                trucks[j].grillLights[PlayerPrefs.GetInt(currentGrillPref)].SetActive(true);
            }
        }
        for (int k = 0; k < trucks.Length; k++)
        {
            string currentsteelPref = string.Concat((k) + "truck_currentsteel");
            string grillPref = string.Concat(PlayerPrefs.GetInt(currentsteelPref) + "_steelLockTruck_" + (k).ToString());
            if (PlayerPrefs.GetInt(grillPref) == 3)
            {
                trucks[k].steelFrames[PlayerPrefs.GetInt(currentsteelPref)].SetActive(true);
            }
        }
        for (int l = 0; l < trucks.Length; l++)
        {
            string currentheadPref = string.Concat((l) + "truck_currentheadlight");
            string headlightPref = string.Concat(PlayerPrefs.GetInt(currentheadPref) + "_headlightLocktruck_" + (l).ToString());
            if (PlayerPrefs.GetInt(headlightPref) == 4)
            {
                trucks[l].headLights[PlayerPrefs.GetInt(currentheadPref)].SetActive(true);
            }
        }
        for (int m = 0; m < trucks.Length; m++)
        {
            string currentlightPref = string.Concat((m) + "truck_currentilight");
            string ilightPref = string.Concat(PlayerPrefs.GetInt(currentlightPref) + "_ilightLocktruck_" + (m).ToString());
            if (PlayerPrefs.GetInt(ilightPref) == 5)
            {
                trucks[m].interiorLights[PlayerPrefs.GetInt(currentlightPref)].SetActive(true);
            }
        }



    }


    
  
    public void setPanel(string panelName)
    {
        currentCustomPanel = panelName;
        for(int i=0;i< hoodsPanelButtons[0].childCount; i++)
        {
             string hoodPref = string.Concat(i + "_hoodLockTruck_" + (store.carNumber - 1).ToString());
            if(PlayerPrefs.GetInt(hoodPref) == 1)
            {
                hoodsPanelButtons[0].GetChild(i).GetChild(0).gameObject.SetActive(false);
                
            }
            else
            {
                hoodsPanelButtons[0].GetChild(i).GetChild(0).gameObject.SetActive(true);
              
            }

        }
        print(panelName);
        for (int j = 0; j < hoodsPanelButtons[1].childCount; j++)
        {
           
            string grillPref = string.Concat(j + "_GrillLockTruck_" + (store.carNumber - 1).ToString());
            if (PlayerPrefs.GetInt(grillPref) == 2)
            {
                hoodsPanelButtons[1].GetChild(j).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                hoodsPanelButtons[1].GetChild(j).GetChild(0).gameObject.SetActive(true);
            }

        }
        for (int k = 0; k < hoodsPanelButtons[2].childCount; k++)
        {
            string steelframePref = string.Concat(k + "_steelLockTruck_" + (store.carNumber - 1).ToString());
            if (PlayerPrefs.GetInt(steelframePref) == 3)
            {
                hoodsPanelButtons[2].GetChild(k).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                hoodsPanelButtons[2].GetChild(k).GetChild(0).gameObject.SetActive(true);
            }

        }
        for (int l = 0; l < hoodsPanelButtons[3].childCount; l++)
        {
            string headlightPref = string.Concat(l + "_headlightLocktruck_" + (store.carNumber - 1).ToString());
            if (PlayerPrefs.GetInt(headlightPref) == 4)
            {
                hoodsPanelButtons[3].GetChild(l).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                hoodsPanelButtons[3].GetChild(l).GetChild(0).gameObject.SetActive(true);
            }

        }
        for (int m = 0; m < hoodsPanelButtons[4].childCount; m++)
        {
            string ilightPref = string.Concat(m + "_ilightLocktruck_" + (store.carNumber - 1).ToString());
            if (PlayerPrefs.GetInt(ilightPref) == 5)
            {
                hoodsPanelButtons[4].GetChild(m).GetChild(0).gameObject.SetActive(false);
            }
            else
            {
                hoodsPanelButtons[4].GetChild(m).GetChild(0).gameObject.SetActive(true);
            }

        }

    }

    public void select()
    {
        print(currentCustomPanel);
        if (currentCustomPanel == "grills")
        {
            string currentGrillPref = string.Concat((store.carNumber - 1) + "truck_currentGrill");
            PlayerPrefs.SetInt(currentGrillPref, grillView);
        }
        if (currentCustomPanel == "hoods")
        {
            string currentHoodPref = string.Concat((store.carNumber - 1) + "truck_currentHood");
            PlayerPrefs.SetInt(currentHoodPref, hoodView);
        }
        if (currentCustomPanel == "steelframe")
        {
            string currentsteelPref = string.Concat((store.carNumber - 1) + "truck_currentsteel");
            PlayerPrefs.SetInt(currentsteelPref, steelView);
        }
        if (currentCustomPanel == "headlight")
        {
            string currentheadPref = string.Concat((store.carNumber - 1) + "truck_currentheadlight");
            PlayerPrefs.SetInt(currentheadPref, headlightview);
        }
        if (currentCustomPanel == "ilights")
        {
            string currentlightPref = string.Concat((store.carNumber - 1) + "truck_currentilight");
            PlayerPrefs.SetInt(currentlightPref, Ilightsview);
        }

    }

    public void buy()
    {
        if (currentCustomPanel == "hoods")
        {
            hoodBuy();
        }
        if (currentCustomPanel == "grills")
        {
            grillBuy();
        }
        if (currentCustomPanel == "steelframe")
        {
            stelframeBuy();
        }
        if (currentCustomPanel == "headlight")
        {
            headlightBuy();
        }
        if (currentCustomPanel == "ilights")
        {
            interiorlightsBuy();
        }
    }

   
    public void colorSlect(string colorCode)
    {
        Color colorUtility;
        if (ColorUtility.TryParseHtmlString(colorCode, out colorUtility))
        {
            trucks[store.carNumber-1].mainBody.SetColor("_Color", colorUtility);
                                                          
        }
    }

    int hoodView;
    
    public void hoods(int hoodCount)
    {
        hoodView = hoodCount;
        string hoodPref = string.Concat(hoodView.ToString() + "_hoodLockTruck_" +( store.carNumber-1).ToString());
        foreach (var item in trucks[store.carNumber - 1].hoods)
        {
            item.SetActive(false);
        }
        trucks[store.carNumber - 1].hoods[hoodCount].SetActive(true);
       
        if (PlayerPrefs.GetInt(hoodPref) == 1)
        {
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            priceimage.SetActive(false);
        }   
        else
        {
            buyBtn.SetActive(true);
            selctBtn.SetActive(false);
            priceimage.SetActive(true);
        }
        
    }

    public void hoodBuy()
    {
        string hoodPref = string.Concat(hoodView.ToString() + "_hoodLockTruck_"+ (store.carNumber-1).ToString() );
        
        if (PlayerPrefs.GetInt("coins") >= 100 * (hoodView + 1))
        {
            PlayerPrefs.SetInt(hoodPref, 1);
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            hoodsPanelButtons[0].GetChild (hoodView).GetChild(0).gameObject.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100 * (hoodView + 1)) ;
            priceimage.SetActive(false);
        }
        else
        {
            notenough.SetActive(true);
            priceimage.SetActive(true);
        }
    }
 
    public void hoodsNotSelected()
    {
        foreach (var item in trucks[store.carNumber - 1].hoods)
        {
            item.SetActive(false);
        }
        string cuurentTruckHood = string.Concat(store.carNumber - 1 + "truck_currentHood");                          
        string hoodPref = string.Concat(PlayerPrefs.GetInt(cuurentTruckHood).ToString() + "_hoodLockTruck_"+ (store.carNumber-1).ToString() );

        print(hoodPref +PlayerPrefs.GetInt(hoodPref));
        if (PlayerPrefs.GetInt(hoodPref) == 1)
            trucks[store.carNumber - 1].hoods[PlayerPrefs.GetInt(cuurentTruckHood)].SetActive(true);
    }


    /// - ---------- ------------------------------------------------------------------------hoodSection ends
    /// 
    /// -----------------------------------------------------------------------------------------Grilllights start
    int grillView;
    public void grilllights(int grillCount)
    {
        string grillPref = string.Concat(grillView.ToString() + "_GrillLockTruck_" + (store.carNumber - 1).ToString());
        grillView = grillCount;
        foreach (var grill in trucks[store.carNumber - 1].grillLights)
        {
            grill.SetActive(false);
        }
        trucks[store.carNumber - 1].grillLights[grillCount].SetActive(true);
        if (PlayerPrefs.GetInt(grillPref) == 2)
        {
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            priceimage.SetActive(false);
        }
        else
        {
            buyBtn.SetActive(true);
            selctBtn.SetActive(false);
            priceimage.SetActive(true);
        }
    }

    public void grillBuy()
    {
        string grillPref = string.Concat(grillView.ToString() + "_GrillLockTruck_" + (store.carNumber-1).ToString());
        
        if (PlayerPrefs.GetInt("coins") >= 100 * (grillView + 1))
        {
            PlayerPrefs.SetInt(grillPref, 2);
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            hoodsPanelButtons[1].GetChild(grillView).GetChild(0).gameObject.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100 * (grillView + 1));
            priceimage.SetActive(false);
        }
        else
        {
            notenough.SetActive(true);
            priceimage.SetActive(true);
        }
    }
    public void grillsNotSelected()
    {
        foreach (var item in trucks[store.carNumber - 1].grillLights)
        {
            item.SetActive(false);
        }
        string cuurentTruckGrills = string.Concat(store.carNumber - 1 + "truck_currentGrill");
        string grillPref = string.Concat(PlayerPrefs.GetInt(cuurentTruckGrills).ToString() + "_GrillLockTruck_" + (store.carNumber - 1).ToString());

        print(grillPref + PlayerPrefs.GetInt(grillPref));
        if (PlayerPrefs.GetInt(grillPref) == 2)
            trucks[store.carNumber - 1].grillLights[PlayerPrefs.GetInt(cuurentTruckGrills)].SetActive(true);
    }
    /// -----------------------------------------------------------------------------------------Grilllights ends
    /// 
    /// ---------------------------------------------------------------------------------------- steelframes start
    int steelView;
    public void steelframe(int steelframeCount)
    {
        steelView = steelframeCount;
        string steelframePref = string.Concat(steelView.ToString() + "_steelLockTruck_"+(store.carNumber-1).ToString());
        foreach (var steel in trucks[store.carNumber - 1].steelFrames)
        {
            steel.SetActive(false);
        }
        trucks[store.carNumber - 1].steelFrames[steelframeCount].SetActive(true);
        if (PlayerPrefs.GetInt(steelframePref) == 3)
        {
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            priceimage.SetActive(false);
        }
        else
        {
            buyBtn.SetActive(true);
            selctBtn.SetActive(false);
            priceimage.SetActive(true);
        }
    }
    public void steelframeNotSelected()
    {
        foreach (var steel in trucks[store.carNumber - 1].steelFrames)
        {
            steel.SetActive(false);
        }
        string curentTrucksteel = string.Concat(store.carNumber - 1 + "truck_currentsteel");
        string steelframePref = string.Concat(PlayerPrefs.GetInt(curentTrucksteel).ToString() + "_steelLockTruck_" +(store.carNumber-1).ToString());

        if (PlayerPrefs.GetInt(steelframePref) == 3)
            trucks[store.carNumber - 1].steelFrames[PlayerPrefs.GetInt(curentTrucksteel)].SetActive(true);
    }

    public void stelframeBuy()
    {
        string steelframePref = string.Concat(steelView.ToString() + "_steelLockTruck_" +(store.carNumber-1).ToString());
        if (PlayerPrefs.GetInt("coins") >= 100 * (steelView + 1))
        {
            PlayerPrefs.SetInt(steelframePref, 3);
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            hoodsPanelButtons[2].GetChild(steelView).GetChild(0).gameObject.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100 * (steelView + 1));
            priceimage.SetActive(false);
        }
        else
        {
            notenough.SetActive(true);
            priceimage.SetActive(true);
        }
    }
    /// -----------------------------------------------------------------------------------------steelframes ends
    /// 
    /// ---------------------------------------------------------------------------------------- headlight start
    int headlightview;
    public void truckheadlights(int headlightCount)
    {
        headlightview = headlightCount;
        string headlightPref = string.Concat(headlightview.ToString() + "_headlightLocktruck_" +(store.carNumber-1).ToString());
       
        foreach (var hlight in trucks[store.carNumber - 1].headLights)
        {
            hlight.SetActive(false);
        }
        trucks[store.carNumber - 1].headLights[headlightCount].SetActive(true);
        if (PlayerPrefs.GetInt(headlightPref) == 4)
        {
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            priceimage.SetActive(false);
        }
        else
        {
            buyBtn.SetActive(true);
            selctBtn.SetActive(false);
            priceimage.SetActive(true);
        }
    }
    public void headlightNotSelected()
    {
        foreach (var hlight in trucks[store.carNumber - 1].headLights)
        {
            hlight.SetActive(false);
        }
        string curentTruckheadlight = string.Concat(store.carNumber - 1 + "truck_currentheadlight");
        string headlightPref = string.Concat(PlayerPrefs.GetInt(curentTruckheadlight).ToString() + "_headlightLocktruck_"+(store.carNumber-1).ToString());
        if (PlayerPrefs.GetInt(headlightPref) == 4)
            trucks[store.carNumber - 1].headLights[PlayerPrefs.GetInt(curentTruckheadlight)].SetActive(true);
    }
    public void headlightBuy()
    {
        string headlightPref = string.Concat(headlightview.ToString() + "_headlightLocktruck_"+(store.carNumber-1).ToString());
        if (PlayerPrefs.GetInt("coins") >= 100 * (headlightview + 1))
        {
            PlayerPrefs.SetInt(headlightPref, 4);
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            hoodsPanelButtons[3].GetChild(headlightview).GetChild(0).gameObject.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100 * (headlightview + 1));
            priceimage.SetActive(false);
        }
        else
        {
            notenough.SetActive(true);
            priceimage.SetActive(true);
        }
    }
    /// -----------------------------------------------------------------------------------------headlights ends
    /// 
    /// ----------------------------------------------------------------------------------------  interiorcurtains start
    
    int curatinsview;
    public void interiorcuratains(int CurtainCount)
    {
        string curtainPref = string.Concat(curatinsview.ToString() + "_curtainsLock");
        curatinsview = CurtainCount;
        foreach (var curt in trucks[store.carNumber - 1].curtains)
        {
            curt.SetActive(false);
        }
        trucks[store.carNumber - 1].curtains[CurtainCount].SetActive(true);
        if (PlayerPrefs.GetInt("curtainPref") == 1)
        {
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
        }
        else
        {
            buyBtn.SetActive(true);
            selctBtn.SetActive(false);
        }
    }
    public void curtainsNotSelected()
    {
        foreach (var curt in trucks[store.carNumber - 1].curtains)
        {
            curt.SetActive(false);
        }
        string curtainPref = string.Concat(PlayerPrefs.GetInt("currentcurtains").ToString() + "_curtainsLock");
        if (PlayerPrefs.GetInt(curtainPref) == 1)
            trucks[store.carNumber - 1].curtains[PlayerPrefs.GetInt("currentcurtains")].SetActive(true);
    }
    public void curtainsBuy()
    {
        string curtainPref = string.Concat(curatinsview.ToString() + "_curtainsLock");
        if (PlayerPrefs.GetInt("coins") >= 100 * (curatinsview + 1))
        {
            PlayerPrefs.SetInt(curtainPref, 1);
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100 * (curatinsview + 1));
        }
        else
        {
            notenough.SetActive(true);
        }
    }

    /// ----------------------------------------------------------------------------------------  interiorcurtains ends
    /// 
    /// ----------------------------------------------------------------------------------------  interiorlights start
    /// 
    int Ilightsview;
    public void interiorlights(int lightCount)
    {
        Ilightsview = lightCount;
        string ilightPref = string.Concat(Ilightsview.ToString() + "_ilightLocktruck_"+(store.carNumber-1).ToString());
        foreach (var light in trucks[store.carNumber - 1].interiorLights)
        {
            light.SetActive(false);
        }
        trucks[store.carNumber - 1].interiorLights[lightCount].SetActive(true);
        if (PlayerPrefs.GetInt(ilightPref) == 5)
        {
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            priceimage.SetActive(false);
        }
        else
        {
            buyBtn.SetActive(true);
            selctBtn.SetActive(false);
            priceimage.SetActive(true);
        }
    }
    public void interiorlightsNotSelected()
    {
        foreach (var light in trucks[store.carNumber - 1].interiorLights)
        {
            light.SetActive(false);
        }
        string curentTruckilight = string.Concat(store.carNumber - 1 + "truck_currentilight");
        string ilightPref = string.Concat(PlayerPrefs.GetInt(curentTruckilight).ToString() + "_ilightLocktruck_"+(store.carNumber-1).ToString());

        if (PlayerPrefs.GetInt(ilightPref) == 5)
            trucks[store.carNumber - 1].interiorLights[PlayerPrefs.GetInt(curentTruckilight)].SetActive(true);
        
    }
    public void interiorlightsBuy()
    {
        string ilightPref = string.Concat(Ilightsview.ToString() + "_ilightLocktruck_" + (store.carNumber - 1).ToString());
        if (PlayerPrefs.GetInt("coins") >= 100 * (Ilightsview + 1))
        {
            PlayerPrefs.SetInt(ilightPref, 5);
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            hoodsPanelButtons[4].GetChild(Ilightsview).GetChild(0).gameObject.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100 * (Ilightsview + 1));
            priceimage.SetActive(false);
        }
        else
        {
            notenough.SetActive(true);
            priceimage.SetActive(true);
        }
    }
    /// ----------------------------------------------------------------------------------------  interiorlights ends
    /// 
    /// ----------------------------------------------------------------------------------------  monumants start
    int monumantsview;
    public void interiormonumants(int MonumantsCount)
    {
        string monumentPref = string.Concat(monumantsview.ToString() + "_monumantLock");
        monumantsview = MonumantsCount;
        foreach (var monu in trucks[store.carNumber - 1].monuments)
        {
            monu.SetActive(false);
        }
        trucks[store.carNumber - 1].monuments[MonumantsCount].SetActive(true);
        if (PlayerPrefs.GetInt("monumentPref") == 1)
        {
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
        }
        else
        {
            buyBtn.SetActive(true);
            selctBtn.SetActive(false);
        }
    }
    public void monumentsNotSelected()
    {
        foreach (var monu in trucks[store.carNumber - 1].monuments)
        {
            monu.SetActive(false);
        }
        string monumentPref = string.Concat(PlayerPrefs.GetInt("currentmonument").ToString() + "_monumantLock");
        if (PlayerPrefs.GetInt(monumentPref) == 1)
            trucks[store.carNumber - 1].monuments[PlayerPrefs.GetInt("currentmonument")].SetActive(true);
    }
    public void monamentsBuy()
    {
        string monumentPref = string.Concat(monumantsview.ToString() + "_monumantLock");
        if (PlayerPrefs.GetInt("coins") >= 100 * (monumantsview + 1))
        {
            PlayerPrefs.SetInt(monumentPref, 1);
            selctBtn.SetActive(true);
            buyBtn.SetActive(false);
            this.transform.GetChild(0).gameObject.SetActive(false);
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 100 * (monumantsview + 1));
        }
        else
        {
            notenough.SetActive(true);
        }
    }
    public void ButtonFunctioncam(string button)
    {
        if (button == "grillbtn")
        {
            grillpos = true;
            camera1.enabled = true;
        }
        if (button == "originalposbtn")
        {
            originalpos = true;
            camera1.enabled = true;
        }
        if (button == "interiorcam")
        {
            interiorpos = true;
            camera1.enabled = false;
        }
        if (button == "hoodcam")
        {
            hoodpos = true;
            camera1.enabled = true;
        }
    }
    public void ButtonFunctionprice(string button)
    {
        if (button == "0")
        {
            priceobj.text = "100";
        }
        if (button == "1")
        {
            priceobj.text = "200";
        }
        if (button == "2")
        {
            priceobj.text = "300";
        }
        if (button == "3")
        {
            priceobj.text = "400";
        }
    }
}
