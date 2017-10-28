using System.Collections.Generic;
using Pool;
using UnityEngine;

public class CubesController : TuringSensElement
{
    [SerializeField, AssetPathGetter] private string cubePrefabPath;
    [SerializeField] private Transform cubesWrapper;

    private CubesModel cubesModel;
    private const int CUBES_OFFSET = 10;

    protected override void Initialize()
    {
        base.Initialize();
        cubesModel = App.Model.CubesModel;
        App.Controller.ClockController.OnTimerTick += SpawnCube;
        PoolManager.PreWarm<CubeView>(cubePrefabPath, 10);
    }

    private void SpawnCube(object sender, ClockTickArgs args)
    {
        if (args.CurrentTime.Second % 2 != 0)
        {
            return;
        }

        var cube = PoolManager.GetObject<CubeView>(cubePrefabPath);
        cube.transform.SetParent(cubesWrapper, false);
        cubesModel.cubesQueue.Enqueue(cube);
        cube.transform.position += App.View.MainCameraView.transform.forward * (CubeView.CubeBounds.size.x + CUBES_OFFSET) * cubesModel.cubesQueue.Count;
    }
}
