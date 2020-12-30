using Algorithms.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmServices.Sorting
{
    public interface ISortingAlgorithmService
    {
        long[] SelectionSort(InputRequestDto inputRequestDto);
    }
}
