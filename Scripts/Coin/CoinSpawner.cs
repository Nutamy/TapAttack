using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _prefab;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Warrior _player;
    [SerializeField] private Transform _scorePosition;

    private void OnEnable()
    {
        _player.Attacked += Spawn;
    }

    private void OnDisable()
    {
        _player.Attacked -= Spawn;
    }

    private void Spawn()
    {
        Coin coin = Instantiate(_prefab, _enemy.transform.position, Quaternion.identity);
        coin.Init(_scorePosition);
    }
}
