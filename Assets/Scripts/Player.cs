using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public PlayerSO Data { get; private set; }
    [field : Header("Animations")]
    [field: SerializeField] public PlayerAnimationData AnimationData { get; private set; }

    public Animator Animator { get; private set; }  
    public PlayerController Input { get; private set; }
    public CharacterController Controller { get; private set; }

    private PlayerStateMachine stateMachine;
    // Start is called before the first frame update
    private void Awake()
    {
       
        Animator = GetComponentInChildren<Animator>();
        AnimationData.Initialize();
        Input = GetComponent<PlayerController>();
        Controller = GetComponent<CharacterController>();

        stateMachine = new PlayerStateMachine(this);
        stateMachine.ChangeState(stateMachine.IdleState);

    }

    // Update is called once per frame
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        stateMachine.HandleInput();
        stateMachine.Update();
    }
    private void FixedUpdate()
    {
        stateMachine.PhysicsUpdate();
    }
}
