using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBrowser : MonoBehaviour
{
    public void ButtonClick(string strain)
    {
        Application.OpenURL("https://www.leafly.com/search?q=strawberry%20banana&page=1");
    }
}
