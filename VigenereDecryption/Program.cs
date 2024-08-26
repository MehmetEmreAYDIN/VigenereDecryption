char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();   //Enter letters of the alphabet in this field
char[] cipherText = "ŞifreliMetin".ToUpper().ToCharArray();   //Enter plain text in this field
char[] key = "Anahtar".ToUpper().ToCharArray();   //Enter the key in this field

int[] keyNums = new int[key.Length];
for (int i = 0; i < keyNums.Length; i++)
{
    keyNums[i] = Array.IndexOf(alphabet, key[i]);
}

string plainText = string.Empty;
for (int i = 0; i < cipherText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, cipherText[i]) - keyNums[i % key.Length]);
    while (ndx < 0) ndx += alphabet.Length;
    plainText += alphabet[ndx];
}
Console.WriteLine(plainText);