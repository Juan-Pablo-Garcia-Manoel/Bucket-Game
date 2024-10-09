using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> prefabs;
    public Vector3 originPoint = new Vector3(0, 0, 0);
    public float interval = 1;
    private float cooldown = 0;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }

        cooldown -= Time.deltaTime;
        if (cooldown < 0f)
        {
            cooldown = interval;
            spawnBall();
        }
    }

    private void spawnBall()
    {
        int prefabIndex = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];

        float gameWidth = GameManager.Instance.gamewidth;
        float xOffSet = Random.Range(-gameWidth / 2f, gameWidth / 2f);

        Quaternion rotation = prefab.transform.rotation;

        Vector3 position = originPoint + new Vector3(xOffSet, 29, 60);

        Instantiate(prefab, position, rotation);
    }
}
