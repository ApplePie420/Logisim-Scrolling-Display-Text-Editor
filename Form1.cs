using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logisim_display_text_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            charCounter.Text = counter.ToString();
        }

        string[] A = { "3F", "44", "44", "44", "3F" };
        string[] B = { "7F", "49", "49", "49", "36" };
        string[] C = { "3E", "41", "41", "41", "22" };
        string[] D = { "7F", "41", "41", "41", "3E" };
        string[] E = { "7F", "49", "49", "49", "41" };
        string[] F = { "7F", "48", "48", "48", "40" };
        string[] G = { "3E", "41", "41", "49", "2F" };
        string[] H = { "7F", "08", "08", "08", "7F" };
        string[] I = { "00", "41", "7F", "41", "00" };
        string[] J = { "02", "01", "41", "7E", "40" };
        string[] K = { "7F", "08", "14", "22", "41" };
        string[] L = { "7F", "01", "01", "01", "01" };
        string[] M = { "7F", "20", "18", "20", "7F" };
        string[] N = { "7F", "10", "08", "04", "7F" };
        string[] O = { "3E", "41", "41", "41", "3E" };
        string[] P = { "7F", "48", "48", "48", "30" };
        string[] Q = { "3E", "41", "45", "42", "3D" };
        string[] R = { "7F", "48", "4C", "4A", "31" };
        string[] S = { "32", "49", "49", "49", "26" };
        string[] T = { "40", "40", "7F", "40", "40" };
        string[] U = { "7E", "01", "01", "01", "7E" };
        string[] V = { "7C", "02", "01", "02", "7C" };
        string[] W = { "7E", "01", "0E", "01", "7E" };
        string[] X = { "63", "14", "08", "14", "63" };
        string[] Y = { "70", "08", "07", "08", "70" };
        string[] Z = { "43", "45", "49", "51", "61" };

        string[] dot = { "00", "03", "03", "00", "00" };
        string[] comma = { "00", "05", "06", "00", "00" };
        string[] slash = { "02", "04", "08", "10", "20" };
        string[] bracketOpen = { "00", "1C", "22", "41", "00" };
        string[] bracketClose = { "00", "41", "22", "1C", "00" };
        string[] hash = { "14", "7F", "14", "7F", "14" };
        string[] exclamation = { "00", "00", "7D", "00", "00" };
        string[] question = { "20", "40", "45", "48", "30" };
        string[] dash = { "00", "08", "08", "08", "00" };
        string[] dollar = { "12", "2A", "7F", "2A", "14" };
        string[] percent = { "62", "64", "08", "13", "23" };
        string[] carot = { "10", "20", "40", "20", "10" };
        string[] ampersand = { "36", "49", "55", "22", "05" };
        string[] star = { "14", "08", "3E", "08", "14" };
        string[] semicolon = { "00", "35", "36", "00", "00" };
        string[] apostrophe = { "00", "00", "60", "00", "00" };
        string[] squareBracketOpen = { "00", "7F", "41", "41", "00" };
        string[] squareBracketClose = { "00", "41", "41", "7F", "00" };
        string[] pointBracketOpen = { "00", "08", "14", "22", "41" };
        string[] pointBracketClose = { "41", "22", "14", "08", "00" };
        string[] quote = { "00", "70", "00", "70", "00" };
        string[] curlyBracketOpen = { "00", "41", "36", "08", "00" };
        string[] curlyBracketClose = { "00", "08", "36", "41", "00" };

        string[] zero = { "3E", "45", "49", "51", "3E" };
        string[] one = { "00", "21", "7F", "01", "00" };
        string[] two = { "21", "43", "45", "49", "31" };
        string[] three = { "42", "41", "51", "69", "46" };
        string[] four = { "0C", "14", "24", "7F", "04" };
        string[] five = { "72", "51", "51", "51", "4E" };
        string[] six = { "1E", "29", "49", "49", "06" };
        string[] seven = { "60", "47", "48", "50", "60" };
        string[] eight = { "36", "49", "49", "49", "36" };
        string[] nine = { "30", "49", "49", "4A", "3C" };

        string[] smile = { "08", "64", "04", "64", "08" };
        string[] sad = { "02", "64", "04", "64", "02" };
        string[] happy = { "0C", "6A", "0A", "6A", "0C" };
        string[] tongue = { "08", "68", "0C", "6A", "0C" };
        string[] kiss = { "00", "60", "00", "6A", "04" };
        string[] heart = { "38", "44", "22", "44", "38" };
        string[] surprised = { "06", "69", "09", "69", "06" };
        string[] catface = { "0C", "62", "0C", "62", "0C" };
        string[] dumb = { "20", "28", "08", "28", "20" };

        int counter = 36;

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.Text = "v2.0 raw\n00\n";
            string vstup = inputText.Text.ToUpper();
            for(int i = 0; i < vstup.Length; i++)
            {
                if(vstup[i] == 'A')
                {
                    for(int j = 0; j < 5; j++)
                    {
                        outputBox.Text += A[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if(vstup[i] == 'B')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += B[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'C')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += C[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'D')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += D[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'E')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += E[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'F')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += F[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'G')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += G[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'H')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += H[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'I')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += I[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'J')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += J[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'K')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += K[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'L')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += L[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'M')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += M[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'N')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += N[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'O')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += O[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'P')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += P[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'Q')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += Q[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'R')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += R[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'S')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += S[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'T')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += T[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'U')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += U[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'V')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += V[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'W')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += W[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'X')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += X[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'Y')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += Y[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == 'Z')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += Z[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == ':' && vstup[i + 1] == ')')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += smile[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == ':' && vstup[i + 1] == '(')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += sad[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == ':' && vstup[i + 1] == 'D')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += happy[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == ':' && vstup[i + 1] == 'P')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += tongue[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == ':' && vstup[i + 1] == '*')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += kiss[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == '<' && vstup[i + 1] == '3')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += heart[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == ':' && vstup[i + 1] == 'O')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += surprised[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == ':' && vstup[i + 1] == '3')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += catface[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                    i++;
                }
                else if (vstup[i] == ' ')
                {
                    outputBox.Text += "4*0" + "\n";
                }
                else if (vstup[i] == '.')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += dot[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == ',')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += comma[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '/')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += slash[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '(')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += bracketOpen[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == ')')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += bracketClose[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '#')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += hash[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '!')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += exclamation[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '?')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += question[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '-')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += dash[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '0')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += zero[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '1')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += one[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '2')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += two[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '3')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += three[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '4')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += four[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '5')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += five[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '6')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += six[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '7')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += seven[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '8')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += eight[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '9')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += nine[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '$')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += dollar[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '%')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += percent[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '^')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += carot[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '&')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += ampersand[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '*')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += star[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == ';')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += semicolon[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '\'')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += apostrophe[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '[')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += squareBracketOpen[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == ']')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += squareBracketClose[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '<')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += pointBracketOpen[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '>')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += pointBracketClose[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '"')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += quote[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '{')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += curlyBracketOpen[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
                else if (vstup[i] == '}')
                {
                    for (int j = 0; j < 5; j++)
                    {
                        outputBox.Text += curlyBracketClose[j] + " ";
                    }
                    outputBox.Text += "2*0" + "\n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.WriteAllText(@"C:\Users\Public\textROM.txt", outputBox.Text);
                MessageBox.Show("Export byl úspěšný. Váš soubor se nachází v C:/Users/Public/textROM.txt");
            } catch
            {
                MessageBox.Show("Nastala chyba při exportu.");
            }
            
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {
            counter = 36 - inputText.TextLength;
            charCounter.Text = counter.ToString();
        }
    }
}