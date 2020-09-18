using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnConfetti : MonoBehaviour
{
    public GameObject ConeConfetti;
    public GameObject Player;
    private Transform pos;
    public void Start()
    {
        pos = Player.GetComponent<Transform>();
    }
    public void Click()
    {
        GameObject ob = Instantiate(ConeConfetti,pos.position,Quaternion.LookRotation(transform.up,-transform.forward));
        Destroy(ob,3.0f);
    }
}
