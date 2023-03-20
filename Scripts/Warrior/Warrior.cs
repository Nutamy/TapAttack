using System;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] protected float Damage;
    [SerializeField] protected Warrior _target;

    private float _currentHealth;

    public bool IsAlive {get; private set;} = true;
    public float MaxHealth => _maxHealth;
    public float Health => _currentHealth;

    public event Action Attacked;
    public event Action Hited;
    public event Action Died;

    private void OnEnable()
    {
        SetCurrentHealth();
    }
    public void TakeDamage(float damage)
    {
        if(_currentHealth < damage)
            Die();

        _currentHealth -= damage;

        if(_currentHealth <= 0)
            Die();

        Hited?.Invoke();
    }

    protected void Attack()
    {
        if(IsAlive && _target.IsAlive)
        {
            _target.TakeDamage(Damage);
            Attacked?.Invoke();
        }
    }

    private void Die()
    {
        IsAlive = false;
        Died?.Invoke();
    }

    void SetCurrentHealth()
    {
        _currentHealth = _maxHealth;
    }
}
