using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TypesScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ebtn()
    {
        SceneManager.LoadScene("FirstScene");
    }
    public void Mbtn()
    {
        SceneManager.LoadScene("SecondScene");
    }
    public void Hbtn()
    {
        SceneManager.LoadScene("ThirdScene");
    }
    public void Zbtn()
    {
        SceneManager.LoadScene("ZeroScene");
    }
}
