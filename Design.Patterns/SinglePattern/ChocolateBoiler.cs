using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SinglePattern
{
    public class ChocolateBoiler
    {
        private Boolean _empty;
        private Boolean _boiled;

        private static volatile ChocolateBoiler _chocolateBoilerInstance;

        private ChocolateBoiler()
        {
            _empty = true;
            _boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_chocolateBoilerInstance == null)
            {
                lock (typeof(ChocolateBoiler))
                {
                    if (_chocolateBoilerInstance == null)
                    {
                        _chocolateBoilerInstance = new ChocolateBoiler();
                    }
                }
            }
            return _chocolateBoilerInstance;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                _empty = true;
            }
        }

        public void Boild()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
            }
        }

        private bool IsBoiled()
        {
            return _boiled;
        }

        private bool IsEmpty()
        {
            return _empty;
        }
    }
}