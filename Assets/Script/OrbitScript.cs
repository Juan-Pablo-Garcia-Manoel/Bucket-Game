using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*private Vector3 originalPosition;*/
    public GameObject objectReference;
    public Vector2 frequency;
    public Vector2 distance;

    // Start is called before the first frame update
    void Start()
    {
        /*originalPosition = transform.position;*/
    }

    // Update is called once per frame
    void Update()
    {
        /*var myNumber = Mathf.PingPong(Time.time, 2);*/

        var sin = MathF.Sin( Time.time * frequency.x) * distance.x;
        Debug.Log($"My number: {sin}");

        var cos = MathF.Cos(Time.time * frequency.y) * distance.y;
        Debug.Log($"My number: {cos}");

        var referenceObjectPosition = objectReference.transform.position;
        transform.position = referenceObjectPosition + new Vector3(sin, cos, 0);
        Debug.Log($"My transform position: {transform.position}");
    }
}
