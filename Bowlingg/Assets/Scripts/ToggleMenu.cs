using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMenu : MonoBehaviour
{
    public InputActionReference toggleReference = null;

    void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    // Update is called once per frame
    void OnDestroy()
    {
        toggleReference.action.started -= Toggle;

    }

    void Toggle(InputAction.CallbackContext context)
    {
        bool isActive = !gameObject.activeSelf;
        gameObject.SetActive(isActive);
    }
}
