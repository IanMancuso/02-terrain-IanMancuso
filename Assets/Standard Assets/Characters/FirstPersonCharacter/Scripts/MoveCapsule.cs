using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{

   
    public Vector3 moveVector = new Vector3(0, 0, 0);
    public int normalSpeed = 5;
    public int sprintSpeed = 12;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = sprintSpeed;
        } else {
            speed = normalSpeed;
        }
    }
}
