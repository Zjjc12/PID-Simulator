using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PidController : MonoBehaviour
{

    [SerializeField]
    GameObject pidObject;

    MovementScript mov;


    // ==== Values That You Have Access To ======================
    float altitude;
    float target;
    // ==========================================================



    // ======== Constants (EDIT) ==========
    [SerializeField]
    float Kp = 1f;
    [SerializeField]
    float Ki = 0f;
    [SerializeField]
    float Kd = 0f;

    float totalError = 0f;
    float lastError;
   
    // =============================




    void Start()
    {
        mov = pidObject.GetComponent<MovementScript>();

        // ======== Code (EDIT) =======================
        lastError = altitude - target;



        // ============================================
    }

    // Update is called once per frame
    void Update()
    {
        // Update values automatically
        altitude = mov.GetAltitude();
        target = mov.GetTarget();


        // Set Power using
        // mov.setPower(10f);


        // ======== Code (EDIT) =======================

        float error = target - altitude;


        float proportional = Kp * error;


        totalError += error;
        float integral = Ki * totalError;

        float derivative = Kd*(error - lastError);
        float power = derivative + integral + proportional;

        mov.setPower(power);

        lastError = error;

        // =============================================
    }
}
