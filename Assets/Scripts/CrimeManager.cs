﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CrimeManager : MonoBehaviour {

	public event Action<Vector3, Vector3> onCrimeHappen;
}