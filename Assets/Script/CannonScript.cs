using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public List<GameObject> prefabsBalls;
    public float interval = 1f;
    public float cooldown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0f)
        {
            ShootBall();
            cooldown = interval;
        }
    }

    private void ShootBall()
    {
        var prefab = prefabsBalls[Random.Range(0,prefabsBalls.Count)];
        Instantiate(prefab, transform);
    }

}
