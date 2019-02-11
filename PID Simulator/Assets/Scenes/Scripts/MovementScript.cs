using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementScript : MonoBehaviour
{
    Rigidbody rb;

    float targetAltitude = 100;
    float currentPower = 0;

    [SerializeField]
    GameObject slider;

    [SerializeField]
    GameObject targetText;

    [SerializeField]
    GameObject currentText;

    [SerializeField]
    GameObject PowerSlider;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        Debug.Log(rb);
    }


    private void Update()
    {
        targetAltitude = slider.GetComponent<Slider>().value;
        targetText.GetComponent<Text>().text = string.Format("{0:N2}", targetAltitude);
        currentText.GetComponent<Text>().text = string.Format("{0:N2}", transform.position.y);
        PowerSlider.GetComponent<Slider>().value = currentPower;

        rb.AddForce(new Vector3(0, currentPower, 0));
        // TESTING  ONLY
        // setPower(targetAltitude);
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
        power = power / 10;
      
        currentPower = power;
    }

}
