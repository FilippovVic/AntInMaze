using UnityEngine;

public class OnButtonClick : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;

    public void OnClick()
    {
        _sound.Play();
    }
}