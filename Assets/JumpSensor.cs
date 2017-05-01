using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSensor : MonoBehaviour {
    private int TouchedCount = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        TouchedCount++;
        //Debug.Log("in");
    }

    void OnTriggerExit2D(Collider2D other)
    {
        TouchedCount--;
        //Debug.Log("out");
    }

    public bool IsCanJump()
    {
        return TouchedCount > 0;
    }

}
