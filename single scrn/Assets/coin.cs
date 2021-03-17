using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int coins = 1;
    [SerializeField] private Collider2D playerCheck;
    [SerializeField] private GameManager manager;
    [SerializeField] private LayerMask playerLayers;
    private void Update()
    {
        if (playerCheck.IsTouchingLayers(playerLayers))
        {
            manager.AddScore(coins);
            Destroy(gameObject);
        }
    }
}