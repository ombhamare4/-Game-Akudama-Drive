using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 0.01f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalSpeed = Input.GetAxis("Horizontal");
        float verticalSpeed = Input.GetAxis("Vertical");
        // transform.Translate(horizontalSpeed * moveSpeed * Time.deltaTime, verticalSpeed * moveSpeed * Time.deltaTime,0);
        transform.Translate(new Vector2(horizontalSpeed, verticalSpeed)*moveSpeed * Time.deltaTime);
        // transform.Translate(new Vector3(horizontalSpeed, verticalSpeed, 0) * moveSpeed * Time.deltaTime);
    }
}
