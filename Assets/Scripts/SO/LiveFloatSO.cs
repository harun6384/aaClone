using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Live/LiveFloatSO", fileName = "LiveFloatSO", order = 0)]
public class LiveFloatSO : LiveSO<float>
{
    public override void Multiple()
    {
        _value *= Multiplier;
    }
}
