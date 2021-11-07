using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public List<GameObject> menus = new List<GameObject>();

    int cur = 0;
    int last = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeNext(int i)
    {
        if (cur == last)
        {
            cur = i;
        }
        else
        {
            last = cur;
            cur = i;
        }

        foreach (GameObject g in menus)
        {
            g.SetActive(false);
        }
        menus[i].SetActive(true);
    }

    public void ChangeLast()
    {
        foreach (GameObject g in menus)
        {
            g.SetActive(false);
        }
        menus[last].SetActive(true);
    }
}
