using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f;

    private float minX = -2.5f;
    private float maxX = 2.5f;
    

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        float h = Input.GetAxis("Horizontal");

        
        Vector2 currentPostion = transform.position;
        if(h < 0)
        {
            //going left
            currentPostion.x -= speed * Time.deltaTime;
        }
        else if(h > 0)
        {
            //going right 
            currentPostion.x += speed * Time.deltaTime;
        }
        if(currentPostion.x < minX)
        {
            currentPostion.x = minX; 
        }
        else if(currentPostion.x > maxX)  
        {
            currentPostion.x = maxX;
        }
        transform.position = currentPostion;
    }
    private void OnTriggerEnter2D(Collider2D target) 
    {
        if (target.tag == "Bomb")
        {
            Time.timeScale = 0f;
        }
    }
}
