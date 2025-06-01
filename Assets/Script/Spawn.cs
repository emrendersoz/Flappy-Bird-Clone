using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Kus KusScript;
    public GameObject Borular;
    public float height;
    private void Start()
    {
        StartCoroutine(SpawnObject());
    }
    public IEnumerator SpawnObject()
    {
        while (!KusScript.isDead)
        {
            Instantiate(Borular, new Vector3(0.4f, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
    
}
