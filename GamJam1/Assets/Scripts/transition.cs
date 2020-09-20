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
        oldLevel.transform.position = transform.up*50;
        player.transform.position = transform.up*50;
        Instantiate(newLevel);
    }
}
