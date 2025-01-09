using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Store1 : MonoBehaviour
{
    public static int carNumber,carNumberIndex;
    public GameObject notEnoughMsg,SelectBtn,coinstext;
	public GameObject[] purchase,LocBtn;
    public Text CoinsCars,TotalCoins;
    public static bool rewardedvideo;
	public Material[] Paint;
    public GameObject TruckBody,TruckHead;
    public GameObject TruckBodyLock,TruckHeadLock;
    string truckpaint;
    int lastUnlockColor;
    
    void Start()
    {
        if (PlayerPrefs.GetInt("car1") == 1)
        {
            CoinsCars.text = "";
            coinstext.SetActive(false);
            purchase[0].SetActive(false);
            LocBtn[0].SetActive(false);
            SelectBtn.SetActive(true);
        }
        if (PlayerPrefs.GetInt("car2") == 1)
        {
            CoinsCars.text = "";
            coinstext.SetActive(false);
            purchase[1].SetActive(false);
            LocBtn[1].SetActive(false);
            SelectBtn.SetActive(true);
        }
        if (PlayerPrefs.GetInt("car3") == 1)
        {
            CoinsCars.text = "";
            coinstext.SetActive(false);
            purchase[2].SetActive(false);
            LocBtn[2].SetActive(false);
            SelectBtn.SetActive(true);
        }
        if (PlayerPrefs.GetInt("car4") == 1)
        {
            CoinsCars.text = "";
            coinstext.SetActive(false);
            purchase[3].SetActive(false);
            LocBtn[3].SetActive(false);
            SelectBtn.SetActive(true);
        }

        if(PlayerPrefs.GetInt("PaintOnce") == 0)
        {
            PlayerPrefs.SetInt("PaintOnce",1);
            PlayerPrefs.SetInt("Paint",1);
        }

       
        carNumber = PlayerPrefs.GetInt("Paint");
        carNumberIndex = PlayerPrefs.GetInt("Paint");
        PaintOnStart();
        SelectCar();
    }

    void Update()
    {
        // print("ndjsxbchfjdh " + PlayerPrefs.GetInt("Paint"));
        // print("carNumberIndex " + carNumberIndex);
    }

    ///////////////////////////////////////////////////////////  STORE   ////////////////////////////////////////////////////////////////
    public void CarNumber(int Num)
    {
        carNumber = Num ;
        SelectCar();
    }
    public void SelectCar() 
    {
        if (carNumber == 1) 
		{
            SelectBtn.SetActive(true);
            CoinsCars.text = "";
            coinstext.SetActive(false);
			carNumberIndex = carNumber;
            PlayerPrefs.SetInt("Paint",carNumberIndex);
        }
        else if (carNumber == 2)
        {
            if (PlayerPrefs.GetInt("car1") == 1)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                purchase[0].SetActive(false);
                LocBtn[0].SetActive(false);
                SelectBtn.SetActive(true);
				carNumberIndex = carNumber;
                PlayerPrefs.SetInt("Paint",carNumberIndex);
            }
            else{
                coinstext.SetActive(true);
                CoinsCars.text = "3K$";
                SelectBtn.SetActive(false);
                purchase[0].SetActive(true);
                LocBtn[0].SetActive(true);
            }
        }
        else if (carNumber == 3)
        {
            if (PlayerPrefs.GetInt("car2") == 1)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                purchase[1].SetActive(false);
                LocBtn[1].SetActive(false);
                SelectBtn.SetActive(true);
				carNumberIndex = carNumber;
                PlayerPrefs.SetInt("Paint",carNumberIndex);
            }
            else{
                 coinstext.SetActive(true);
                 CoinsCars.text = "3K$";
                 SelectBtn.SetActive(false);
                 purchase[1].SetActive(true);
                 LocBtn[1].SetActive(true);
            }
        }
        else if (carNumber == 4)
        {
            if (PlayerPrefs.GetInt("car3") == 1)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                purchase[2].SetActive(false);
                LocBtn[2].SetActive(false);
                SelectBtn.SetActive(true);
				carNumberIndex = carNumber;
                PlayerPrefs.SetInt("Paint",carNumberIndex);
            }
            else{
                coinstext.SetActive(true);
                CoinsCars.text = "3K$";
                SelectBtn.SetActive(false);
                purchase[2].SetActive(true);
                LocBtn[2].SetActive(true);
            }
        }
        else if (carNumber == 5)
        {
            if (PlayerPrefs.GetInt("car4") == 1)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                purchase[3].SetActive(false);
                LocBtn[3].SetActive(false);
                SelectBtn.SetActive(true);
				carNumberIndex = carNumber;
                PlayerPrefs.SetInt("Paint",carNumberIndex);
            }
            else{
                coinstext.SetActive(true);
                CoinsCars.text = "3K$";
                SelectBtn.SetActive(false);
                purchase[3].SetActive(true);
                LocBtn[3].SetActive(true);
            }
        }
    }
    public void ok() 
	{
        notEnoughMsg.SetActive(false);
    }
    public void BuyMethod()
	{
        if (carNumber == 1)
        {   
        }
        if (carNumber == 2)
        {
            if (PlayerPrefs.GetInt("coins") >= 3000)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 3000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase[0].SetActive(false);
                LocBtn[0].SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car1", 1);
                carNumberIndex = carNumber;
                DoPaint();
                print("carNumberIndex " + carNumberIndex);
                PlayerPrefs.SetInt("Paint",carNumberIndex);
                print("PaintPrefs "+ PlayerPrefs.GetInt("Paint"));
            }
            else if (PlayerPrefs.GetInt("coins") < 3000)
            {
                notEnoughMsg.SetActive(true);
            }
        }
        if (carNumber == 3)
        {
            if (PlayerPrefs.GetInt("coins") >= 3000)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 3000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase[1].SetActive(false);
                LocBtn[1].SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car2", 1);
                carNumberIndex = carNumber;
                DoPaint();
                PlayerPrefs.SetInt("Paint",carNumberIndex);
            }
            else if (PlayerPrefs.GetInt("coins") < 3000)
            {
                notEnoughMsg.SetActive(true);
            }
        }
        if (carNumber == 4)
        {
            if (PlayerPrefs.GetInt("coins") >= 3000)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 3000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase[2].SetActive(false);
                LocBtn[2].SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car3", 1);
                carNumberIndex = carNumber;
                DoPaint();
                PlayerPrefs.SetInt("Paint",carNumberIndex);
            }
            else if (PlayerPrefs.GetInt("coins") < 3000)
            {
                notEnoughMsg.SetActive(true);
            }
    	}
        if (carNumber == 5)
        {
            if (PlayerPrefs.GetInt("coins") >= 3000)
            {
                CoinsCars.text = "";
                coinstext.SetActive(false);
                PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") - 3000);
                TotalCoins.text = PlayerPrefs.GetInt("coins").ToString();
                purchase[3].SetActive(false);
                LocBtn[3].SetActive(false);
                SelectBtn.SetActive(true);
                PlayerPrefs.SetInt("car4", 1);
                carNumberIndex = carNumber;
                DoPaint();
                PlayerPrefs.SetInt("Paint",carNumberIndex);
            }
            else if (PlayerPrefs.GetInt("coins") < 3000)
            {
                notEnoughMsg.SetActive(true);
            }
    	}
	}
	public void PaintFun(string truckpaintdummy)
    {
        truckpaint = truckpaintdummy;
        if (carNumber == 1) {
            DoPaint();
        }
        else if (carNumber == 2)
        {
            if (PlayerPrefs.GetInt("car1") == 1)
            {
               DoPaint();
            }
            else{
                DoLockPaint();
            }
        }
        else if (carNumber == 3)
        {
            if (PlayerPrefs.GetInt("car2") == 1)
            {
               DoPaint();
            }
            else{
                DoLockPaint();
            }
        }
        else if (carNumber == 4)
        {
            if (PlayerPrefs.GetInt("car3") == 1)
            {
               DoPaint();
            }
            else{
               DoLockPaint();
            }
        }
        else if (carNumber == 5)
        {
            if (PlayerPrefs.GetInt("car4") == 1)
            {
               DoPaint();
            }
            else{
               DoLockPaint();
            }
        }
        
    }
    public void PaintOnStart()
	{

        print("ndjsxbchfjdh " + PlayerPrefs.GetInt("Paint"));

        if(PlayerPrefs.GetInt("Paint") == 1)
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[0];
           
        }
        if(PlayerPrefs.GetInt("Paint") == 3)
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[1];
           
        }
        if(PlayerPrefs.GetInt("Paint") == 2)
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[2];
           
        }
        if(PlayerPrefs.GetInt("Paint") == 4)
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[3];
            
        }
        if(PlayerPrefs.GetInt("Paint") == 5)
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[4];
            
        }
    }
	public void DoPaint()
	{
        if(truckpaint=="red")
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[0];
            lastUnlockColor = 1;
        }
        if(truckpaint=="yellow")
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[1];
            lastUnlockColor = 2;
        }
        if(truckpaint=="blue")
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[2];
            lastUnlockColor = 3;
        }
        if(truckpaint=="black")
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[3];
            lastUnlockColor = 4;
        }
        if(truckpaint=="orange")
        {
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[4];
            lastUnlockColor = 5;
        }
    }
    public void DoLockPaint()
	{
        if(truckpaint=="red")
        {
           	TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[0];
        }
        if(truckpaint=="yellow")
        {
            TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[1];
        }
        if(truckpaint=="blue")
        {
            TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[2];
        }
        if(truckpaint=="black")
        {
            TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[3];
        }
        if(truckpaint=="orange")
        {
            TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[4];
        }
    }
	public void Paintclose()
	{
       if(lastUnlockColor == 2){
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[1];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[1];

        }
        else if(lastUnlockColor == 3){
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[2];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[2];
        }
        else if(lastUnlockColor == 4){
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[3];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[3];
        }
        else if(lastUnlockColor == 5){
            TruckBody.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[4];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[4];
        }
        else if(lastUnlockColor == 1){
           TruckBody.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckBodyLock.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckHead.GetComponent<MeshRenderer> ().material = Paint[0];
			TruckHeadLock.GetComponent<MeshRenderer> ().material = Paint[0];
        }
        
    }
}
            