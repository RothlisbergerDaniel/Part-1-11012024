using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    int direction = 1;
    public float speed;
    public GameObject ballPrefab; //reference the prefab
    public Transform spawn; //and the spawn
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) > 3.5)
        {
            direction *= -1; //flip movement direction on edge
            transform.Translate(Vector2.right * speed * direction * Time.deltaTime); //pop it out so it doesn't get stuck

        }
        transform.Translate(Vector2.right * speed * direction * Time.deltaTime); //move the goal left and right
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(ballPrefab, spawn.position, spawn.rotation); //spawn a ball in the score pool when the goal is hit
    }
}
