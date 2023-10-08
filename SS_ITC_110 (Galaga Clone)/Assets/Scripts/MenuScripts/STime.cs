using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class STime : MonoBehaviour
{
    public TextMeshProUGUI countUpText;
    private float countUp;
    
    // Update is called once per frame
    void Update()
    {
        countUp += Time.deltaTime;
        countUpText.text = "Survival time: " + countUp.ToString();
    }
}
