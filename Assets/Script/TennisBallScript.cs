using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TennisBallScript : MonoBehaviour
{

    private static readonly float destructionThreshold = -10;

    /*private const float destruct = 10f;*/

    private Rigidbody myRigidbody;

    public Vector2 forceObject = new Vector2(10,10);

    // Start is called before the first frame update
    void Start()
    {
        float forceAmountY = Random.Range(forceObject.x, forceObject.y);
        float forceAmountX = forceAmountY * Random.Range(-0.05f, 0.05f);
        float forceAmountZ = forceAmountY * Random.Range(-0.05f, 0.05f);
        Vector3 forceVector = new Vector3(forceAmountX, forceAmountY, forceAmountZ);

        myRigidbody = gameObject.GetComponent<Rigidbody>();
        myRigidbody.AddForce(forceVector, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        if (y <= destructionThreshold)
        {
            Destroy(gameObject);
        }
    }
}
