using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public Text PlScore;
    public int count;
    public float TimeToSpawn = 1f;
    public float TimeBetweenWaves = 1f;
    // Start is called before the first frame update
    void Start()
    {
        PlScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad >= TimeToSpawn)
        {
            count += 5;
            PlScore.text = count.ToString();
            TimeToSpawn = Time.timeSinceLevelLoad + TimeBetweenWaves;
        }
    }
}
