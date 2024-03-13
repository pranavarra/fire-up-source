using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public GameObject gameCanvas;
    public GameObject pauseCanvas;
    // private PlayerScript plS;
    //private PlayerScript pl;
    // Start is called before the first frame update
    void Start()
    {
        //pl = GameObject.Find("PlayerScript ");//.GetComponent<PlayerScript>();
        //plS = pl.GetComponent<PlayerScript>();
        pauseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        gameCanvas.SetActive(false);
        pauseCanvas.SetActive(true);
    }

    public void ResumeButton()
    {
        Time.timeScale = 1;
        gameCanvas.SetActive(true);
        pauseCanvas.SetActive(false);
    }
    public void Menu()
    {
        SceneManager.LoadScene("Home");
    }
    public void Restart()
    {
        //PlayerScript.dead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
