// DIP angle of the hand is always related to the PIP angle
// this script bends the DIP according to the bending of PIP
// attach the script to each DIP bone
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dip_bend : MonoBehaviour
{
    public Transform PIP; // attach PIP -- the PIP bone can be seen in the hierearchy!

    void Start()
    {

    }

    void Update()
    {
        Vector3 newRotation = new Vector3((2* PIP.eulerAngles.x), 0, 0);
       gameObject.transform.eulerAngles = newRotation;
    }
}
