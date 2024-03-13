using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public AudioSource plAudio;
    public AudioClip expClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            plAudio.clip = expClip;
            plAudio.Play();
            PlayerScript.dead = true;
            //Destroy(other.gameObject);
            //gameScreen.SetActive(false);
            //deathScreen.SetActive(true);
            //Debug.Log("Dead");
        }
    }
}
