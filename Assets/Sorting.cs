using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorting : MonoBehaviour
{   
    public GameObject barPrefab;
    public Transform bar;
    int [] numbers = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        
        for (int x = 0; x < numbers.Length; x++)
        {
            numbers[x] = Random.Range(1,6);
            

            GameObject bar = Instantiate(barPrefab);
            
            bar.transform.localScale = new Vector3(bar.transform.localScale.x, numbers[x], bar.transform.localScale.z);
            bar.transform.position = new Vector3(x * 0.3f, numbers[x] / 2f, 0);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
