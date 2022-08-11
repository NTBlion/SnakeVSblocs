using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaleGenerator : MonoBehaviour
{
    [SerializeField] private int _taleSize;
    [SerializeField] private Segment _segmentTemplate; 

    public List<Segment> Generate()
    {
        List<Segment> tail = new List<Segment>();

        for (int i = 0; i < _taleSize; i++)
        {
            tail.Add(Instantiate(_segmentTemplate, transform));
        }

        return tail;
    }
}
