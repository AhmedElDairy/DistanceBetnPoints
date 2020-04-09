/******************************************************************************

                            ProgrammingAssignment 1
							        By
							  Ahmed ElDairy

*******************************************************************************/

using System;
class HelloWorld {
    
  static void Main() {
      
    Console.WriteLine(" Welcome");
  
    Console.WriteLine(" This application will calculate the distance between two points and the angle between those points");

//  Getting the points.
    
    Console.Write(" Enter first x value: ");
    float point1X=float.Parse(Console.ReadLine());
    
    Console.Write(" Enter first y value: ");
    float point1Y=float.Parse(Console.ReadLine());
    
    Console.Write(" Enter Second x value: ");
    float point2X=float.Parse(Console.ReadLine());
    
    Console.Write(" Enter Second y value: ");
    float point2Y=float.Parse(Console.ReadLine());

//  Getting the difference between the points.    
    
    float deltaX = point2X - point1X;
    
    float deltaY = point2Y - point1Y; 

//  Getting the distance between the points.    
    
    double distance = Math.Sqrt(Math.Pow(Convert.ToSingle(deltaX),2) + Math.Pow(Convert.ToSingle(deltaY),2));
    
    Console.WriteLine(" The distance between the two points is : " + distance);
    
//  Calculating the angle between the points.
//  by Atan as it gets the angle in radians (toa rule opposite/adjacent).

    double OA = Convert.ToSingle(deltaY/deltaX);
    double radianAngle = Math.Atan(OA);
    double angle = radianAngle * (180/Math.PI);
    double angleBtn = angle-180;
    Console.Write(" The angle betweenthe points is: " + angleBtn + " degrees");
  }
  
}
