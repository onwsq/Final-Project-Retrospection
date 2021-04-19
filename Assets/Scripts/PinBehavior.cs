using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBehavior : MonoBehaviour
{
    [SerializeField] public Material newMat;
    public float randomVal;
    private float randomValPlus;

    public int randTension;

    private float randomValMinus;

    private Rigidbody rb;

    private Renderer ren;

    private int tension;

    public bool unlocked = false;

    void Start()
    {
        randomVal = Random.Range(15.0f,25.0f);
        randTension = Random.Range(0,5);
        randomValPlus = randomVal + 0.5f;
        randomValMinus = randomVal - 0.5f;
        rb = this.GetComponent<Rigidbody>();
        ren = this.GetComponent<Renderer>();
        tension = 0;
        unlocked = false;

    }

    // Update is called once per frame
    void Update()
    {
         tension = TensionBehavior.tensionCount;
         
         if(this.transform.position.y <= randomValPlus && transform.position.y >= randomValMinus && tension == randTension){
            ren.material = newMat;
            rb.constraints = RigidbodyConstraints.FreezeAll;
            unlocked = true;}
    }
    
    public bool isUnlocked() {
        return unlocked;
    }

    }

