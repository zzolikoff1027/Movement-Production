using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Dog;
    public GameObject Minotaur;
    public GameObject Kobold;

    public void Start()
    {

    }
    public void SpawnDog()
    {
        Instantiate(Dog);
    }

    public void SpawnMinotaur()
    {
        Instantiate(Minotaur);
    }

    public void SpawnKobold()
    {
        Instantiate(Kobold);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
