using System;
using System.Text;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] artistAndSong = input.Split(':');

                string artist = artistAndSong[0];
                string song = artistAndSong[1];

                bool isArtistValid = true;



                for (int i = 1; i < artist.Length; i++)
                {
                    char currentChar = artist[i];

                    if (char.IsUpper(artist[0]))
                    {
                        isArtistValid = true;
                    }
                    else
                    {
                        isArtistValid = false;
                        break;
                    }

                    if (char.IsLower(currentChar) || currentChar == '\'' || currentChar == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        isArtistValid = false;
                        break;
                    }
                }

                bool isSongValid = true;

                for (int i = 0; i < song.Length; i++)
                {
                    char currentChar = song[i];

                    if (char.IsUpper(currentChar) || currentChar == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        isSongValid = false;
                    }
                }


                if (isArtistValid && isSongValid)
                {
                    int encryptionKey = artist.Length;
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < input.Length; i++)
                    {
                        char currentChar = input[i];

                        if (currentChar == ':')
                        {
                            sb.Append('@');
                        }
                        else if (currentChar == ' ')
                        {
                            sb.Append(' ');
                        }
                        else if (currentChar == '\'')
                        {
                            sb.Append('\'');
                        }
                        else
                        {
                            if (char.IsUpper(currentChar))
                            {
                                if (currentChar + encryptionKey > 90)
                                {
                                    currentChar = (char)(((currentChar + encryptionKey) - 90) + 64);
                                }
                                else
                                {
                                    currentChar = (char)(currentChar + encryptionKey);
                                }
                                sb.Append(currentChar);
                            }
                            else if (char.IsLower(currentChar))
                            {
                                if (currentChar + encryptionKey > 122)
                                {
                                    currentChar = (char)(((currentChar + encryptionKey) - 122) + 96);
                                }
                                else
                                {
                                    currentChar = (char)(currentChar + encryptionKey);
                                }
                                sb.Append(currentChar);
                            }
                        }
                    }

                    Console.WriteLine($"Successful encryption: {sb.ToString()}");

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
