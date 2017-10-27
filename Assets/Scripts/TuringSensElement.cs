using UnityEngine;

public class TuringSensElement : MonoBehaviour
{ 
	public TuringSensApplication App { get; private set; }

    void Start()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        App = FindObjectOfType<TuringSensApplication>();
    }
}
