using System;

public class Fraction

{
    private int _topNumber;
    private int _buttonNumber;

    public Fraction(){
        _topNumber = 1;
        _buttonNumber = 1;
    }

    public Fraction(int topNumber){
        _topNumber = topNumber;
        _buttonNumber = 1;
    }
    
    public Fraction(int topNumber, int buttonNumber){
        _topNumber = topNumber;
        _buttonNumber = buttonNumber;
    }

    public string GetFractionString()
    {
        string stringResult = $"{_topNumber}/{_buttonNumber}";
        return stringResult;
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber / (double)_buttonNumber;
    }


}