﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Enemy"))
		{
			Destroy(collision.gameObject); // Destruye el objeto con el tag "Enemy"
			Destroy(gameObject); // Destruye el proyectil
		}
	}
}
