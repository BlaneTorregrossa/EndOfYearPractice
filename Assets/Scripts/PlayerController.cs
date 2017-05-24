using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Vector3 PlayerPos;
    private Vector3 PreviousPosition;
    private bool ItemColliding = false;


    void Movement()
    {

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.W))
        {
            PlayerPos.z += 0.1f;
            this.transform.position = PlayerPos;
            if (this.transform.position.z >= 4.3f)
            {
                PlayerPos.z -= 0.1f;
                this.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKey(KeyCode.S))
        {
            PlayerPos.z -= 0.1f;
            this.transform.position = PlayerPos;
            if (this.transform.position.z <= -4.3f)
            {
                PlayerPos.z += 0.1f;
                this.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKey(KeyCode.A))
        {
            PlayerPos.x -= 0.1f;
            this.transform.position = PlayerPos;
            if (this.transform.position.x <= -4.3f)
            {
                PlayerPos.x += 0.1f;
                this.transform.position = PlayerPos;
            }
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKey(KeyCode.D))
        {
            PlayerPos.x += 0.1f;
            this.transform.position = PlayerPos;
            if (this.transform.position.x >= 4.3f)
            {
                PlayerPos.x -= 0.1f;
                this.transform.position = PlayerPos;
            }
        }
    }
    
    void Start()
    {
        PlayerPos = this.transform.position;
    }

    void Update()
    {
        Movement();
        PreviousPosition = this.transform.position;
    }
}
