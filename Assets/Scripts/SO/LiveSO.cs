using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LiveSO<T> : ScriptableObject
{
    protected T _value;
    [SerializeField] protected T defaultValue;

    [SerializeField] protected T multiplier;
    public T Multiplier => multiplier;
    protected virtual void OnEnable()
    {
        _value = defaultValue;
    }

    public T Value
    {
        get { return _value; }
        set
        {
            _value = value;
        }
    }
    public void ResetValue()
    {
        Value = defaultValue;
    }
    public abstract void Multiple();
}
