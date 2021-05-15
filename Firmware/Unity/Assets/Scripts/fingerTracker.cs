// the script establishes a serial communication with arduino and reads the sensor value of each finger
// which is used to bend the finger in unity
// attch to each MCP except pinky

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fingerTracker : MonoBehaviour
{
    public string receivedstring; // string to store incoming value from arduino
    public int flat_val, bend_val; // caliberate the finger position at flat and bend position
    public int fingerNo; //thumb = 0, index = 1, middle =2 and ring =3
    public int val_in = 0, angle = 0; // val_in reads the parsed value from arduino and angle
                                      // shows the converted angle for each finger. Use for debugging.

    void Start()
    {

    }

    void Update()
    {
        receivedstring = ArduinoParse.receivedstring;
        string[] ard_val = receivedstring.Split(',');
        val_in = int.Parse(ard_val[fingerNo]); // to distinguish values for each finger. Values are sent
                                           // from arduino in the corresponding format

        if (val_in - angle < -7 || val_in - angle > 7) // filter to eliminate small fluctuation in value
        {
            transform.localEulerAngles = new Vector3(1 * (val_in - flat_val) * 80 / (bend_val - flat_val) , 0,0);
            angle = val_in;
        }
    }
}
