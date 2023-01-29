using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSpawner : MonoBehaviour
{
    public int amountToSpawn = 30;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < amountToSpawn; i++)
        {
            GameObject textOBJ = new GameObject($"Item {i}");
            textOBJ.transform.parent = transform;
            textOBJ.AddComponent<TextMeshProUGUI>();
            textOBJ.GetComponent<TextMeshProUGUI>().text = $"Item {i}";
        }
    }
}
