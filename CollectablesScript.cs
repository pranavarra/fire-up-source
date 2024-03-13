using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesScript : MonoBehaviour
{
    public int numCollectables = 30;
    public Vector3 vectorMinLimits;
    public Vector3 vectorMaxLimits;
    public GameObject collectablesPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numCollectables; i++)
        {

            Vector3 tempPos = new Vector3(Random.Range(vectorMinLimits.x, vectorMaxLimits.x), Random.Range(vectorMinLimits.y, vectorMaxLimits.y), 0f);
            GameObject colObj = collectablesPrefab;
            Quaternion vecRot = Quaternion.Euler(0f, 0f, Random.Range(-360f, 360f));
            //Debug.Log(i.ToString());
            Instantiate(colObj, tempPos, vecRot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
