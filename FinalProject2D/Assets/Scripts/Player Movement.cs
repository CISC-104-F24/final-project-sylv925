using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool isWPressed;
    bool isAPressed;
    bool isSPressed;
    bool isDPressed;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        isWPressed = Input.GetKey(KeyCode.W);
        isAPressed = Input.GetKey(KeyCode.A);
        isSPressed = Input.GetKey(KeyCode.S);
        isDPressed = Input.GetKey(KeyCode.D);
        if (isWPressed)
        {
            transform.position = transform.position + new Vector3(0,1,0) * moveSpeed * Time.deltaTime;
        }
        if (isAPressed)
        {
            transform.position = transform.position + new Vector3(-1,0,0) * moveSpeed * Time.deltaTime;
        }
        if (isSPressed)
        {
            transform.position = transform.position + new Vector3(0,-1,0) * moveSpeed * Time.deltaTime;
        }
        if (isDPressed)
        {
            transform.position = transform.position + new Vector3(1,0,0) * moveSpeed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Speed "))
        {
            moveSpeed = moveSpeed * 1.3f;
        }
        if (collision.gameObject.CompareTag("slow"))
        {
            moveSpeed = moveSpeed * 0.7f;
        }
    }
}
