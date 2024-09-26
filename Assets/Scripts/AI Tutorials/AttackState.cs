using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BaseState
{
    public override BaseState RunStateMachine()
    {
        Debug.Log("I have attacked");
        return this;
    }
}