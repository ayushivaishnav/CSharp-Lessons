﻿using Microsoft.AspNetCore.Mvc;

namespace MVCAPP2.Controllers
{
	public class CalculatorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public int Add(int x, int y)
		{
			return x + y;
		}
	}
}
