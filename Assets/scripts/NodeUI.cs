using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NodeUI : MonoBehaviour
{
    public GameObject ui;
    private Node target;

    public TMP_Text UpgradeCost;
    public Button UpgradeBtn;

    public TMP_Text SellCost;
    public Button SellBtn;

    public void SetTarget(Node _target)
    {
        target = _target;
        transform.position = target.GetBuildPosition();

        if (!target.isUpgraded) {
            UpgradeCost.text = "₽" + target.turretBlueprint.upgradeCost;
            UpgradeBtn.interactable = true;
        }
        else
        {
            UpgradeCost.text = "---";
            UpgradeBtn.interactable = false;
        }

        SellCost.text = "₽" + target.turretBlueprint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide() { 
        ui.SetActive(false); 
    }
    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.Instance.DeselectNode();
    }
    public void Sell()
    {
        target.SellTurret();
        target.isUpgraded = false;
        BuildManager.Instance.DeselectNode();
    }
}
