using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundState
{
    public PlayerIdleState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        
        stateMachine.MovementSpeedModifier = 0f;
        base.Enter();
        StartAnimation(stateMachine.Player.AnimationData.IdleParameterHash);
    }
    public override void Exit()
    {
        Debug.Log("정지 상태 종료됨.");
        base.Exit();
        StopAnimation(stateMachine.Player.AnimationData.IdleParameterHash);
    }
    public override void Update()
    {
        base.Update();

        if(stateMachine.MovementInput != Vector2.zero)
        {
            Debug.Log("입력상태 확인");
            stateMachine.ChangeState(stateMachine.WalkState);
            return;
        }
    }
}
