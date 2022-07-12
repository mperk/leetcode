# divide-two-integers
**Solution**
```
int Divide(int dividend, int divisor)
{
    decimal quotient = (decimal)dividend / (decimal)divisor;
    if(quotient >= 0)
    {
        decimal f = Math.Floor(quotient);
        if (f > Int32.MaxValue) return Int32.MaxValue;
        else return (int)f;
    }
    else
    {
        decimal c = Math.Ceiling(quotient);
        if (c < Int32.MinValue) return Int32.MinValue;
        else return (int)c;
    }
}
```