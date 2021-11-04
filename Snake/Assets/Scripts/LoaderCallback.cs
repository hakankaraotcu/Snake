using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{

    private bool firsUpdate = true;

    // Update is called once per frame
    private void Update()
    {
        if (firsUpdate)
        {
            firsUpdate = false;
            Loader.LoaderCallback();
        }
    }
}
