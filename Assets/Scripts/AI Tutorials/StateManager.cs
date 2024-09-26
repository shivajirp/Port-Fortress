using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public BaseState currentState;

    private void Update()
    {
        RunCurrentState();
    }

    private void RunCurrentState()
    {
        BaseState nextState = currentState?.RunStateMachine();

        if (nextState != null )
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(BaseState nextState)
    {
        currentState = nextState;
    }
}
