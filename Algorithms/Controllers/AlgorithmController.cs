using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Algorithms.Entities;
using AlgorithmServices.Sorting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Algorithms.Controllers
{
    [ApiController]
    [Route("api")]
    public class AlgorithmController : ControllerBase
    {

        #region Injectors

        private readonly ISortingAlgorithmService _sortingAlgorithmService;
        public AlgorithmController(
            ISortingAlgorithmService sortingAlgorithmService
            )
        {
            _sortingAlgorithmService = sortingAlgorithmService;
        }

        #endregion

        public IActionResult SelectionSort(InputRequestDto inputRequestDto) 
        {
            return Ok(_sortingAlgorithmService.SelectionSort(inputRequestDto));
        }
    }
}
