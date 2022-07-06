Console.WriteLine("Which Excercise do you want?");
Console.WriteLine("First Excercise :1");
Console.WriteLine("Second Excercise :2");
Console.WriteLine("Third Excercise :3");

int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
        endUp("allllllllllllslssshjhuhgkhgkjhrjkghrejkghejrkghrjekghjrkeghrekjhsdgerhthrtjhrjkrikuygdffdsrtreffytrujhtjuyokyjfgdfgethjrtghethe");
        break;
    case 2:
        CountHi("abc hi ho");
        break;
    case 3:
        Console.WriteLine(lastDigit(7, 17));
        break;
    default:
        Console.WriteLine("Invalid Operator");
        break;
}


//-----------------------------Methods-----------------------

void endUp(String aString)
{
    int j = aString.Length;
    char[] ch = new char[aString.Length];
    for(int i = 0; i < aString.Length; i++)
    {
        ch[i] = aString[i];
    }
    if(j > 3)
    {
        ch[j - 1] = Char.ToUpper(ch[j - 1]);
        ch[j - 2] = Char.ToUpper(ch[j - 2]);
        ch[j - 3] = Char.ToUpper(ch[j - 3]);
    }
    else
    {
        for(int i = 0; i < aString.Length; i++)
        {
            ch[i] = Char.ToUpper(ch[i]);
        }
    }
    foreach (char c in ch)
    {
        Console.Write(c);
    }
}



//-----------------------Part2-------------------
//

void CountHi(string aString)
{
    int j = 0;
    for (int i = 0; i < aString.Length; i++)
    {
        if(aString[i] == 'h' && aString[i + 1] == 'i')
        {
            j++;
            i += 2;
        }
    }
    Console.WriteLine(j);
}

//-----------------------Part3------------------------

//

bool lastDigit(int aNum1, int aNum2)
{
    string num1 = aNum1.ToString();
    string num2 = aNum2.ToString();
    if(num1[num1.Length - 1] == num2[num2.Length - 1])
    {
        return true;
    }
    return false;
}