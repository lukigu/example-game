using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Animator anim;
    private float speed = 5.0f;
    private float turnSpeed = 150.0f;
    // Move left right
    private float horizontalInput;
    // Move forward
    private float verticallInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticallInput = Input.GetAxis("Vertical");
        // Move forward
        transform.Translate(Vector3.forward * Time.deltaTime * verticallInput * speed);
        // Rotate car
        transform.Rotate(Vector3.up, Time.deltaTime * horizontalInput * turnSpeed);
        anim.SetFloat("vertical", Input.GetAxis("Vertical"));
    }
}
