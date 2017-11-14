﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node {
	public Vector2[] vertices;
	public Vector3 position;
	public bool walkable;
	public Node parent;
	public int gCost;
	public int hCost;

	public Node(bool _walkable, Vector3 _position, Vector2 vA, Vector2 vB, Vector3 vC) {
		walkable = _walkable;
		position = _position;
		vertices = new Vector2[3] { vA, vB, vC };
	}

	public int fCost {
		get {
			return gCost + hCost;
		}
	}
}
