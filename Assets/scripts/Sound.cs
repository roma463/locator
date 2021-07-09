using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private AudioSource _boom;
    public void PlayBoom()
    {
        _boom.Play();
    }
}
