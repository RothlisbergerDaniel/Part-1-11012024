using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, -speed * Time.deltaTime);
    }
}
