using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    PlayerShootingState currentState;

    public PlayerDefaultState DefaultShotState = new PlayerDefaultState();

    private void Start()
    {
        currentState = DefaultShotState;

        //"this" is a reference to the context 
        currentState.EnterState(this);
    }

    private void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == PowerUps.SpeedUp)
        {
            Destroy(other.gameObject);
            currentState.OnCollisionEnter(this, other.collider);
        }
    }

    public void SwitchState(PlayerShootingState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    public class PowerUps
    {
        public static string SpeedUp = "SpeedUp";
    }
}
