using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerState : IPlayerState
{
    Player mPlayer;
    Rigidbody rbPlayer;

    // Start is called before the first frame update
    public void Enter(Player player)
    {
        Debug.Log("Da ");
        player.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.blue);
        player.mCurrentState = this;
    }

    public void Execute(Player player)
    {
        if (!Input.GetKey(KeyCode.E))
        {
            player.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
            StandingPlayerState standingState = new StandingPlayerState();
            standingState.Enter(player);
        }
    }
}
