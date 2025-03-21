using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRunState : PlayerGroundState
{
    public PlayerRunState(PlayerStateMachine stateMachine) : base(stateMachine)
    {

    }
    public override void Enter()
    {
        Debug.Log("달리기 상태");
        stateMachine.MovementSpeedModifier = groundData.RunSpeedModifier;
        base.Enter();
        StartAnimation(stateMachine.Player.AnimationData.RunParameterHash);
    }
    public override void Exit()
    {
        Debug.Log("달리기 상태 종료");
        base.Exit();
        StopAnimation(stateMachine.Player.AnimationData.RunParameterHash);
    }
}
