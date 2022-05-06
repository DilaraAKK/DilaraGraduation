using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // public PlayerScript playerScript;
    public Transform player;
    // public Rigidbody playerRig;
    // public Collision collisionn;
    // public Collider colliderr;
    public Vector3 offset;
    public Vector3 angleOffset;

    public Vector3 newOffset;
    public Vector3 newAngleOffset;
    // public Vector3 lastPosition;
    // public Quaternion lastRotation;

    void Start()
    {
        // playerScript = GameObject.FindWithTag("Player").GetComponent<PlayerScript>();
        //  Vector3 lastPosition = Vector3.Lerp(transform.position, player.position + newOffset, Time.deltaTime * 0.3f);
        // Quaternion lastRotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(player.eulerAngles + newAngleOffset), Time.deltaTime * 0.3f); 
    }
    void FixedUpdate()
    {

        transform.position = Vector3.Lerp(transform.position, player.position + offset, Time.deltaTime * 5);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(player.eulerAngles + angleOffset), Time.deltaTime * 5);

    }

}






// transform.position = Vector3.Lerp(transform.position, player.position + newOffset, Time.deltaTime * 0.3f);
// transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(player.eulerAngles + newAngleOffset), Time.deltaTime * 0.3f);







