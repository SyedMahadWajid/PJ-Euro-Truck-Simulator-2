using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class store : MonoBehaviour
{
    public static int carNumber=1;
    public GameObject notEnoughMsg,purchase,SelectBtn,rightBtn,leftBtn,coinstext,customizationbtn;
    public Text CoinsCars,TotalCoins;
    public GameObject[] car,spec;
    public static bool rewardedvideo;
    public static bool truckpurchased;
    // Start is called before the first frame update
    void Start()
    {
        TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
        if (carNumber>1 && carNumber<5)
        {
            leftBtn.SetActive(true);
            rightBtn.SetActive(true);
        }
        if(carNumber>=5)
        {
            rightBtn.SetActive(false);
            leftBtn.SetActive(true);
        }
        SelectCar();
        
    }
    
    void Update()
    {
        print(carNumber);
        if(rewardedvideo)
        {
            PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + 2000);
            TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
            rewardedvideo=false;
        }
        if(truckpurchased){
            truckpurchased=false;
            SelectCar();
        }
    }
    ///////////////////////////////////////////////////////////  STORE   ////////////////////////////////////////////////////////////////

    public void watchvedio(){
      //  if(ADManager.Instance)
      //  {
      //      ADManager.Instance.ShowRewarded();
      //  }
    }

    public void CarNumberIncrease() 
    {
        if (carNumber >= 1 && carNumber < 6)
            carNumber++;

        if (carNumber == 5)
            rightBtn.SetActive(false);
            leftBtn.SetActive(true);

        SelectCar();
        
    }

    public void CarNumberDecrease()
    {
        if (carNumber <= 5 && carNumber > 0)
            carNumber--;

        if (carNumber == 1)
            leftBtn.SetActive(false);
            rightBtn.SetActive(true);

        SelectCar();
        
        
    }
    public void SelectCar() 
    {
        foreach(GameObject cr in car)
        {
            cr.SetActive(false);
        }
        foreach(GameObject sp in spec)
        {
            sp.SetActive(false);
        }
        spec[carNumber-1].SetActive(true);
        purchase.SetActive(false);
        if (carNumber == 1) 
        {
            car[0].SetActive(true);
            SelectBtn.SetActive(true);
            CoinsCars.text = "";
            coinstext.SetActive(false);
            customizationbtn.SetActive(true);
        }
        else if (carNumber == 2)
        {
            car[1].SetActive(true);


            if (PlayerPrefs.GetInt("car1") == 1)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                customizationbtn.SetActive(true);
            }
            else{
                coinstext.SetActive(true);
                CoinsCars.text = "45000";
                SelectBtn.SetActive(false);
                purchase.SetActive(true);
                customizationbtn.SetActive(false);
            }
        }
        else if (carNumber == 3)
        {
            car[2].SetActive(true);

            if (PlayerPrefs.GetInt("car2") == 1)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                customizationbtn.SetActive(true);
            }
            else{
                 coinstext.SetActive(true);
                 CoinsCars.text = "55000";
                 SelectBtn.SetActive(false);
                 purchase.SetActive(true);
                customizationbtn.SetActive(false);
            }
        }
        else if (carNumber == 4)
        {
            car[3].SetActive(true);

            if (PlayerPrefs.GetInt("car3") == 1)
            {
                CoinsCars.text = "";
                 coinstext.SetActive(false);
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                customizationbtn.SetActive(true);
            }
            else{
                 coinstext.SetActive(true);
                CoinsCars.text = "62000";
                SelectBtn.SetActive(false);
                purchase.SetActive(true);
                customizationbtn.SetActive(false);
            }
        }
        else if (carNumber == 5)
        {
            car[4].SetActive(true);

            if (PlayerPrefs.GetInt("car4") == 1)
            {
                CoinsCars.text = "";
                 coinstext.SetActive(false);
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                customizationbtn.SetActive(true);
            }
            else{
                coinstext.SetActive(true);
                CoinsCars.text = "68000";
                SelectBtn.SetActive(false);
                purchase.SetActive(true);
                customizationbtn.SetActive(false);
            }
        }
          else if (carNumber == 6)
        {
            car[5].SetActive(true);

            if (PlayerPrefs.GetInt("car5") == 1)
            {
                CoinsCars.text = "";
                 coinstext.SetActive(false);
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                customizationbtn.SetActive(true);
            }
            else{
                 coinstext.SetActive(true);
                CoinsCars.text = "75000";
                SelectBtn.SetActive(false);
                purchase.SetActive(true);
                customizationbtn.SetActive(false);
            }
        }
           else if (carNumber == 7)
        {
            car[6].SetActive(true);

            if (PlayerPrefs.GetInt("car6") == 1)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
            }
            else{
                coinstext.SetActive(true);
                CoinsCars.text = "80000";
                SelectBtn.SetActive(false);
                purchase.SetActive(true);
            }
        }
    }
     public void ok() {
        notEnoughMsg.SetActive(false);
     }
    public void BuyMethod() {
        if (carNumber == 1)
        {   
        }
        if (carNumber == 2)
        {
            if (PlayerPrefs.GetInt("coins") >= 45000)
            {
                CoinsCars.text = "purchased";
                coinstext.SetActive(false);
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 45000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car1", 1);
                customizationbtn.SetActive(true);

            }
            else if (PlayerPrefs.GetInt("coins") < 45000)
            {
                notEnoughMsg.SetActive(true);
            }
        }
        if (carNumber == 3)
        {
            if (PlayerPrefs.GetInt("coins") >= 55000)
            {
                CoinsCars.text = "purchased";
                coinstext.SetActive(false);
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 55000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car2", 1);
                customizationbtn.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("coins") < 55000)
            {
                notEnoughMsg.SetActive(true);
            }
        }
        if (carNumber == 4)
        {
            if (PlayerPrefs.GetInt("coins") >= 62000)
            {
                CoinsCars.text = "purchased";
                coinstext.SetActive(false);
               PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 62000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase.SetActive(false);
                 SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car3", 1);
                customizationbtn.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("coins") < 62000)
            {
                notEnoughMsg.SetActive(true);
            }
        }
        if (carNumber == 5)
        {
            if (PlayerPrefs.GetInt("coins") >= 68000)
            {
                CoinsCars.text = "purchased";
                coinstext.SetActive(false);
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 68000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase.SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car4", 1);
                customizationbtn.SetActive(true);
            }
            else if (PlayerPrefs.GetInt("coins") < 68000)
            {
                notEnoughMsg.SetActive(true);
            }
        }
        // if (carNumber == 6)
        //{
        //    if (PlayerPrefs.GetInt("coins") >= 75000)
        //    {
        //        CoinsCars.text = "";
        //        coinstext.SetActive(false);
        //        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 75000);
        //        TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
        //        purchase.SetActive(false);
        //        SelectBtn.SetActive(true);
        //        PlayerPrefs.SetInt("car5", 1);
        //    }
        //    else if (PlayerPrefs.GetInt("coins") < 75000)
        //    {
        //        notEnoughMsg.SetActive(true);
        //    }
        //}
        //  if (carNumber == 7)
        //{
        //    if (PlayerPrefs.GetInt("coins") >= 80000)
        //    {
        //        CoinsCars.text = "";
        //        coinstext.SetActive(false);
        //        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 80000);
        //        TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
        //        purchase.SetActive(false);
        //        SelectBtn.SetActive(true);
        //        PlayerPrefs.SetInt("car6", 1);
        //    }
        //    else if (PlayerPrefs.GetInt("coins") < 80000)
        //    {
        //        notEnoughMsg.SetActive(true);
        //    }
        //}
    }
    

}
