﻿using System;

//namespace Polymorphism_Lab
//{
class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.Radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public sealed override string Draw()
    {
        return base.Draw() + "Circle";
    }
}
//}
