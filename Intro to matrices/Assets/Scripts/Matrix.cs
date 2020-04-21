using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Matrix
{
    float[] values;
    int row, col;

    public Matrix(int _r, int _c, float[] v)
    {
        row = _r;
        col = _c;
        values = new float[row * col];
        Array.Copy(v, values, row * col);
    }

    public Coords AsCoord()
    {
        if(row == 4 && col == 1)
        {
            return new Coords(values[0], values[1], values[2], values[3]);
        }
        else
        {
            return null;
        }
    }

    public override string ToString()
    {
        string matrix = "";
        for(int r =0; r < row; r++)
        {
            for (int c = 0; c < col; c++)
            {
                matrix += values[r * col + c] + " ";
            }
            matrix += "\n";
        }
        return matrix;
    }

    static public Matrix operator+ (Matrix a, Matrix b)
    {
        if (a.row != b.row || a.col != b.col)
        {
            return null;
        }
        else
        {
            Matrix result = new Matrix(a.row, a.col, a.values);
            int length = a.row * a.col;
            for(int i= 0; i < length; i++)
            {
                result.values[i] += b.values[i];
            }
            return result;
        }
    }

    static public Matrix operator* (Matrix a, Matrix b)
    {
        if (a.col != b.row)
        {
            return null;
        }

        float[] resultValues = new float[a.row * b.col];

        for (int i = 0; i < a.row; i++)
        {
           
           for (int j = 0; j < b.col; j++)
           {

               for (int k = 0; k < a.col; k++)
               {

                    resultValues[i * b.col + j] += a.values[i * a.col + k] * 
                                                  b.values[k * b.col + j];
               }
           }
        }
        Matrix result = new Matrix(a.row, b.col, resultValues);
        return result;
        }
}
