// PIP angle of the hand is NOT related to the MCP angle. In order to accurately measure MCP and DIP angle,
// each finger requires two sensors. Until this is implemented, it is assumed that MCP and DIP angle
// are related so that a single sensor value can be used to bend the finger.
// attach the script to each PIP bone
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pip_bend : MonoBehaviour
{
    public Transform MCP; // attach MCP -- the MCP bone can be seen in the hierearchy!

    void Start()
    {

    }

    void Update()
    {
        Vector3 newRotation = new Vector3((2* MCP.eulerAngles.x), 0, 0);
       gameObject.transform.eulerAngles = newRotation;
    }
}
