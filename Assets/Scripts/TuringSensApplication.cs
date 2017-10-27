using UnityEngine;

public class TuringSensApplication : MonoBehaviour
{
    [SerializeField] private TuringSensController controller;
    [SerializeField] private TuringSensModel model;
    [SerializeField] private TuringSensView view;

    public TuringSensController Controller { get { return controller; } }
    public TuringSensModel Model { get { return model; } }
    public TuringSensView View { get { return view; } }
}
