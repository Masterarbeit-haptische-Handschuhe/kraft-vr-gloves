// The pinky always tends to follow the ring finger. A script to make the pinky do that
//  attach the script to MCP bone of the pinky
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class followRing : MonoBehaviour
{
    public Transform ring_MCP; // attach MCP of the ring finger

    void Start()
    {

    }

    void Update()
    {
        Vector3 newRotation = new Vector3((ring_MCP.eulerAngles.x), 0, 0);
        gameObject.transform.eulerAngles = newRotation;
    }
}
