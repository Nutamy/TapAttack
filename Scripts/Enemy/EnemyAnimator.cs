using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private Enemy _enemy;

    private const string DieAnimation = "Die";
    private const string AttackAnimation = "Attack";

    private void OnEnable()
    {
        _enemy = GetComponent<Enemy>();

        _enemy.Died += OnDied;
        _enemy.AttackAnimated += OnAttacked;
    }

    private void OnDisable()
    {
        _enemy.Died -= OnDied;
        _enemy.Attacked -= OnAttacked;
    }
    private void OnAttacked()
    {
        _animator.SetTrigger(AttackAnimation);
    }

    private void OnDied()
    {
        _animator.SetTrigger(DieAnimation);
    }
}
