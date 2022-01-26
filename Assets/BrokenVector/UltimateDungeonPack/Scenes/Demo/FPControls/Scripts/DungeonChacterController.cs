/* 
 * author : jiankaiwang
 * description : The script provides you with basic operations of first personal control.
 * platform : Unity
 * date : 2017/12
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonChacterController : MonoBehaviour
{

    public float speed = 10.0f;
    public float sprintSpeed = 1000f;
    private float translation;
    private float straffe;

    // Use this for initialization
    void Start()
    {
        // turn off the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {

        float speedModifier = 1;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedModifier = sprintSpeed;
        }
        else
        {
            speedModifier = speed;
        }
        // Input.GetAxis() is used to get the user's input
        // You can furthor set it on Unity. (Edit, Project Settings, Input)
        translation = Input.GetAxis("Vertical") * speedModifier * Time.deltaTime;
        straffe = Input.GetAxis("Horizontal") * speedModifier * Time.deltaTime;
        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }
    }
}