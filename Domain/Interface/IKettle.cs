﻿namespace ConsoleApp1_HomeWork6.Domain.Interface
{
    public interface IKettle
    {
        public string Volume { get; set; }
        public string Power { get; set; }
        public string Material { get; set; }

        string ToString();
    }
}
