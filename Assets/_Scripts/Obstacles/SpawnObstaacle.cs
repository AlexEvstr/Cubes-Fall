using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaacle : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;

    private float _xPosition = 2.0f;
    private float _yPosition = 6.0f;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            var obstacle = Instantiate(_obstaclePrefab);
            obstacle.transform.position = new Vector2(Random.Range(-_xPosition, _xPosition), _yPosition);

            yield return new WaitForSeconds(1);
        }

    }
}
