using UnityEngine;
using System.Collections;

public class EnemyShip : Ship
{
	private Transform target;
	public bool canFireAtPlayer;
	// Use this for initialization
	void Start()
	{
		target = FindObjectOfType<PlayerShip>().transform;

	}

	// Update is called once per frame
	void FlyTowardsPlayer()
	{
		Vector2 directionToFace = new Vector2(targetPosition.x - transform.position.x, targetPosition.y - transform.position.y);

		transform.up = directionToFace;
		Thrust();

	}
}
void Update()
{  FlyTowardsPlayer
}
