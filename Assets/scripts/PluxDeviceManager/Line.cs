// Copyright (c) 2014, Tokyo University of Science All rights reserved.
// Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met: * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer. * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution. * Neither the name of the Tokyo Univerity of Science nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour
{
    public double divisor = 1;
    public float offsetX, offsetY, offsetZ, lengthX;
    public double currentValue;
    public int bufferSize, valuesInArray;
    public double[] values;

    private LineRenderer line;

    // Use this for initialization
    void Start()
    {
        line = (LineRenderer)this.GetComponent("LineRenderer");
        //line.SetVertexCount(bufferSize); // obsolete
        line.positionCount = bufferSize;
        values = new double[bufferSize];
        valuesInArray = 0;
    }

    /// <summary>
    /// Draw the new point of the line
    /// </summary>
    void Update()
    {
        // Adapted to using values[]
        for (int i = 0; i < bufferSize; i++)
        {
            currentValue = values[i];
            float posX = (float)(-(lengthX / 2f) + lengthX * ((1.0 / bufferSize) * i));
            float posY = (float)((currentValue) / divisor);
            line.SetPosition(i, new Vector3((float)posX + offsetX, (float)posY + offsetY, 0f + offsetZ));
        }
    }

    public void SetNewPoint(double newValue)
    {
        if (valuesInArray >= bufferSize - 1)
        {
            // array is full, shift left
            for (int i = 0; i < bufferSize - 1; i++)
            {
                values[i] = values[i + 1];
            }
            // add new value at the end
            values[bufferSize - 1] = newValue;
        }
        else
        {
            values[valuesInArray] = newValue;
            valuesInArray++;
        }

    }
}
