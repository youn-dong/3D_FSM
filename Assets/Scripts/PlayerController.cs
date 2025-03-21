using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerInputs playerInputs { get; private set; }
    public PlayerInputs.PlayerActions playerActions { get;private set; }

    // Start is called before the first frame update
    private void Awake()
    {
        playerInputs = new PlayerInputs();
        playerActions = playerInputs.Player;
        playerInputs.Enable();
    }
    private void OnEnable()
    {
    }
    private void OnDisable()
    {
        playerInputs.Disable();
    }
}
