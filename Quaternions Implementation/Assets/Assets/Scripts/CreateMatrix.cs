using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMatrix : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float[] mvals = { 1, 2, 3, 4, 5, 6 };
        Matrix mat1 = new Matrix(2, 3, mvals);
        Debug.Log(mat1.ToString());

        float[] nvals = { 1, 2, 3, 4, 5, 6 };
        Matrix mat2 = new Matrix(3, 2, nvals);
        Debug.Log(mat2.ToString());

        //Matrix ans = mat1 + mat2;
        Matrix ans = mat1 * mat2;
        Debug.Log(ans.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
