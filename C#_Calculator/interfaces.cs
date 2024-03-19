using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

//Fabricate interface for calculating the sum
interface IAddition
{
    void Sum();//interface has no body
}

//Fabricating interface for calculating thr quotient
interface IDivision
{
    void Quotient();//interface has no body
}

//Fabricating interface for calculating the difference
interface ISubtraction
{
    void Difference();//interfaces require no body
}

//fabricating interface for calculating the product
interface IMultiplication
{
    void Product();//Interface does not need a body
}
