using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayScreenManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _playerName;
    [SerializeField] private TextMeshProUGUI _playerScore;
    // Start is called before the first frame update
    void Start()
    {
        _playerName.text = "Player: " + GameManager.Instance.Player.Name;
       
    }

    // Update is called once per frame
    void Update()
    {
        _playerScore.text = "Score: " + GameManager.Instance.Score;
    }
}
