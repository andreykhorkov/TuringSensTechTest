using System.Collections;
using Pool;
using UnityEngine;

public class CubesController : TuringSensElement
{
    [SerializeField, AssetPathGetter] private string cubePrefabPath;
    [SerializeField] private Transform cubesWrapper;
    [SerializeField] private float cubesOffset = 10;
    [SerializeField] private float timeToReposition = 2;
    [SerializeField] private int spawnCubesEveryNth = 2;

    private CubesModel cubesModel;
    private Vector3 prevCubePos;

    protected override void Initialize()
    {
        base.Initialize();
        cubesModel = App.Model.CubesModel;
        App.Controller.ClockController.OnTimerTick += SpawnCube;
        PoolManager.PreWarm<CubeView>(cubePrefabPath, 10);
    }

    private void SpawnCube(object sender, ClockTickArgs args)
    {
        if (args.CurrentTime.Second % spawnCubesEveryNth != 0)
        {
            return;
        }

        CubeView cube;

        if (cubesModel.cubesQueue.Count >= 10)
        {
            cube = cubesModel.cubesQueue.Dequeue();
            StartCoroutine(Reposition());
        }
        else
        {
            cube = PoolManager.GetObject<CubeView>(cubePrefabPath);
        }

        cubesModel.cubesQueue.Enqueue(cube);
        SetCubePosition(cube);
    }

    private void SetCubePosition(CubeView cube)
    {
        cube.transform.SetParent(cubesWrapper);  
        cube.transform.localPosition = prevCubePos - cubesWrapper.forward * (CubeView.CubeBounds.size.x + cubesOffset);
        prevCubePos = cube.transform.localPosition;
    }

    private IEnumerator Reposition()
    {
        yield return new WaitForSeconds(0.2f); // to see whats going on with the pool

        var tagetPos = cubesWrapper.localPosition + cubesWrapper.forward*(CubeView.CubeBounds.size.x + cubesOffset);
        float time = 0;

        while (time < timeToReposition)
        {
            time += Time.deltaTime;
            cubesWrapper.localPosition = Vector3.Lerp(cubesWrapper.localPosition, tagetPos, time / timeToReposition);
            yield return null;
        }
    }
}
