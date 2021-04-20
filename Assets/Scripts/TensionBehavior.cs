using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TensionBehavior : MonoBehaviour
{
    public static int tensionCount;
    
    // Start is called before the first frame update
    void Start()
    {
        tensionCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(tensionCount<0) {
            tensionCount = 0;
        }
        else if(tensionCount>10) {
            tensionCount = 10;
        }
        
        if(Input.GetKeyDown(KeyCode.Comma)) {
            transform.Translate(-1f,0f,0f);
            tensionCount--;
        }

        if(Input.GetKeyDown(KeyCode.Period)) {
            transform.Translate(1f,0f,0f);
            tensionCount++;
        }
    }

    public int GetTensionCount() {
        return tensionCount;
    }
}
