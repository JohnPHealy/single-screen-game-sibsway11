using System;
using System.Collections;
using System.Collectons.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private Collider2d playerCheck;
    [SerializeField] private LayerMask playerLayers;
    [SerializeField] private GameManager manager;


    private void Update()
    {
        if (playerCheck.IsTouchingLayers(playerLayers))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Colision2d other)
    {
        if (other.gameObject.tag == "Player")
        {
    manager.RespawnPlayer();
        }
    }
}