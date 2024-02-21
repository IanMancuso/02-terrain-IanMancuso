using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{

    Animator Animator;
   
    public Vector3 moveVector = new Vector3(0, 0, 0);
    public float normalSpeed = 1.5F;
    private float speed = 0F;
    public float sprintMultiplier = 2F;
    // Start is called before the first frame update
    void Start()
    {
        Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime);
        this.transform.Translate(new Vector3(0,0,1) * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift)) {
            speed = normalSpeed * sprintMultiplier;
            Animator.speed = sprintMultiplier;
        } else {
            speed = normalSpeed;
            Animator.speed = 1;//normalSpeed * 0.66666666666F;
        }
    }
}
