using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 vectorMinLimits;
    public Vector3 vectorMaxLimits;
    public int maxE;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxE; i++)
        {
            Vector3 starPos = new Vector3(Random.Range(vectorMinLimits.x, vectorMaxLimits.x), Random.Range(vectorMinLimits.y, vectorMaxLimits.y), 0f);
            GameObject e = enemyPrefab;
            e.transform.Rotate(0f, 0f, Random.Range(-45f, 45f));
            //Debug.Log(i.ToString());
            Instantiate(e, starPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
