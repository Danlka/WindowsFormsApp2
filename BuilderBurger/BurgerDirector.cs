using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.BuilderBurger
{
    internal class BurgerDirector
    {
        private readonly IBurgerBuilder _builder;

        public BurgerDirector(IBurgerBuilder builder)
        {
            _builder = builder;
        }

        public void BuildDefault()
        {
            _builder
            .AddCheese()
            .AddTomato().
            AddPickles();
        }

        public void BuildWithBeacon()
        {
            _builder
            .AddCheese()
            .AddTomato()
            .AddPickles();
        }
    }
}
