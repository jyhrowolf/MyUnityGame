﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontFall : MonoBehaviour
{
    // Start is called before the first frame update
    public float push = 0.0025f;
    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if(contact.point.y < transform.position.y-push)
            {
                transform.position += new Vector3(0f,push,0f);
            }
        }
    }
}