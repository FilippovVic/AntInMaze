using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour
{
    private bool _needChange;

    private void Start()
    {
        _needChange = false;
    }

    public void Configure(int value)
    {
        if (AudioListener.volume != 0)
        {
            AudioListener.volume = value;
            _needChange = true;
        }
    }

    public void Continue(int value)
    {
        if (_needChange)
        {
            AudioListener.volume = value;
            _needChange = false;
        }
    }
}