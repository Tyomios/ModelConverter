using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelConverter
{
	/// <summary>
	/// Класс перевода десятичных чисел в двоичные
	/// </summary>
    public static class NumberConverter
    {

	    /// <summary>
		/// Преобразования отрицательных чисел
		/// </summary>
		/// 
		/// <param name="result">
		/// Модуль отрицательного числа в двоичной системе
		/// </param>
		/// 
		/// <returns>
		/// Отрицательное число в двоичной системе
		/// </returns>
	    private static char[] BinaryNegative(char[] result)
	    {
		    for (int i = 0; i < result.Length; i++)
		    {
			    if (result[i] == '0')
			    {
				    result[i] = '1';
			    }
			    else
			    {
				    result[i] = '0';
			    }
		    }

		    if (result[result.Length - 1] == '0')
		    {
			    result[result.Length - 1] = '1';
			    return result;
		    }

		    int j = 1;
		    while (result[result.Length - j] == '1')
		    {
			    result[result.Length - j] = '0';
			    ++j;
		    }

		    result[result.Length - j++] = '1';
		    return result;
	    }

	    /// <summary>
		/// Перевод десятичного целого числа в двоичное
		/// </summary>
		/// 
		/// <param name="number">
		/// Десятичное целое число
		/// </param>
		/// 
		/// <returns>
		/// Двоичное представление числа
		/// </returns>
        public static string ConvertToBinary(int number)
        {
	        string binaryNumber = "";
	        bool isNegative = true ? number < 0 : false;

	        while (number != 0)
	        {
		        if (number % 2 == 1 || number % 2 == -1)
		        {
			        binaryNumber += "1";
		        }

		        if (number % 2 == 0)
		        {
			        binaryNumber += "0";
		        }

		        number /= 2;
	        }

	        char[] result = binaryNumber.ToCharArray();
			Array.Reverse(result);

			if (isNegative)
			{
				result = BinaryNegative(result);
			}

			binaryNumber = "";

			for (int i = 0; i < result.Length; i++)
			{
				binaryNumber += result[i];
			}
			return binaryNumber;
        }
    }
}
