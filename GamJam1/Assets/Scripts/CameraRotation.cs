using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    public GameObject player;
    public float speed = 1;
    private Vector3 old;
    // Use this for initialization
    void Start()
    {
        old = player.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(player.transform.position, Vector3.down, speed * Time.deltaTime);
        transform.position += player.transform.position-old;
        old = player.transform.position;
    }
}
