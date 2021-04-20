using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickBehavior : MonoBehaviour

{
    [SerializeField] public float speed = 10f;
    void Start() {
    }
    void Update() {
        transform.Translate(speed*Input.GetAxis("Horizontal")*Time.deltaTime,speed*Input.GetAxis("Vertical")*Time.deltaTime,0f);

        if(Input.GetKeyDown(KeyCode.E)) {
            transform.Rotate(0f,0f,speed*Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Q)) {
            transform.Rotate(0f,0f,-speed * Time.deltaTime);
        }

        }
 }
