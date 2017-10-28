using Pool;
using UnityEngine;

public class CubeView : PoolObject
{
    private static MeshRenderer meshRenderer;

    public static Bounds CubeBounds { get; private set; }

    protected override void Initialize()
    {
        base.Initialize();

        SetCubeBounds();
    }

    private void SetCubeBounds()
    {
        if (meshRenderer != null)
        {
            return;
        }

        meshRenderer = GetComponent<MeshRenderer>();
        CubeBounds = meshRenderer.bounds;
    }

    public override void OnTakenFromPool()
    {
    }

    public override void OnReturnedToPool()
    {
        gameObject.transform.position = -Vector3.right*10000;
    }

    public override void OnPreWarmed()
    {
    }
}
