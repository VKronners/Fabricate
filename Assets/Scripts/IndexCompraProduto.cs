using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndexCompraProduto : MonoBehaviour {
    private void Start()
    {
        int i;
        for (i = 0; i < gameObject.transform.childCount; i++)
        {
            if (gameObject.transform.GetChild(0).GetComponent<Aco>() != null)
            {

            }
        }

    }
}
