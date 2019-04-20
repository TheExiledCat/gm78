using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextScript : MonoBehaviour
{
    public GameObject spn;
    public TextMeshProUGUI t;
    public TextMeshProUGUI t1;
    public TextMeshProUGUI t2;
    int score;
    int ammo;
    private void Start()
    {
        Spawn.OnHit += Score;
    }
    private void Update()
    {
        ammo = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>().ammo;
        t.text = spn.GetComponent<Spawn>().wave.ToString("000");
        t1.text = score.ToString("000");
        t2.text = ammo.ToString("00");
    }
    void Score()
    {
        score += 100;
    }
}
