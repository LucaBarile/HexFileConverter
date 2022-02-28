using System; // Convert
using System.Linq; // Enumerable
using System.Text; // StringBuilder
using System.IO; // File

namespace HexFileConverter
{
    class Program
    {
        static void Main(string[] args) // args[0] must contain the path of the file to convert 
        {
            if (args.Length == 0 || args.Length > 1) // the program must only receive one argument
                return;

            if (args[0].EndsWith(".hex")) // the user wants to convert the file from the hexadecimal format
                convertFromHex(args[0]);
            else // the user wants to convert the file to hexadecimal format
                convertToHex(args[0]);
        }

        public static void convertFromHex (string filePath)
        {
            string convertedFilePath = filePath.Remove(filePath.Length - 4); // remove .hex

            // format the hexadecimal string in the format required by the hexFileAsByteArray function  
            string wellFormattedHexFileContent = File.ReadAllText(filePath); // contains newline (\r\n) -> https://stackoverflow.com/questions/3986093/in-c-whats-the-difference-between-n-and-r-n
            wellFormattedHexFileContent = wellFormattedHexFileContent.Replace("\r\n", " "); // replace all the \n (new line characters) with one space (" ")
            wellFormattedHexFileContent = wellFormattedHexFileContent.Replace(" ", ""); // remove all spaces between hex values and the last at the end of the file

            // convert the well formatted hexadecimal string into byte array
            // https://stackoverflow.com/questions/321370/how-can-i-convert-a-hex-string-to-a-byte-array
            byte[] hexFileAsByteArray =
                Enumerable.Range(0, wellFormattedHexFileContent.Length) // convert all the hexadecimal file content
                .Where(x => x % 2 == 0) // read one hexadecimal number (two symbols) at a time
                .Select(x => Convert.ToByte(wellFormattedHexFileContent.Substring(x, 2), 16)) // convert it into byte
                .ToArray(); // put all the bytes obtained in an array (hexFileAsByteArray)

            File.WriteAllBytes(convertedFilePath, hexFileAsByteArray); // save the converted file using the byte array 
        }

        public static void convertToHex(string filePath)
        {
            string convertedFilePath = filePath + ".hex"; // add .hex

            byte[] fileToConvertAsByteArray = File.ReadAllBytes(filePath); // read all the bytes of the hexadecimal file

            // convert the byte array to a well formatted string 
            StringBuilder sb = new StringBuilder(fileToConvertAsByteArray.Length * 2);

            for (int i=0, j=1; i<fileToConvertAsByteArray.Length; i++, j++)
            {
                sb.AppendFormat("{0:x2}", fileToConvertAsByteArray[i]); // 1 byte at a time 

                if (j%16 == 0 || j == fileToConvertAsByteArray.Length) // 16 columns | the last character must be a Windows newline (\r\n)
                    sb.Append("\r\n"); // Windows newline -> https://stackoverflow.com/questions/3986093/in-c-whats-the-difference-between-n-and-r-n
                else
                    sb.Append(" "); // each hexadecimal number must be separated by a space 
            }
            string wellFormattedHexFileContent = sb.ToString();

            File.WriteAllText(convertedFilePath, wellFormattedHexFileContent); // save the converted file using the well formatted hexadecimal string
        }
    }
}