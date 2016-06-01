using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App4.Model
{
    public class Calc
    {
        public int A;
        public int B;
        public int Result;

        public int Div() {  System.Diagnostics.Debug.WriteLine(A + B);  return A / B;  }
        public int Add() { return A + B; }
        public int Sub() { return A - B; }
        public int Mult() { return A * B; }

    }
}
