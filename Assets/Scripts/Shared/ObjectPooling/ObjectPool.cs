﻿using UnityEngine;

/// <summary>
/// Default behavior for game object pool.
/// </summary>
public class ObjectPool : MonoBehaviour, IPooling
{
	[Header("Pool Id")]
	public int id = 0;

	public float instanceID = 0;

	public float InstanceID 
	{
		get => instanceID; 
		set => instanceID = value; 
	}

	public int GetID() => id;
}
