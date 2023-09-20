using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public void OnMove(InputAction.CallbackContext context)
    {
        Vector2 contextValue = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
        contextValue.y = transform.position.y;
        transform.position = contextValue;
    }
}
