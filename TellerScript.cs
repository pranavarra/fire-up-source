using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TellerScript : MonoBehaviour
{
    public Text chatText;
    int convoIndex = 0;
    string[] chatConvo = {
        "Welcome Commander! As you may have heard, the rebellions have unleashed a deadly, inevitable blackhole.",
        "The ship of allies has been destroyed but, fortunately, the people in it survived by escaping through pods.",
        "You, the leader of Alpha airship, must retrieve the surviving people from their pods while dodging the blackhole.",
        "Beware the blackhole can kill you and the remaining in an instant. Try to avoid it and rescue the others. Good Luck and Godspeed!"
    };
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            chatText.text = chatConvo[convoIndex];
            if (Input.GetKeyDown(KeyCode.Return) && convoIndex != chatConvo.Length-1)
            {
                convoIndex++;
            }
            else if (Input.GetKeyDown(KeyCode.Return) && convoIndex != chatConvo.Length)
            {
            SceneManager.LoadScene("Types");
            }
    }

}
