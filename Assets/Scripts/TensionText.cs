using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TensionText : MonoBehaviour
{
    // Start is called before the first frame update

    Text tensionText;
    void Start()
    {
        tensionText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tensionText.text = "Tension: " + TensionBehavior.tensionCount.ToString();
    }
}
