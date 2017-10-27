using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuringSensElement : MonoBehaviour {

	public TuringSensApplication App { get { return GameObject.FindObjectOfType<TuringSensApplication>(); } }

    protected virtual void Initialize() {}
}
