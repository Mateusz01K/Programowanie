﻿using lab2.nowy.lab3;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers.lab3
{

    [ApiController]
    [Route("[controller]/[action]")]

    public class ShapeController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rectangle = new Rectangle(23,23);
            return rectangle.GetArea();
        }


        [HttpGet]
        public int GetSumArea()
        {
            var rectangle = new Rectangle(23, 23);
            var rectangle2 = new Rectangle(4, 4);
            return rectangle + rectangle2;
        }
    }
}
