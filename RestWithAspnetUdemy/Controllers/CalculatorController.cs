using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspnetUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum/{firstNumber}/{secondNumber}")]  
        public IActionResult Get(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input");
        }

        private decimal ConvertToDecimal(string strtNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strtNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                    strNumber,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.NumberFormatInfo.InvariantInfo,
                    out number
                    );
            return isNumber;
        }
    }
}
