using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Sound))]
public class LocatorDistance : MonoBehaviour
{
    [SerializeField] private Transform _boomb;
    private Sound _sound;
    private bool _playSound = true;
    private float _timeDelay;
    private void Start()
    {
        _sound = GetComponent<Sound>();
    }
    private void Update()
    {
        if(_playSound)
        {
            _timeDelay = Vector2.Distance(transform.position, _boomb.position);
            StartCoroutine(nameof(LounthSound));
        }
    }
    private IEnumerator LounthSound()
    {
        _playSound = false;
        _sound.PlayBoom();
        yield return new WaitForSeconds(_timeDelay);
        _playSound = true;
    }
}
