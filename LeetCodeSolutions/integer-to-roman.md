# integer-to-roman
**Solution**
```
string IntToRoman(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        if (num >= 900)
        {
            if (num >= 900 && num < 1000)
            {
                result += "CM";
                num -= 900;
            }
            else
            {
                result += "M";
                num -= 1000;
            }
        }
        else if (num >= 400)
        {
            if (num >= 400 && num < 500)
            {
                result += "CD";
                num -= 400;
            }
            else
            {
                result += "D";
                num -= 500;
            }
        }
        else if (num >= 90)
        {
            if (num >= 90 && num < 100)
            {
                result += "XC";
                num -= 90;
            }
            else
            {
                result += "C";
                num -= 100;
            }
        }
        else if (num >= 40)
        {
            if (num >= 40 && num < 50)
            {
                result += "XL";
                num -= 40;
            }
            else
            {
                result += "L";
                num -= 50;
            }
        }
        else if (num >= 10)
        {
            result += "X";
            num -= 10;
        }
        else if (num >= 5)
        {
            if (num >= 9)
            {
                result += "IX";
                num -= 9;
            }
            else
            {
                result += "V";
                num -= 5;
            }
        }
        else if (num >= 1)
        {
            if(num == 4)
            {
                result += "IV";
                num -= 4;
            }
            else
            {
                result += "I";
                num -= 1;
            }
        }
    }
    return result;
}
```