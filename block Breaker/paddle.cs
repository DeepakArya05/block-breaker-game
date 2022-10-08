using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    [SerializeField] float ScreenWidthinUnit = 16f;
    [SerializeField] float MinX = 1f;
    [SerializeField] float MaxX = 15f;
    //[SerializeField] float ScreenLengthinUnit = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MousePositioninUnit =  Input.mousePosition.x / Screen.width * ScreenWidthinUnit;
        // Debug.Log(Input.mousePosition.y / Screen.height * ScreenLengthinUnit);
        Vector2 PaddlePosition = new Vector2(MousePositioninUnit,0.27f);
        PaddlePosition.x = Mathf.Clamp(MousePositioninUnit, MinX, MaxX);
        transform.position = PaddlePosition;
    }
}
