using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Live/LiveIntSO", fileName = "LiveIntSO", order = 0)]
public class LiveIntSO : LiveSO<int>
{
    public override void Multiple()
    {
        _value += Multiplier;
    }
}
