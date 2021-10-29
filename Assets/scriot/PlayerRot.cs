using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRot : MonoBehaviour
{
    public Joystick joystick;
    public float rotateVertical;
    public float rotateHorizontal;
    

    private void FixedUpdate()
    {
        rotateVertical = joystick.Vertical * 2f;
        rotateHorizontal = joystick.Horizontal * -2f;
        transform.Rotate(rotateVertical, 0, rotateHorizontal);
    }
}
