using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TallPlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;

    // Start is called before the first frame update
    public void Enter(Player player)
    {
        Debug.Log("Entering State: Tall");
        rbPlayer = player.GetComponent<Rigidbody>();
        rbPlayer.transform.localScale *= 2.0f;
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.W))
        {
            rbPlayer.transform.localScale *= 0.5f;
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rbPlayer.transform.localScale *= 0.5f;
            BabyJumpState babyjumpState = new BabyJumpState();
            babyjumpState.Enter(player);
        }
    }
}
