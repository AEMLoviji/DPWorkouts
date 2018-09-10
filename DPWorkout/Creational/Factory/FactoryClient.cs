﻿using System;

namespace DPWorkout.Creational.Factory
{
    class FactoryClient
    {
        public void GetInformationAboutCountry()
        {
            Console.WriteLine($"{nameof(FactoryClient)} ran with {nameof(AzerbaijanFactory)}");
            GetCountryDataInternal(new AzerbaijanFactory());

            Console.WriteLine("\n *** Switching to another Factory implementation *** \n");

            Console.WriteLine($"{nameof(FactoryClient)} ran with {nameof(BelarusFactory)}");
            GetCountryDataInternal(new BelarusFactory());

        }

        private void GetCountryDataInternal(CountryFactory country)
        {
            Console.WriteLine(country.GetCapital());
            Console.WriteLine(country.GetPopulation());
        }
    }
}
