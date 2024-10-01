using UnityEngine;

public class InvestigateState : IEnemyState
{
    private StatePatternEnemy enemy;
    public InvestigateState(StatePatternEnemy statePatternEnemy)
    {
        enemy = statePatternEnemy;
    }

    public void OnTriggerEnter(Collider other)
    {

    }

    public void ToAlertState()
    {

    }

    public void ToChaseState()
    {
        enemy.currentState = enemy.chaseState;
    }

    public void ToPatrolState()
    {
        enemy.currentState = enemy.patrolState;
    }
    public void ToInvestigateState()
    {

    }

    public void UpdateState()
    {
        Investigate();
    }


    void Investigate()
    {

        // We need to get a vector from enemy eye to player
        // This is the direction we give to raycast
        enemy.indicator.material.color = Color.magenta;
        // Debug ray to visual the eye sight.
        Debug.DrawRay(enemy.eye.position, enemy.transform.forward, Color.green);
        // Raycast
        RaycastHit hit; // hit variable gets all the information where the ray hits. We can call hit.something to get info
        if (Physics.Raycast(enemy.eye.position, enemy.transform.forward, out hit, enemy.sightRange) && hit.collider.CompareTag("Player"))
        {
            // We go here only if the ray hits Player
            // If the ray hits player the enemy sees it and goes instantly to Chase State. And enemy knows what to follow. 
            enemy.chaseTarget = hit.transform;  // Enemy makes sure the chasetarget is Player. 
            enemy.lastSeenPosition = enemy.chaseTarget.position;
            ToChaseState(); // We change our state to chase state. 

        }

        if (Vector3.Distance(enemy.transform.position, enemy.lastSeenPosition) < 0.5f)
        {
            // If Player goes around corner, enemy does not see player.
            ToPatrolState();
        }

    }


}
