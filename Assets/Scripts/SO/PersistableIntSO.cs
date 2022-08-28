using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Persistable/PersistableInt", fileName = "PersistableIntSO", order = 0)]
public class PersistableIntSO : LiveSO<int>
{
    [SerializeField] private GameObject obstaclePrefab;
    public override void Multiple()
    {
        _value += Multiplier;

    }
    public void GenerateObstacles(int value, GameObject rotator)
    {
        for (float i = 1; i <= value; i++)
        {
            value = _value;
            var radians = i * 360 / value;
            var vertical = Mathf.Sin(radians);
            var horizontal = Mathf.Cos(radians);
            Vector3 rotatorPos = rotator.transform.position;
            var spawnDir = new Vector3(horizontal, vertical, 0);
            var spawnPos = rotatorPos + spawnDir * 3f;
            var obs = Instantiate(obstaclePrefab, spawnPos, Quaternion.identity, rotator.transform);
            obs.transform.rotation = new Quaternion(0, 0, radians,0);
            //Vector3 r = rotator.transform.position;
            //Vector3 planarRotator = new Vector3(r.x, 0, r.z);
            //Vector3 planarPos = new Vector3(obs.transform.position.x, 0, obs.transform.position.z);
            //float angleBetweenObjects = Vector3.Angle(Vector3.forward, planarRotator - planarPos);
            //Mathf.Abs(angleBetweenObjects);
            //Quaternion finalRot = Quaternion.AngleAxis(angleBetweenObjects, Vector3.forward);
            //obs.transform.rotation = finalRot;
        }
    }
}
