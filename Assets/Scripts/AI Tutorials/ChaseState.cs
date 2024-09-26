using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : BaseState
{
    public AttackState attackState;
    public bool InAttackRange;

    public override BaseState RunStateMachine()
    {
        if (InAttackRange)
        {
            return attackState;
        }
        else
        {
            return this;
        }
    }    
}
