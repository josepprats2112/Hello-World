using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_controller : MonoBehaviour
{
    public Text newText;

    // Start is called before the first frame update
    void Start()
    {
        newText.text = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Josep Prats!";
        }

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    }
}
