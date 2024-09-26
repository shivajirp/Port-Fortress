using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : BaseState
{
    public ChaseState chaseState;
    public bool CanSeePlayer;

    public override BaseState RunStateMachine()
    {
        if(CanSeePlayer)
        {
            return chaseState;
        }
        else
        {
            return this;
        }
    }
}
