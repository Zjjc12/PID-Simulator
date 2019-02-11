using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PidController : MonoBehaviour
{

    [SerializeField]
    GameObject pidObject;

    Movement mov;


    //Values That You Have Access To
    float altitude;
    float target;

    void Start()
    {
        Movement mov = pidObject.GetComponent<Movement>();      
    }

    // Update is called once per frame
    void Update()
    {
        // Update values automatically
        altitude = mov.GetAltitude();
        target = mov.GetTarget();


        // Set Power using
        mov.setPower(10f);
    }
}
