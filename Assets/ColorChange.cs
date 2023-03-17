using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChange : MonoBehaviour
{

    public InputActionReference colorReference = null;

    private MeshRenderer mRenderer = null;
    private float lastValue = 0f;

    private void Awake()
    {
        mRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float value = colorReference.action.ReadValue<float>();
        if(value != lastValue)
        {
            UpdateColor(value);
            lastValue = value;
        }

    }

    private void UpdateColor(float value)
    {
        mRenderer.material.color = new Color(value, value, 0);

    }

}
