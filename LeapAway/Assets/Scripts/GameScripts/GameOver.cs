using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public PlayerJumpMechanics _player;
    public PlayerCollisions _playerdead;
    public ScoreIncrement _score;
    [SerializeField]
    private GameObject _gameOverPanel;
    [SerializeField]
    private ParticleSystem _playerParticles;

    private void Start()
    {
        _playerParticles.Stop();
        _gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_player.isGameOver || _playerdead.isGameOver)
        {
            _gameOverPanel.SetActive(true);
            _score._speed = 0f;
            StartCoroutine(BreakPlayer());
            _player.isGameOver = false;
            _playerdead.isGameOver = false;
        }
    }

    IEnumerator BreakPlayer()
    {
        _playerParticles.Play();

        _player.GetComponent<SpriteRenderer>().enabled = false;
        _player.GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(_playerParticles.main.startLifetime.constantMax);
        Destroy(_player.gameObject);
    }
}
