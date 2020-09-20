using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transition : MonoBehaviour
{
    public GameObject oldLevel;
    public GameObject newLevel;
    public GameObject player;
    public bool collided = false;

    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {  
        if(!collided)
            if(Vector3.Distance(player.transform.position,transform.position) <= 1)
            {
                Transition();
            }
    }
    void Transition()
    {
        oldLevel.transform.position = new Vector3(0f,50f,0f);
        player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y+50f,player.transform.position.z);
        Instantiate(newLevel);
        collided = true;
        Destroy(oldLevel,4.0f);
    }
}
