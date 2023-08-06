using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] private int _level;
    [SerializeField] private Image _img;

    public void Load()
    {
        StartCoroutine(WaitLoading());
    }

    IEnumerator WaitLoading()
    {
        if (_img.GetComponent<Image>().sprite.name == "Locks_1") {
            yield return new WaitForSeconds(0.5f);
            SceneManager.LoadScene("Level" + _level);
        }
    }
}