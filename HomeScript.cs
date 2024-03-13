using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class HomeScript : MonoBehaviour
{
    public Text highText;
   // public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // coinText.text = "Coins: " + PlayerPrefs.GetInt("M", 0);
        highText.text = "Highscore: " + Math.Round(PlayerPrefs.GetFloat("Score", 0f)).ToString();
    }

    public void PlayB()
    {
        SceneManager.LoadScene("Storyline");
    }

    public void ShipB()
    {
        SceneManager.LoadScene("Store");
    }
}
