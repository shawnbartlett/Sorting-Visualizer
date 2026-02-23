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
            numbers[x] = Random.Range(1,10);
            Debug.Log(numbers[x]);

            GameObject bar = Instantiate(barPrefab);
            bar.transform.position = new Vector3(x * 0.5f, 0, 0);
            bar.transform.localScale = new Vector3(bar.transform.localScale.x, numbers[0], bar.transform.localScale.z);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
