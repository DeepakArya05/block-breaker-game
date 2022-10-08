using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleusingmouseDrag : MonoBehaviour
{
    [SerializeField] float MinX = 1f;
    [SerializeField] float MaxX = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.x = Mathf.Clamp(mousePosition.x, MinX, MaxX);
        transform.position = new Vector2(mousePosition.x, 0.27f);
    }
}
