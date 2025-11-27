using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserTurret;
    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.Instance;
    }
    public void SelectStandartTurret()
    {
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectMissileTurret()
    {
        buildManager.SelectTurretToBuild(missileLauncher);
    }

    public void SelectlaserTurret()
    {
        buildManager.SelectTurretToBuild(laserTurret);
    }
}
