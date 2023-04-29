using System.ComponentModel.Design;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Calculator.service;

public abstract class Calculator<T>
{
    private readonly FileLogger _fileLogger;

    public Calculator()
    {
        _fileLogger = new FileLogger();
    }
    
    public T Num1 { get; set; }
    public T Num2 { get; set; }
    public T Result { get; set; }

    public void Calculate(String operation)
    {
        Result = operation switch
        {
            "+" => Sum(),
            "-" => Difference(),
            "*" => Multiply(),
            "/" => Division(),
            _ => throw new Exception("Unknown calculator operation")
        };
        _fileLogger.Log($"{Num1} {operation} {Num2} = {Result}");
    }

    protected abstract T Sum();
    protected abstract T Difference();
    protected abstract T Multiply();
    protected abstract T Division();
}
