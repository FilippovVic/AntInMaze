using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _timeLeft;
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private GameObject _lostPanel;
    [SerializeField] private GameObject _player;
    [SerializeField] private AudioSource _sound;
    public static float _timeLeftPublic;

    private bool _isTimerOn;

    private void Start()
    {
        _isTimerOn = true;
    }

    private void Update()
    {
        if (_isTimerOn && _timeLeft > 0)
        {
            _timeLeft -= Time.deltaTime;
            _timeLeftPublic = _timeLeft;

            if (_timeLeft < 3.05 && _timeLeft> 2.95 || _timeLeft < 2.05 && _timeLeft > 1.95 || _timeLeft < 1.05 && _timeLeft > 0.95)
            {
                _sound.Play();
            }

            if (_timeLeft < 3)
            {
                _timerText.color = Color.red;
            }
        }
        else
        {
            _timeLeft = 0;
            _lostPanel.SetActive(true);
            Destroy(_player);
            _isTimerOn = false;
        }
        _timerText.text = ((float)Math.Round(_timeLeft, 1)).ToString();
    }
}