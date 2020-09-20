using UnityEngine;

public class PlatformTilt : MonoBehaviour
{
    public float MaxTilt = 20.0f;
    public float TSpeed = 25.0f;
    public Vector3 CRotation;
    float Xmax;
    float Xmin;
    float Zmax;
    float Zmin;

    // Start is called before the first frame update
    void Start()
    {
        //Initial Rotation of the platform

        CRotation = this.transform.eulerAngles;

        // Rotation Limits that do not exceed 20 degress in any rotation

        Xmax = CRotation.x + MaxTilt;
        Xmin = CRotation.x - MaxTilt;
        Zmax = CRotation.z + MaxTilt;
        Zmin = CRotation.z - MaxTilt;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotation updates for "w" and "s" keystrokes (Controls already worked out in a 
        // way that made sense to rotate the platform).

        CRotation.x += Input.GetAxis("Vertical") * Time.deltaTime * TSpeed;

        // Rotation updates for "a" and "d" keystrokes (TSpeed is made negative in order to
        // inverse the controls to make "a" shift the platform left and for "d" to shift
        // the platform right instead of vice versa.

        CRotation.z += Input.GetAxis("Horizontal") * Time.deltaTime * -TSpeed;

        CRotation.x = Mathf.Clamp(CRotation.x, Xmin, Xmax);
        CRotation.z = Mathf.Clamp(CRotation.z, Zmin, Zmax);

        // Updates Currrent Angle

        this.transform.eulerAngles = CRotation;
    }
}
