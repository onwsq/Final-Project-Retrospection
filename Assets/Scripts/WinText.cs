using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
    // Start is called before the first frame update
    Text winText;
    
    void Start()
    {
        winText = GetComponent<Text>();
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneController.won == true) {
            winText.enabled = true;
        }
    }
}
