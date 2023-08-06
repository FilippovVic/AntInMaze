using System;
using System.Runtime.InteropServices;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
    [SerializeField] private GameObject _secondRate;
    [SerializeField] private GameObject _thirdRate;
    [SerializeField] private float _time3Stars;
    [SerializeField] private float _time2Stars;

    private float _timeForRate;

    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           /* ShowAdv();*/
            gameObject.SetActive(false);
            _winPanel.SetActive(true);
            _timeForRate = (float)Math.Round(Timer._timeLeftPublic, 1);
            if (_timeForRate >= _time3Stars)
            {
                _secondRate.SetActive(true);
                _thirdRate.SetActive(true);
                PlayerPrefs.SetInt("rate", 3);
            }
            else if (_timeForRate >= _time2Stars && _timeForRate < _time3Stars)
            {
                _secondRate.SetActive(true);
                PlayerPrefs.SetInt("rate", 2);
            }
            else
            {
                PlayerPrefs.SetInt("rate", 1);
            }
            Time.timeScale = 0;
        }
    }
}