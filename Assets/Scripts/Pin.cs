using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    private Rigidbody2D _rb;
    private bool _isPinned = false;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if(!_isPinned) _rb.MovePosition(_rb.position + Vector2.up * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Rotator rotator))
        {
            InteractWithRotator(rotator);
        }
        if (collision.gameObject.TryGetComponent(out Pin pin))
        {
            InteractWithPin(pin);
        }
    }

    private void InteractWithPin(Pin pin)
    {
        //GameStateManager.Instance.GameFail();
    }

    private void InteractWithRotator(Rotator rotator)
    {
        _isPinned = true;
        transform.SetParent(rotator.transform);
        EventManager.Instance.OnPinned();
    }
}
