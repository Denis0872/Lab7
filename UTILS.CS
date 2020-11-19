namespace Utils
{
    using System;

    class Utils
    {
		public static void Display(object item)
		{
			IPrintable ip;

			ip = (item as IPrintable);

			if (ip != null)
				ip.Print();
			else
				Console.WriteLine(item.ToString());
		}


		public static bool IsItFormattable(object x)
	{
	
		if (x is IFormattable)
			return true;
		else
			return false;
	}

    }
}
