using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class MockDbService : IDbService
    {
        private List<Climate> climates = new List<Climate>();

        public MockDbService()
        {
            for (int x = 0; x < 20; x++)
            {
                climates.Add(new Climate
                {
                    Time = DateTime.Now,
                    AirTemp = Rnd.New(),
                    WaterTemp = Rnd.New(),
                    Humidity = Rnd.New(),
                    WaterDepth = Rnd.New(),
                });
            }
        }
        public void Delete(Climate climate)
        {
            climates.Remove(climate);
        }

        public IEnumerable<Climate> GetAll()
        {
            return climates;
        }

        public void Save(Climate climate)
        {
            if (!climates.Contains(climate))
            {
                climates.Add(climate);
            }
        }
    }

    static class Rnd
    {
        private static readonly Random rnd = new Random();
        public static decimal New()
        {
            return rnd.Next(0, 100);
        }
    }
}
