﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupShield : MonoBehaviour
{
      public int time;

      void OnTriggerEnter(Collider other)
      {
            if (other.gameObject.CompareTag("Player"))
            {
                  var player = other.gameObject.GetComponent<Player>();
                  player.AddShield(time);
                  Destroy(gameObject);
            }
      }
}
