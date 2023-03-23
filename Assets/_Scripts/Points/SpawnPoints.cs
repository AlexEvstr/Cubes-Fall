using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private GameObject _pointPrefab;

    private float _xPosition = 2.0f;
    private float _yPosition = 6.0f;
    private float _spawnRate;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            _spawnRate = Random.Range(1, 5);
            var point = Instantiate(_pointPrefab);
            point.transform.position = new Vector2(Random.Range(-_xPosition, _xPosition), _yPosition);

            yield return new WaitForSeconds(_spawnRate);
        }

    }
}