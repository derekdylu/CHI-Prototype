using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ModFOV : MonoBehaviour
{
    public TMP_Text text;
    public Camera camera;
    public Slider slider;
    //This is the field of view that the Camera has
    float m_FieldOfView;

    void Start()
    {
        //Start the Camera field of view at 60
        m_FieldOfView = 60.0f;
        slider.onValueChanged.AddListener(delegate {ValueChangeCheck(); });
    }

    void Update()
    {
        //Update the camera's field of view to be the variable returning from the Slider
        m_FieldOfView = slider.value;
        camera.fieldOfView = m_FieldOfView;
        text.text = "FOV: " + m_FieldOfView;
    }

    void ValueChangeCheck()
    {
        //This Slider changes the field of view of the Camera between the minimum and maximum values
        m_FieldOfView = slider.value;
    }
}
