using UnityEngine;
using UnityEngine.UI;

public class HealthBarViewer : MonoBehaviour
{
    [SerializeField] private Warrior _warrior;
    [SerializeField] private Image _bar;

    private void OnEnable()
    {
        _warrior.Hited += OnHealthChanged;
    }

    private void OnDisable()
    {
        _warrior.Hited -= OnHealthChanged;
    }

    private void OnHealthChanged()
    {
        _bar.fillAmount = Mathf.InverseLerp(0, _warrior.MaxHealth, _warrior.Health);
    }
}
