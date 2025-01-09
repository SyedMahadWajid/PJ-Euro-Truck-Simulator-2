using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	public static PlayerScript Instance;
    public static bool Move,policemove,policeTalk,policemove1,fail,complete;
    public GameObject policecam,policeman,rcccam,turnleft,turnright,gostraight,boundry, victorypnl,controlbtns,mapnl;
    public ControlButton CB,CB2;
    public GameObject [] endpoint,Cart,Trailer,door,truck,levels,control,map,Startposition,Startposition1,Startposition2,Startposition3,Startposition4,effects;
  	public Camera myCamera;
	public AudioSource victorysound,attachsound;
    private Animator barrier;
	bool coins;
	public Text leveltext;
	int i;
	void Awake()
		{
			Instance=this;
		}
    void Start()
    {
		Application.targetFrameRate = 0;
		Time.timeScale =1f;
		coins=false;
		fail=false;
		complete=false;
		levels[MenuScene.LevelNo].SetActive(true);
		GameObject StartpositionTruck=GameObject.Find("truckpos");
		truck[store.carNumber-1].transform.position=StartpositionTruck.transform.position;
		truck[store.carNumber-1].transform.rotation=StartpositionTruck.transform.rotation;
		GameObject StartpositionTrailer=GameObject.Find("trailerpos");
		Trailer[MenuScene.LevelNo].transform.position=StartpositionTrailer.transform.position;
		Trailer[MenuScene.LevelNo].transform.rotation=StartpositionTrailer.transform.rotation;
		Trailer[MenuScene.LevelNo].SetActive(true);
		
				if(MenuScene.LevelNo==10)
				{
					map[MenuScene.LevelNo].SetActive(true);
				}
		       if (MenuScene.LevelNo>=20)
		       {
			      //map[MenuScene.LevelNo].SetActive(false);
			     mapnl.SetActive(false);

		       }
		       if (MenuScene.camfar==0){
					// CamTextL.text="2GB Far 200";
					// CamTextR.text="2GB Far 200";
					myCamera.farClipPlane = 150f;
				}
				if(MenuScene.camfar==1){
					// CamTextL.text="4GB Far 300";
					// CamTextR.text="4GB Far 300";
					myCamera.farClipPlane = 180f;
				}
				if(MenuScene.camfar==2){
					// CamTextL.text="Above 4GB Far 400";
					// CamTextR.text="Above 4GB Far 400";
					myCamera.farClipPlane = 220f;
				}
		if (MenuScene.camfar == 3)
		{
			// CamTextL.text="Above 4GB Far 400";
			// CamTextR.text="Above 4GB Far 400";
			myCamera.farClipPlane = 280f;
		}
		if (MenuScene.controlNumber==0){
					control[0].SetActive(true);
					control[1].SetActive(false);
				}
				if(MenuScene.controlNumber==1){
					control[1].SetActive(true);
					control[0].SetActive(false);
				}
		        if (MenuScene.LevelNo == 0)
		        {
	  		       Cart[0].SetActive(true);
		        }
		        if (MenuScene.LevelNo == 1)
		{
			Cart[4].SetActive(true);
		}
		        if (MenuScene.LevelNo == 2)
		{
			Cart[7].SetActive(true);
		}
		        if (MenuScene.LevelNo==5){
						Cart[0].SetActive(true);
					}
				if(MenuScene.LevelNo==6){
						Cart[1].SetActive(true);
					}
                if (MenuScene.LevelNo==8){
						boundry.SetActive(false);
						Cart[2].SetActive(true);
					}
				if(MenuScene.LevelNo==9){
						Cart[3].SetActive(true);
					}
				if(MenuScene.LevelNo==11)
				{
					Cart[4].SetActive(true);
				}
				if(MenuScene.LevelNo==16)
				{
					Cart[5].SetActive(true);
				}
				if(MenuScene.LevelNo==17)
				{
					Cart[6].SetActive(true);
				}
					Move=false;  
    }
    void Update()
    {
			if(RCC_TruckTrailer.exitbarrier)
			{
				coins=false;
				barrier.SetBool("AnimOn",false);
      	barrier.SetBool("AnimOff",true);
				RCC_TruckTrailer.exitbarrier=false;
			
			}


		  
	
	  i = MenuScene.LevelNo + 1;
	  leveltext.text = i.ToString();
	


	}
	void OnTriggerEnter(Collider col)
		{
			if(col.gameObject.tag=="complete"){
			
			controlbtns.SetActive(false);
				StartCoroutine("completecal");
			}
		    if (col.gameObject.tag == "parking")
		{
			effects[0].SetActive(true);
			col.GetComponent<BoxCollider>().enabled = false;
			victorysound.Play();
			controlbtns.SetActive(false);
			victorypnl.SetActive(true);
			mapnl.SetActive(false);
			StartCoroutine("completecal");
		}
		    if (col.gameObject.tag=="stop")
			{
				if(	coins==false)
				{
					coins=true;
					gameObject.GetComponent<Rigidbody>().drag=2.0f;
					barrier=col.gameObject.transform.GetChild(0).GetChild(0).gameObject.GetComponent<Animator>();
					CB.coin();
					CB2.coin();
				}
			}
			if(col.gameObject.tag=="fuelfill"){
				Destroy(col.gameObject);
				StartCoroutine("fuelcal");
			}
			if(col.gameObject.tag=="police"){
				Destroy(col.gameObject);
				StartCoroutine("policecal");
			}
			if(col.gameObject.tag=="opndor"){
				col.gameObject.transform.GetComponent<BoxCollider>().enabled = false;
				StartCoroutine("dooropn");
			}
			if(col.gameObject.tag=="turnleft"){
				Destroy(col.gameObject);
				turnleft.SetActive(true);
			}
			if(col.gameObject.tag=="turnright"){
				Destroy(col.gameObject);
				turnright.SetActive(true);
			}
			if(col.gameObject.tag=="gostraight"){
				Destroy(col.gameObject);
				gostraight.SetActive(true);
			}
			if(col.gameObject.tag=="Collider"){
				col.gameObject.transform.GetChild(0).gameObject.GetComponent<BoxCollider>().enabled = true;
			}
			if(col.gameObject.tag=="massDec"){
				Trailer[MenuScene.LevelNo].gameObject.GetComponent<Rigidbody>().mass=3000f;
			}
			if(col.gameObject.tag=="massInc"){
				Trailer[MenuScene.LevelNo].gameObject.GetComponent<Rigidbody>().mass=5000f;
			}
			if(col.gameObject.tag=="fail"){
				CB.fail();
				CB2.fail();
			}
			if(col.gameObject.tag=="attach")
			{
				Destroy(col.gameObject);
				StartCoroutine("attachcall");
			}
	}
	IEnumerator attachcall ()
	{
		attachsound.Play();
		yield return new WaitForSeconds (0.1f);
		gameObject.GetComponent<Rigidbody>().drag=2.5f;
		////if(store.carNumber==2)
		////{
		////	transform.position=Startposition[MenuScene.LevelNo].transform.position;
		////	transform.rotation=Startposition[MenuScene.LevelNo].transform.rotation;
		////}
		//if(store.carNumber==1||store.carNumber==6)
		//{
		//	transform.position=Startposition1[MenuScene.LevelNo].transform.position;
		//	transform.rotation=Startposition1[MenuScene.LevelNo].transform.rotation;
		//}
		//if(store.carNumber==3||store.carNumber==5)
		//{
		//	transform.position=Startposition2[MenuScene.LevelNo].transform.position;
		//	transform.rotation=Startposition2[MenuScene.LevelNo].transform.rotation;
		//}
		//if(store.carNumber==7)
		//{
		//	transform.position=Startposition3[MenuScene.LevelNo].transform.position;
		//	transform.rotation=Startposition3[MenuScene.LevelNo].transform.rotation;
		//}
		//if(store.carNumber==4)
		//{
		//	transform.position=Startposition4[MenuScene.LevelNo].transform.position;
		//	transform.rotation=Startposition4[MenuScene.LevelNo].transform.rotation;
		//}
		transform.position = Startposition[MenuScene.LevelNo].transform.position;
		transform.rotation = Startposition[MenuScene.LevelNo].transform.rotation;
		yield return new WaitForSeconds (1.0f);
		gameObject.GetComponent<Rigidbody>().drag=0.05f;
		Trailer[MenuScene.LevelNo].GetComponent<Rigidbody>().isKinematic = false;
	}
	public void barrierOpn()
	{
		barrier.SetBool("AnimOn",true);
    barrier.SetBool("AnimOff",false);
		gameObject.GetComponent<Rigidbody>().drag=0.05f;
	}
	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.tag=="Collider"){
			col.gameObject.transform.GetChild(0).gameObject.GetComponent<BoxCollider>().enabled = false;
		}
	}
	IEnumerator completecal ()
	{
		controlbtns.SetActive(false);
		yield return new WaitForSeconds (0.5f);
		gameObject.GetComponent<Rigidbody>().drag=5.0f;
		endpoint[MenuScene.LevelNo].SetActive(false);
		yield return new WaitForSeconds (3.0f);
		victorypnl.SetActive(false);
		CB.complete();
		CB2.complete();
	}
	IEnumerator policecal ()
	{
    policemove=true;
		yield return new WaitForSeconds (0.5f);
		gameObject.GetComponent<Rigidbody>().drag=8.0f;
		controlbtns.SetActive(false);
		policecam.SetActive(true);
		rcccam.SetActive(false);
		yield return new WaitForSeconds (2.35f);
		policemove=false;
		policeTalk=true;
		yield return new WaitForSeconds (9.5f);
		policemove1=true;
    policeTalk=false;
		gameObject.GetComponent<Rigidbody>().drag=0.05f;
		policecam.SetActive(false);
		rcccam.SetActive(true);
		controlbtns.SetActive(true);
		yield return new WaitForSeconds (20.0f);
		policeman.SetActive(false);
	}
	IEnumerator dooropn ()
	{
		yield return new WaitForSeconds (0.5f);
		gameObject.GetComponent<Rigidbody>().drag=2.0f;
		yield return new WaitForSeconds (0.5f);
		Move=true;
		door[0].gameObject.transform.GetComponent<Animator>().enabled=true;
		door[1].gameObject.transform.GetComponent<Animator>().enabled=true;
		door[2].gameObject.transform.GetComponent<Animator>().enabled=true;
		door[3].gameObject.transform.GetComponent<Animator>().enabled=true;
		door[4].gameObject.transform.GetComponent<Animator>().enabled=true;
		door[5].gameObject.transform.GetComponent<Animator>().enabled=true;
		yield return new WaitForSeconds (3.0f);
		gameObject.GetComponent<Rigidbody>().drag=0.05f;
	}
	IEnumerator fuelcal ()
	{
		yield return new WaitForSeconds (0.5f);
		gameObject.GetComponent<Rigidbody>().drag=2.0f;
		yield return new WaitForSeconds (0.5f);
		gameObject.GetComponent<Rigidbody>().drag=0.05f;
		CB.fuel();
		CB2.fuel();
	}
	public void BtnControl()
	{
		RCC.SetMobileController(RCC_Settings.MobileController.TouchScreen);
	}
	public void Steer()
	{
		RCC.SetMobileController(RCC_Settings.MobileController.SteeringWheel);
	}
	public void gyroControl()
	{
		RCC.SetMobileController(RCC_Settings.MobileController.Gyro);
	}
	public void speed2x()
    {
		truck[store.carNumber].GetComponent<RCC_CarControllerV3>().engineTorque = 250f;
    }
	
}
