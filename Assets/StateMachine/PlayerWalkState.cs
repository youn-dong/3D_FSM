using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalkState : PlayerGroundState
{
    public PlayerWalkState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
        
    }
    public override void Enter()
    {
        Debug.Log("걷는 상태 시작");
        stateMachine.MovementSpeedModifier = groundData.WalkSpeedModifier;
        base.Enter();
        StartAnimation(stateMachine.Player.AnimationData.WalkParameterHash);
    }
    public override void Exit()
    {
        Debug.Log("걷기 상태 종료");
        base.Exit();
        StopAnimation(stateMachine.Player.AnimationData.WalkParameterHash);
    }
    protected override void OnRunStarted(InputAction.CallbackContext context)
    {
        Debug.Log("달리기 상태로 전환");
        base.OnRunStarted(context);
        stateMachine.ChangeState(stateMachine.RunState);
    }
}
