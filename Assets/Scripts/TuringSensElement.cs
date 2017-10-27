using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuringSensElement : MonoBehaviour {

	public TuringSensApplication App { get { return FindObjectOfType<TuringSensApplication>(); } }

    protected virtual void Initialize() {}
}
