using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallRise : MonoBehaviour
{
    public GameObject player;
    public float detectDistance;
    public float riseSpeed;
    private Transform pos;
    private float distanceRisen = 0;
    private float dist;

    // Start is called before the first frame update
    void Start()
    {
        pos = player.GetComponent<Transform>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(pos.position,transform.position) <= detectDistance)
            Rise();
        else if(distanceRisen > 0)
            Fall();
    }
    void Rise()
    {
        transform.position += transform.up*Time.deltaTime*riseSpeed;
        distanceRisen += Time.deltaTime*riseSpeed;
    }
    void Fall()
    {
        transform.position -= transform.up*Time.deltaTime*riseSpeed;
        distanceRisen -= Time.deltaTime*riseSpeed;
    }
}
