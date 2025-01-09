using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    Camera m_Camera;

    void Start(){
        m_Camera = Camera.main;
    }

    void Update() 
    {
        Vector3 targetVector = this.transform.position - m_Camera.transform.position;
        targetVector.y= 0;
        transform.rotation = Quaternion.LookRotation(targetVector, m_Camera.transform.rotation * Vector3.zero);
    }
}
