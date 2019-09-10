using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    private bool        isMoving = false;
    public float        speed = 5f; 
    public Animator     playerWalk;
    

    // Start is called before the first frame update
    void Start()
    {
        playerWalk = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving == true)
        {
            moving();
        }
        movingCheck();
        
    }

    public void setIsMoving(bool moving)
    {
        isMoving = moving;
    }

    void moving(){
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate (Vector3.up * speed * Time.deltaTime, Space.World);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate (Vector3.right * speed * Time.deltaTime, Space.World);
            isMoving = true;
        }
    }

    void movingCheck()
    {
        if(Input.GetKey(KeyCode.W) !=true && Input.GetKey(KeyCode.A) !=true && Input.GetKey(KeyCode.S) !=true && Input.GetKey(KeyCode.D) !=true)
        {
            isMoving = false;
            playerWalk.SetBool("isMoving", false);
        }else
        {
            isMoving = true;
            playerWalk.SetBool("isMoving", true);
        }
    }
}
