using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject CubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(CubePrefab);

        GameObject cubeGO = Instantiate<GameObject>(CubePrefab);
        Material mat = cubeGO.GetComponent<Renderer>().material;
        mat.color = Random.ColorHSV(0,1,0.5f,1,0.75f,1);
    }
}
