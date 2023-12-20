using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject unitGameobject;
    public Inventory inven;
    public bool[] isFull1;
    public GameObject[] slots1;
    public GameObject[] item1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Load();
        }
        
    }

    private void Save()
    {
        Vector3 PlayerPosition = unitGameobject.transform.position;
        
       
    }
    
    private void Load()
    {
        Vector3 PlayerPosition = unitGameobject.transform.position;
       
    }
}
