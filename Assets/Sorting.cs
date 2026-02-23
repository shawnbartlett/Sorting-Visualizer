using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sorting : MonoBehaviour
{   
    public GameObject barPrefab;
    public GameObject[] bars;
    public Transform bar;
    int [] numbers = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        buildStartingBars();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            System.Array.Sort(numbers); // FIXME: Temporary 
        }
        
        animateLerpBars();
    }

    void buildStartingBars()
    {
        bars = new GameObject[numbers.Length];
        // FIXME: Refactor into clean methods later
        for (int x = 0; x < numbers.Length; x++)
        {
            numbers[x] = Random.Range(1,6);
        
             bars[x] = Instantiate(barPrefab);
            
            bars[x].transform.localScale = new Vector3(bars[x].transform.localScale.x, numbers[x], bars[x].transform.localScale.z);
            bars[x].transform.position = new Vector3(x * 0.3f, numbers[x] / 2f, 0);
        }
    }

    void animateLerpBars()
    {
        for (int x = 0; x < numbers.Length; x++){
        
            float y = Mathf.Lerp(bars[x].transform.localScale.y, numbers[x], 3f * Time.deltaTime);

            bars[x].transform.localScale = new Vector3(bar.transform.localScale.x, y, bars[x].transform.localScale.z);
            bars[x].transform.position = new Vector3(x * 0.3f, y / 2f, 0);
        }
    }
}
