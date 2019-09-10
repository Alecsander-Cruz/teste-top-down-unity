using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public GameObject       player;
    Vector3                 mousePos;
    playerController        pC;
    Camera                  camera;
    bool                    followPlayer = true;
    //public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        pC = player.GetComponent<playerController>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            followPlayer = false;
            pC.setIsMoving(false);
        }else
        {
            followPlayer = true;
        }
        if (followPlayer == true)
        {
            cameraFollowPlayer();
        }else
        {
            freeLook();
        }
    }

    void cameraFollowPlayer()
    {
        Vector3 newPosition = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
        this.transform.position = newPosition;
    }

    void freeLook()
    {
        Vector3 camPos = camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
        camPos.z = -10f;

        Vector3 dir = camPos - this.transform.position;

        if(player.GetComponent<SpriteRenderer>().isVisible == true)
        {
            transform.Translate(dir * 2* Time.deltaTime);
        }
    }
}
