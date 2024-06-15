using System;
using MyTypes;

class Program{
    public static void Main(string[] args){
        MyTypes.Points.Point2D flatPoint1 = new MyTypes.Points.Point2D(3,4);
        Console.WriteLine(flatPoint1);
        Console.WriteLine(flatPoint1.GetMagnitude());
        MyTypes.Points.Point3D spacePoint1 = new MyTypes.Points.Point3D(1,1,1);
        Console.WriteLine(spacePoint1);
        Console.WriteLine(spacePoint1.GetMagnitude());
    }
}