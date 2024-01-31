using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    float horizontalInput;
    float currentRotation = 0; //current rotation
    public float speed; //rotation speed
    public float rotationCap; //rotation cap
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        currentRotation += horizontalInput * -speed * Time.deltaTime;
        currentRotation = Mathf.Clamp(currentRotation, -rotationCap, rotationCap);
        transform.rotation = Quaternion.Euler(0, 0, currentRotation); //directly sets rotation. I do it this way so I can cap rotation.

    }
}
