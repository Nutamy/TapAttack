using System;
using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    private Warrior _player;

    public int Coins { get; private set; }

    public event Action CoinAdded;

    private void OnEnable()
    {
        _player = GetComponent<Warrior>();
        _player.Attacked += AddCoin;
    }

    private void OnDisable()
    {
        _player.Attacked -= AddCoin;
    }

    private void AddCoin()
    {
        Coins++;
        CoinAdded?.Invoke();
    }
}
