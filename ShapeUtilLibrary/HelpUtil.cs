﻿namespace ShapeUtilLibrary
{
    /// <summary>
    /// Вспомогательный класс
    /// </summary>
    public static class HelpUtil
    {
        /// <summary>
        /// Обмен параметров
        /// </summary>
        /// <param name="var1"></param>
        /// <param name="var2"></param>
        public static void SwapVariables(ref double var1, ref double var2)
        {
            double buff = var1;
            var1 = var2;
            var2 = buff;
        }
    }
}