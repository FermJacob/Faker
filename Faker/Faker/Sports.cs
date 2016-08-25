﻿//-----------------------------------------------------------------------
// <copyright file="Sports.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using Faker.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Faker
{
    /// <summary>
    /// Static class for sport generation
    /// </summary>
    public static class Sports
    {
        private static object sportTypeLock = new object();
        private static List<string> sportType;

        /// <summary>
        /// Grab a random sport type
        /// </summary>
        /// <returns>A <see cref="string"/></returns>
        public static string SportType()
        {
            lock (sportTypeLock)
            {
                if (sportType == null)
                {
                    sportType = XML.GetListString("Sports", "Names");
                }

                return sportType[Number.RandomNumber(0, sportType.Count - 1)];
            }
        }

        /// <summary>
        /// Gets a list of sport types
        /// </summary>
        /// <returns>A <see cref="List{T}"/></returns>
        public static List<string> SportTypes()
        {
            int number = Number.RandomNumber(1, 10);
            return number.Times(x => SportType()).ToList();
        }

        /// <summary>
        /// Gets a list of sport types
        /// </summary>
        /// <param name="number">Number of times</param>
        /// <returns>A <see cref="List{T}"/></returns>
        public static List<string> SportTypes(int number)
        {
            return number.Times(x => SportType()).ToList();
        }
    }
}
