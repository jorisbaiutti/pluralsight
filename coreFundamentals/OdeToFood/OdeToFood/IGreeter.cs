﻿namespace OdeToFood
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
       
        public string GetMessageOfTheDay()
        {
            return "Hello from the other side";
        }
    }
}