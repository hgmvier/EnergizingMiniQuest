using UnityEngine;
using UnityEngine.UI;


public class DisplayManager : MonoBehaviour
{

    public Image playerPowerBar;
    public Text playerPowerRatio;
    public Image stationPowerBar;
    public Text stationPowerRatioText;

    private void Update()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        float playerPowerBarRatio;
        float stationPowerBarRatio;
        Battery battery = FindObjectOfType<Battery>();
        GeneratorStation genStation = FindObjectOfType<GeneratorStation>();
        //Calculate ratios:
        playerPowerBarRatio = battery.currentPower / battery.GetMaxPower();
        stationPowerBarRatio = genStation.currentPowerLevel / genStation.GetMaxPowerLevel();

        //Update player UI:
        playerPowerBar.rectTransform.localScale = new Vector3(playerPowerBarRatio, 1f, 1f);
        playerPowerRatio.text = "PLAYER: " + (playerPowerBarRatio * 100).ToString() + "%";

        //Update station UI:
        stationPowerBar.rectTransform.localScale = new Vector3(stationPowerBarRatio, 1f, 1f);
        stationPowerRatioText.text = "STATION: " + (stationPowerBarRatio * 100).ToString() + "%";
    }

}
