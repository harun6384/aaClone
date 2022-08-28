using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _pinPrefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
    }

    private void SpawnPin()
    {
        Instantiate(_pinPrefab, transform.position, transform.rotation);
    }
}
