using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocator : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        var inputHorizpntal = Input.GetAxis("Horizontal")  * _speed* Time.deltaTime;
        transform.Translate(Vector2.right * inputHorizpntal);
    }
}
