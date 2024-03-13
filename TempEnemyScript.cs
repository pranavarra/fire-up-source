using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempEnemyScript : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "plbullet")
        {
            PlayerScript.score += 100f;
            Destroy(Enemy);
        }
    }
}
