﻿using System;

namespace ApplicationToLearnTest
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public float Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
