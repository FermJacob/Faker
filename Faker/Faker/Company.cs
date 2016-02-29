﻿//-----------------------------------------------------------------------
// <copyright file="Company.cs">
//     Copyright (c) 2016 Jacob Ferm, All rights Reserved
// </copyright>
//-----------------------------------------------------------------------
using System.Collections.Generic;

namespace Faker
{
    /// <summary>
    /// Static company class
    /// </summary>
    public static class Company
    {
        // Logo
        private static List<string> name;
        private static object catchPhraseLock = new object();
        private static object catchPhrasePreLock = new object();
        private static List<string> catchPhrasePre;
        private static List<string> suffix;
        private static List<string> sector;
        private static List<string> industry;
        private static List<string> catchPhraseMid;
        private static object catchPhraseMidLock = new object();
        private static List<string> catchPhrasePos;
        private static object catchPhrasePosLock = new object();

        /// <summary>
        /// Gets a suffix value
        /// </summary>
        /// <returns>String of suffix</returns>
        public static string Suffix()
        {
            if (suffix == null)
            {
                suffix = XML.GetListString("Company", "Suffix");
            }

            return suffix[Number.RandomNumber(0, suffix.Count - 1)];
        }

        /// <summary>
        /// Gets a random sector
        /// </summary>
        /// <returns>A string value</returns>
        public static string Sector()
        {
            if (sector == null)
            {
                sector = XML.GetListString("Company", "Sector");
            }

            return sector[Number.RandomNumber(0, sector.Count - 1)];
        }

        /// <summary>
        /// Gets a random industry
        /// </summary>
        /// <returns>A string value</returns>
        public static string Industry()
        {
            if (industry == null)
            {
                industry = XML.GetListString("Company", "Industry");
            }

            return industry[Number.RandomNumber(0, industry.Count - 1)];
        }

        /// <summary>
        /// Gets a random symbol
        /// </summary>
        /// <returns>A string value</returns>
        public static string Symbol()
        {
            string val = string.Empty;
            for (int i = 0; i < Number.RandomNumber(3, 5); i++)
            {
                val += Utilities.Character();
            }

            return val.ToUpper();
        }

        /// <summary>
        /// Method to get a catch phrase
        /// </summary>
        /// <returns>String of catch phrase</returns>
        public static string CatchPhrase()
        {
            return CatchPhrasePre() + CatchPhraseMid() + CatchPhrasePos();
        }

        /// <summary>
        /// Gets the pre catch phrase
        /// </summary>
        /// <returns>String value</returns>
        public static string CatchPhrasePre()
        {
            lock (catchPhrasePreLock)
            {
                if (catchPhrasePre == null)
                {
                    catchPhrasePre = XML.GetListString("Company", "CatchPre");
                }

                return catchPhrasePre[Number.RandomNumber(0, catchPhrasePre.Count - 1)];
            }
        }

        /// <summary>
        /// Gets the mid catch phrase
        /// </summary>
        /// <returns>String value</returns>
        public static string CatchPhraseMid()
        {
            lock (catchPhraseMidLock)
            {
                if (catchPhraseMid == null)
                {
                    catchPhraseMid = XML.GetListString("Company", "CatchPre");
                }

                return catchPhraseMid[Number.RandomNumber(0, catchPhraseMid.Count - 1)];
            }
        }

        /// <summary>
        /// Gets the post catch phrase
        /// </summary>
        /// <returns>String value</returns>
        public static string CatchPhrasePos()
        {
            lock (catchPhrasePosLock)
            {
                if (catchPhrasePos == null)
                {
                    catchPhrasePos = XML.GetListString("Company", "CatchPre");
                }

                return catchPhrasePos[Number.RandomNumber(0, catchPhrasePos.Count - 1)];
            }
        }

        private static string Name()
        {
            if (name == null)
            {
                name = XML.GetListString("Company", "Name");
            }

            return name[Number.RandomNumber(0, name.Count - 1)];
        }
    }
}
