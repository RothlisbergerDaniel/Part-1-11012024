using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 5f;
    public GameObject missilePrefab;
    public Transform turret;
    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(direction * speed * Time.deltaTime, 0, 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //make missile appear
            Instantiate(missilePrefab, turret.position, turret.rotation);
        }
    }
}
