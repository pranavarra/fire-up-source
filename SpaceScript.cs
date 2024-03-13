using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceScript : MonoBehaviour
{
    public Transform cameraTrans;
    public int maxStarNum = 20;
    public Vector3 vectorMinLimits;
    public Vector3 vectorMaxLimits;
    public GameObject starPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxStarNum; i++)
        {
            Vector3 starPos = new Vector3(Random.Range(vectorMinLimits.x, vectorMaxLimits.x), Random.Range(vectorMinLimits.y, vectorMaxLimits.y), 0f);
            GameObject insStar = starPrefab;
            insStar.transform.Rotate(0f, 0f, Random.Range(-45f, 45f));
            //Debug.Log(i.ToString());
            Instantiate(insStar, starPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
