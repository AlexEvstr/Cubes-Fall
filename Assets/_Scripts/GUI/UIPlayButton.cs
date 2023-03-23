using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlayButton : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void Onclick()
    {
        _startPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
