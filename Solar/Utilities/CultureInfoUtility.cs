﻿using System.Globalization;

namespace Solar.Utilities
{
    public static class CultureInfoUtility
    {
        public static readonly TextInfo TextInfo = new CultureInfo("nl-BE").TextInfo;
    }
}
