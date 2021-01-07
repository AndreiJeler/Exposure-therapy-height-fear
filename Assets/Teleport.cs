using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject fps;
    public Transform AndreiTown;
    public Transform Manhatanstur;
    public Transform OraselulLenes;
    public Transform Elevator;
    public Transform FirstFloor;
    public Transform SecondFloor;
    public Transform ThirdFloor;
    public Transform FinalFloor;
    public Transform EasterEggLoc;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            fps.transform.position = AndreiTown.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            fps.transform.position = Manhatanstur.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            fps.transform.position = OraselulLenes.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            fps.transform.position = Elevator.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            fps.transform.position = FirstFloor.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            fps.transform.position = SecondFloor.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F7))
        {
            fps.transform.position = ThirdFloor.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F8))
        {
            fps.transform.position = FinalFloor.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            fps.transform.position = EasterEggLoc.transform.position;
        }
    }
}
