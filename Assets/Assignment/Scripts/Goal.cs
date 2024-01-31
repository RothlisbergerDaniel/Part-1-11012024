using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    int direction = 1;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) > 3.4)
        {
            direction *= -1; //flip movement direction on edge
        }
        transform.Translate(Vector2.right * speed * direction * Time.deltaTime); //move the goal left and right
        
    }
}
