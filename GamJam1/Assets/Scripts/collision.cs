using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    void Awake()
    {
        addMesh(transform);
    }
    void addMesh(Transform trans)
    {
        foreach(Transform child in trans) {
             child.gameObject.AddComponent<MeshCollider>();
             if (child.childCount > 0) {
                 addMesh(child);
             }
         }
    }
}
