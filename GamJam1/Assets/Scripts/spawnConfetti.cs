using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnConfetti : MonoBehaviour
{
    public GameObject coneConfetti;
    public GameObject player;
    void OnTriggerEnter(Collider other)
    {
        GameObject ob = Instantiate(coneConfetti,player.transform.position,Quaternion.LookRotation(transform.up,-transform.forward));
        Destroy(ob,3.0f);
    }
}
