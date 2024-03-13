using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class DeathScript : MonoBehaviour
{
    public Text scoreT;
    public Text numPT;
    private GameObject dS;
    // Start is called before the first frame update
    void Start()
    {
        dS = GameObject.Find("Death");
        // Debug.Log("C"+((int)Math.Round(PlayerScript.score / 10)).ToString());
        //PlayerPrefs.SetInt("M", PlayerPrefs.GetInt("M", 0) + (int)Math.Round(PlayerScript.score / 10));
        PlayerPrefs.SetFloat("Score", PlayerScript.score);
        scoreT.text = "Score: " + Math.Round(PlayerScript.score).ToString();
        numPT.text = "Number of rescued: " + PlayerScript.numP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Menu()
    {
        dS.SetActive(false);
        SceneManager.LoadScene("Home");
    }
    public void Restart()
    {
        PlayerScript.score = 0;
        Time.timeScale = 1f;
        PlayerScript.dead = false;
        PlayerScript.numP = 0;
        dS.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
