using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyWin : MonoBehaviour
{

    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = "Enemy OK!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        text.GetComponent<Text>().text = "Enemy Win!";
        print("TEST");
    }

}
