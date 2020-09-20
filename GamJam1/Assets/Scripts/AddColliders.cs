using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddColliders : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        AddCollider(transform);
    }
    void AddCollider(Transform trans)
    {
        foreach (Transform child in trans)
        {
            child.gameObject.AddComponent<MeshCollider>();
            if(child.childCount>0)
                AddCollider(child);
        }
    }
}
