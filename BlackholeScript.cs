using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackholeScript : MonoBehaviour
{
    private Transform bhTrans;
    public Vector3 bhSizeChangeVector;
    // Start is called before the first frame update
    void Start()
    {
        bhTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        bhTrans.localScale += bhSizeChangeVector;
    }
}
