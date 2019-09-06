using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{

    public GameObject       player;
    bool                    followPlayer = true;
    //public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followPlayer == true)
        {
            cameraFollowPlayer();
        }
    }

    void cameraFollowPlayer()
    {
        Vector3 newPosition = new Vector3(player.transform.position.x, player.transform.position.y, this.transform.position.z);
        this.transform.position = newPosition;
    }
}
