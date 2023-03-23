using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectorPoints : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _gameOverPanel;
    private float _score;

    private void Start()
    {
        _score = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            Destroy(collision.gameObject);
            _score++;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            _gameOverPanel.SetActive(true);
        }
    }

    private void Update()
    {
        _scoreText.text = _score.ToString();
    }
}
