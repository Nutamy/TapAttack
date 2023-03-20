using System;
using UnityEngine;
using UnityEngine.UI;

public class ClickerHandler : MonoBehaviour
{
    [SerializeField] private Button _clickerButton;
    public event Action Cliked;

    private void OnEnable()
    {
        _clickerButton.onClick.AddListener(OnCliked);
    }

    private void OnDisable()
    {
        _clickerButton.onClick.RemoveListener(OnCliked);
    }

    private void OnCliked()
    {
        Cliked?.Invoke();
        Debug.Log("Clik");
    }
}
