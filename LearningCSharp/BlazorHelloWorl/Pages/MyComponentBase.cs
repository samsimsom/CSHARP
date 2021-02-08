using System;
using Microsoft.AspNetCore.Components;

namespace BlazorHelloWorl.Pages
{
    public class MyComponentBase : ComponentBase
    {
        protected int Number { get; set; }
        protected void ButonClickMethod()
        {
            var rnd = new Random();
            Number = rnd.Next();
        }
    }
}