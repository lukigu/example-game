using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Camera))]
public class FollowPlayer : MonoBehaviour
{
    public float turnSpeed = 4.0f;

    public GameObject target;
    private float targetDistance;
    private Vector3 cameraY = new Vector3(0, 1.0f, 0);

    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 0.0f;
    private float rotX;

    void Start()
    {
        targetDistance = Vector3.Distance(transform.position, target.transform.position);
    }

    void Update()
    {
        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);

        // move the camera position
        transform.position = target.transform.position - (transform.forward * targetDistance) + cameraY;
    }
















    //// The target we are following
    //public Transform target;
    //// The distance in the x-z plane to the target
    ////So this would be your offset
    //public float distance = 3.8f;
    //// the height we want the camera to be above the target
    //public float height = 2.8f;
    //// How much we 
    //public float heightDamping = 2.0f;
    //public float rotationDamping = 3.0f;

    //// Place the script in the Camera-Control group in the component menu
    //[AddComponentMenu("Camera-Control/Smooth Follow")]

    //void LateUpdate()
    //{
    //    // Early out if we don't have a target
    //    if (!target) return;

    //    // Calculate the current rotation angles
    //    float wantedRotationAngle = target.eulerAngles.y;
    //    float wantedHeight = target.position.y + height;

    //    float currentRotationAngle = transform.eulerAngles.y;
    //    float currentHeight = transform.position.y;

    //    // Damp the rotation around the y-axis
    //    currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

    //    // Damp the height
    //    currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamping * Time.deltaTime);

    //    // Convert the angle into a rotation
    //    var currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);

    //    // Set the position of the camera on the x-z plane to:
    //    // distance meters behind the target
    //    transform.position = target.position;
    //    transform.position -= currentRotation * Vector3.forward * distance;

    //    // Set the height of the camera
    //    transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);

    //    // Always look at the target
    //    transform.LookAt(target);
    //}





    //public GameObject MainCharakter;
    //private Vector3 offset = new Vector3(0, 3, -3);

    //////////////


    //[SerializeField]
    //private Transform target;

    //private Vector3 offset = new Vector3(0, 5, -12);


    //[SerializeField]
    //private Space offsetPositionSpace = Space.Self;

    //[SerializeField]
    //private bool lookAt = true;

    //private void Update()
    //{
    //    Refresh();
    //}

    //public void Refresh()
    //{
    //    if (target == null)
    //    {
    //        Debug.LogWarning("Missing target ref !", this);

    //        return;
    //    }

    //    // compute position
    //    if (offsetPositionSpace == Space.Self)
    //    {
    //        transform.position = target.TransformPoint(offset);
    //    }
    //    else
    //    {
    //        transform.position = target.position + offset;
    //    }

    //    // compute rotation
    //    if (lookAt)
    //    {
    //        transform.LookAt(target);
    //    }
    //    else
    //    {
    //        transform.rotation = target.rotation;
    //    }
    //}


    //////////////

    //// Use this for initialization
    //void Start()
    //{
    //    //Calculate and store the offset value by getting the distance between the player's position and camera's position.
    //    offset = transform.position - MainCharakter.transform.position;
    //}

    //// LateUpdate is called after Update each frame
    //void LateUpdate()
    //{
    //    // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
    //    transform.position = MainCharakter.transform.position + offset;
    //}

}
