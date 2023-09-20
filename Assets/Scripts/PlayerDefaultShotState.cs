using UnityEngine;

public class PlayerDefaultShotState : PlayerBaseState
{
    float defalutShootingSpeed;
    float addShootingSpeed = 0.2f;

    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Hello World");
        defalutShootingSpeed = player.shootingSpeed;

        player.shootingSpeed = defalutShootingSpeed;
    }

    public override void UpdateState(PlayerStateManager player)
    {
        player.shootingSpeed += defalutShootingSpeed;
        Debug.Log("Updating Shooting speed" +  player.shootingSpeed);
    }

    public override void OnCollisionEnter(PlayerStateManager player)
    {

    }
}
