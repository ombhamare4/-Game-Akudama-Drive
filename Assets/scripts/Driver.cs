using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float steerSpeed = 300.01f;
   [SerializeField] float moveSpeed = 20.01f;
    void Start()
    {
    
    }
    void Update()
    {
        float SteerAmount = Input.GetAxis("Horizontal")* steerSpeed* Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-SteerAmount );
        transform.Translate(0,moveAmount,0);

    }
}
