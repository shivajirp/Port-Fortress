using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// BASE CLASS

public abstract class BaseState : MonoBehaviour
{
    public abstract BaseState RunStateMachine(); 
}
