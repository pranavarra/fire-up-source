using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShopScript : MonoBehaviour
{
    public Image[] rArr;
    public static int rInt = 0;
    public Image mIm;
    public int[] prices;
    public GameObject buyBtn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mIm.sprite = rArr[rInt].sprite;
    }

    public void Left()
    {
        if (rInt != 0)
        {
            rInt -= 1;
        }
    }

    public void Right()
    {
        if (rInt != (rArr.Length - 1))
        {
            rInt += 1;
        }
    }

    public void Back()
    {
        SceneManager.LoadScene("Home");
    }

    public void Sel()
    {
        SceneManager.LoadScene("Home");
    }
}
