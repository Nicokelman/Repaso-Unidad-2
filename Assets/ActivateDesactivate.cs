using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateDesactivate : MonoBehaviour
{
    public GameObject inputField;
    public bool wasPressed;

    // Start is called before the first frame update
    void Start()
    {
        wasPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateandDesactive()
    {
        if (!wasPressed)
        {
            inputField.SetActive(false);
            wasPressed = true;
        }
        else
        {
            inputField.SetActive(true);
            wasPressed = false;
        }
    }
}
