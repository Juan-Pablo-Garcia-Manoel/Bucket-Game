using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerBucketController : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool pressLeft = Input.GetKey(KeyCode.LeftArrow);
        bool pressRight = Input.GetKey(KeyCode.RightArrow);

        Debug.Log($" Left: {pressLeft}, Right {pressRight}");

        float moviment = speed * Time.deltaTime;

        if (pressLeft == pressRight)
        {
            return;

        } else if (pressLeft)
        {
            moviment -= speed;

        } else
        {
            moviment += speed;
        }
        
        transform.position += new Vector3(moviment, 0, 0);
        
        float movimentLimit = GameManager.Instance.gamewidth / 2;

        if (transform.position.x < -movimentLimit)
        {
            transform.position = new Vector3(-movimentLimit, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > movimentLimit)
        {
            transform.position = new Vector3(movimentLimit, transform.position.y, transform.position.z);
        }

    }
}
