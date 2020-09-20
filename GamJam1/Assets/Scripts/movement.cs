using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationH;
    private float rotationV;
    public int rotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationH = Input.GetAxis("Horizontal") * rotationSpeed;
        rotationV = Input.GetAxis("Vertical") * rotationSpeed;
    }

    void FixedUpdate()
    {
        transform.Rotate(-rotationV, 0, rotationH,Space.World);
    }
}
