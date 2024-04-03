using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillsController : MonoBehaviour
{
    //public List<HealthPill> pills = new List<HealthPill>();
    public GameObject redPills;
    public Transform[] redPillContainers;
    public bool[] isContainerFull;

    private void InitHealth()
    {
        Debug.Log("Init Begun!");
        isContainerFull = new bool[redPillContainers.Length];
        Debug.Log(redPillContainers.Length);
        Debug.Log(isContainerFull.Length);

        for (int i = 0; i < redPillContainers.Length; i++)
        {
            Debug.Log($"Cycle {i} has Begun.");
            Instantiate(redPills, redPillContainers[i].position, Quaternion.identity);
            isContainerFull[i] = true;
        }
    }

    public void LoseOneHealth()
    {
        for(int i = redPillContainers.Length; i > 0; i--)
        {

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InitHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
