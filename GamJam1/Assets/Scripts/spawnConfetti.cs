using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnConfetti : MonoBehaviour
{
    public GameObject ConeConfetti;
    public void Click()
    {
        GameObject ob = Instantiate(ConeConfetti);
        Destroy(ob,3.0f);
    }
}
