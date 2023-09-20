using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerBaseState currentState;
    public PlayerDefaultShotState DefaultShotState = new PlayerDefaultShotState();

    public float shootingSpeed = 1f;

    private void Start()
    {
        currentState = DefaultShotState;

        //"this" is a reference to the context 
        currentState.EnterState(this);
    }

    private void FixedUpdate()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
