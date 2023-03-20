using TMPro;
using UnityEngine;

public class ScoreViewer : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;
    [SerializeField] private PlayerWallet _wallet;

    private void OnEnable()
    {
        _wallet.CoinAdded += UpdateScore;
    } 

    private void OnDisable()
    {
        _wallet.CoinAdded -= UpdateScore;
    }

    private void UpdateScore()
    {
        _score.text = _wallet.Coins.ToString();
    }
}
