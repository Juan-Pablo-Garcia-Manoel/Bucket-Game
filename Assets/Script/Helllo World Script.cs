using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HellloWorldScript : MonoBehaviour
{
    public float Speed = 0.1f ;

    // Start is called before the first frame update
    void Start()
    {

        /*Retorna no nome do objeto em console*/
        string nameObject = gameObject.name;
        Debug.Log($"Hello World; from {nameObject} with speed {Speed}");

    }

    // Update is called once per frame
    void Update()
    {
        /*Objetivo: Aumentar o Z do transform ao passar do tempo*/

        transform.position += new Vector3(0,Speed * Time.deltaTime ,0);
        
    }
}
