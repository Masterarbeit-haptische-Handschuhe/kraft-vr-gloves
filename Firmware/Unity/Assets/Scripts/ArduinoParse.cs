// this script connects to arduino and reads the value coming from arduino. This value is strored in 
// a public string "receivedstring" which can be accessed by any script

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports; // to establish serial communication. if this doesnt work, check out the end of the script
public class ArduinoParse : MonoBehaviour
{
    SerialPort stream = new SerialPort("COM7", 9600); //change COM7 to your arduino port
    public static string receivedstring;
    // Start is called before the first frame update
    void Start()
    {
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        receivedstring = stream.ReadLine();
    }
}
//Hi, your problem is the .net configuration, use the .NET 2.0 (not subset) and will connect. I was able to transmit data, but not to receive. Config is into Edit>ProjectSettings>Player>ApiCompatibilityLevel.