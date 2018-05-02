using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    public static HealthBar Instance;
    public float currEnergy;
    public float currRep { get; set; }
    public float maxEnergy = 100;
    public float maxRep = 100;

    public Transform energyBar;
    public Transform repBar;

    void Start()
    {
        Instance = this;
        energyBar.GetComponent<Image>().color = new Color(0, 1, 0);
        currEnergy = currRep = 60;
        repBar.GetComponent<Image>().color = new Color(0, 1, 0);

    }

    void Update()
    {
        if(currEnergy < 60)
        {
            energyBar.GetComponent<Image>().color = new Color(1, 1, 0);
        }
        if (currEnergy < 50)
        {
            energyBar.GetComponent<Image>().color = new Color(1, 0, 0);
        }
        energyBar.GetComponent<RectTransform>().localScale = new Vector3((currEnergy / maxEnergy) * 0.5515254f, 0.1067707f, 1);
        if (currRep < 60)
        {
            repBar.GetComponent<Image>().color = new Color(0, 0, 1);
        }
        if (currRep < 50)
        {
            repBar.GetComponent<Image>().color = new Color(1, 0, 0);
        }
        repBar.GetComponent<RectTransform>().localScale = new Vector3((currRep / maxRep) * 0.5515254f, 0.1067707f, 1);
    }

}
