using UnityEngine;
using System.Collections;

public class TractorPoint : MonoBehaviour
{

	public GameObject[] Truck;

	void Update ()
	{
		transform.position = new Vector3 (Truck[store.carNumber-1].transform.position. x, 1436f,Truck[store.carNumber-1].transform.position. z);
		transform.rotation = Quaternion.Euler(0, Truck[store.carNumber-1].transform.rotation.eulerAngles.y, 0);
	}
}
