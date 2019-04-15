using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextScript : MonoBehaviour
{
    GameObject spn;
    TextMeshProUGUI t;
    private void Start()
    {
        spn = GameObject.Find("Spawner");
        t = GameObject.Find("Wave").GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        t.text = spn.GetComponent<Spawn>().wave.ToString("000");
    }
}
