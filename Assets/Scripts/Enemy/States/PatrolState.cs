using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : BaseState
{
    public int waypointIndex;
    public override void Enter()
    {

    }
    public override void Perform()
    {
        PatrolCycle();
    }
    public override void Exit()
    {

    }

    public void PatrolCycle()
    {
        if(!enemy.CanSeePlayer())
        {
            if(enemy.Agent.remainingDistance < 0.2f)
            {
                if(waypointIndex < enemy.path.waypoints.Count - 1)
                    waypointIndex++;
                else
                    waypointIndex = 0;
                enemy.Agent.SetDestination(enemy.path.waypoints[waypointIndex].position);
            }
        }
        
        else
        {
            enemy.Agent.SetDestination(enemy.player.transform.position);
        }
    }
}
