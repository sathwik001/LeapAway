using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerJumpMechanics _player;
    [SerializeField]
    private GameObject _gameOverPanel;

    private void Start()
    {
        _gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.isGameOver)
        {
            _gameOverPanel.SetActive(true);
        }
    }
}
