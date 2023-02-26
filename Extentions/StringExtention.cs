using System.Text;

namespace Extentions
{
	public static class StringExtention
	{
		public static string RemoveSpecialCharacters(this string str)
		{
			StringBuilder sb = new StringBuilder();
			foreach (char c in str)
			{
				if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
				{
					sb.Append(c);
				}
			}
			return sb.ToString();
		}
		public static string RemoveSpecialChars(this string str)
		{
			// Create  a string array and add the special characters you want to remove
			string[] chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";", "_", "(", ")", ":", "|", "[", "]" };
			//Iterate the number of times based on the String array length.
			for (int i = 0; i < chars.Length; i++)
			{
				if (str.Contains(chars[i]))
				{
					str = str.Replace(chars[i], "");
				}
			}
			return str;
		}
	}
}