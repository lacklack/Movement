using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInputProvider : IInputProvider {
    public Vector3 MoveInput { get; set; }
    public bool JumpButton { get; set; }
    public bool JumpButtonDown { get; set; }


    public Vector2 GetMovementInput() {
        return MoveInput;
    }

    public bool GetJumpButton() {
        return JumpButton;
    }

    public bool GetJumpButtonDown() {
        return JumpButtonDown;
    }
}
