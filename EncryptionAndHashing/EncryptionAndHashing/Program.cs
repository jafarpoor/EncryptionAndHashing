// See https://aka.ms/new-console-template for more information


//Encryption
using EncryptionAndHashing;

var key = "b14ca5898a4e4133bbce2ea2315a1916";

//Console.WriteLine("Please enter a secret key for the symmetric algorithm.");  
//var key = Console.ReadLine();  

Console.WriteLine("Please enter a string for encryption");
var str = Console.ReadLine();
var encryptedString = AesOperation.EncryptString(key, str);
Console.WriteLine($"encrypted string = {encryptedString}");

var decryptedString = AesOperation.DecryptString(key, encryptedString);
Console.WriteLine(decryptedString);

//
//Console.WriteLine("Please enter a password to use:");
//string password = Console.ReadLine();
//Console.WriteLine("Please enter a string to encrypt:");
//string plaintext = Console.ReadLine();
//Console.WriteLine("");

//Console.WriteLine("Your encrypted string is:");
//string encryptedstring = EncryptStringSample.Encrypt(plaintext, password);
//Console.WriteLine(encryptedstring);
//Console.WriteLine("");

//Console.WriteLine("Your decrypted string is:");
//string decryptedstring = EncryptStringSample.Decrypt(encryptedstring, password);
//Console.WriteLine(decryptedstring);
//Console.WriteLine("");

//hash
string plainData = "faezeh";
Console.WriteLine("Raw data: {0}", plainData);
string hashedData = HashConsoleApp.ComputeSha256Hash(plainData);
Console.WriteLine("Hash {0}", hashedData);
Console.WriteLine(HashConsoleApp.ComputeSha256Hash("faezeh"));

Console.ReadKey();