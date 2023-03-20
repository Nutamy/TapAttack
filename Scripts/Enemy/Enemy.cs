using System;
using System.Collections;
using UnityEngine;

public class Enemy : Warrior
{
    private const float Delay = 1f;
    private const float DethDelay = 1f;

    public event Action AttackAnimated;

    void Start()
    {
        StartCoroutine("Attacking");
    }

    private IEnumerator Attacking()
    {
        var waitForSeconds = new WaitForSeconds(Delay);
        var waitForRestart = new WaitForSeconds(DethDelay);

        while(IsAlive && _target.IsAlive)
        {
            yield return waitForSeconds;
            AttackAnimated?.Invoke();
        }
    }
}
