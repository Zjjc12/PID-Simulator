using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Rigidbody rb;

    float targetAltitude = 100;

    [SerializeField]
    GameObject slider;

    [SerializeField]
    GameObject targetText;

    [SerializeField]
    GameObject currentText;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }


    private void Update()
    {
        targetAltitude = slider.GetComponent<Slider>().value;
        targetText.GetComponent<Text>().text = string.Format("{0:N2}", targetAltitude);
        currentText.GetComponent<Text>().text = string.Format("{0:N2}", transform.position.y);

        //TESTING  ONLY
        //setPower(targetAltitude);
    }


    public float GetTarget()
    {
        return targetAltitude;
    }

    public float GetAltitude()
    {
        return transform.position.y;
    }

    public void setPower(float power)
    {
        rb.AddForce(new Vector3(0, power / 10, 0));
    }

}
