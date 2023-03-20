using DG.Tweening;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Transform _target;

    private const float Duration = 1f;

    public void Init(Transform target)
    {
        _target = target;
        Move();
    }

    private void Move()
    {
        var tween = transform.DOMove(_target.position, Duration);
        tween.OnComplete(Destroy);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
