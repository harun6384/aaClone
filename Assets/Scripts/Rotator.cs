using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private LiveFloatSO rotationSpeed;
    [SerializeField] private LiveIntSO score;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private PersistableIntSO levelObstacles;

    private void Start()
    {

        levelObstacles.GenerateObstacles(levelObstacles.Value, this.gameObject);
    }

    private void OnEnable()
    {
        EventManager.Instance.OnPinned += OnPinnedHandler;
        scoreText.text = score.Value.ToString();
    }
    private void OnDisable()
    {
        EventManager.Instance.OnPinned -= OnPinnedHandler;
    }

    private void OnPinnedHandler()
    {
        rotationSpeed.Multiple();
        score.Multiple();
        scoreText.text = score.Value.ToString();
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed.Value * Time.deltaTime);
    }
}
