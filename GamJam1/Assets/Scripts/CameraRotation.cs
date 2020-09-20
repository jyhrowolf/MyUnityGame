using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public GameObject player;
    private Rigidbody playerBody;
    // Use this for initialization
    void Start()
    {
        playerBody = player.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(playerBody.velocity.x, playerBody.velocity.z);
        offset.Normalize();
        offset = offset * -1;
        
        transform.position = player.transform.position + new Vector3(offset.x, 0, offset.y);
        transform.position = new Vector3(transform.position.x, player.transform.position.y+1.5f, transform.position.z);
        transform.LookAt(new Vector3(player.transform.position.x, player.transform.position.y+0.5f, player.transform.position.z));
    }
}
