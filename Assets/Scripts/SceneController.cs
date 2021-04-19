using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] public PinBehavior pin1;
    [SerializeField] public PinBehavior pin2;
    [SerializeField] public PinBehavior pin3;

    public static bool won;
    
    // Start is called before the first frame update
    void Start()
    {
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pin1.isUnlocked() && pin2.isUnlocked() && pin3.isUnlocked()) {
            won = true;
        }
    }
}
