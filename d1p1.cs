using System;
class HelloWorld {
  static int wagePerHour, noOfHours;
  static void uc1(){
    Random attendance = new Random();
    int value = attendance.Next(0,2);
    
    if(value == 0){
        Console.WriteLine("Employee is absent");
    }
    else{
        Console.WriteLine("Employee is present");
    }
  }
  
  static void uc2(){
      int dailyWage = wagePerHour * noOfHours;
      Console.WriteLine("Total wage daily is " + dailyWage);
  }
  
  static void uc3(){
      int dailyWage = wagePerHour * noOfHours;
      Console.WriteLine("Total wage daily for part-time is " + dailyWage);
  }
  
  static void uc4(){
      Random generate = new Random();
      int value = generate.Next(0,4);
      
      switch(value){
          case 0: Console.WriteLine("In case 0");
                  break;
          case 1: uc1();
                  break;
          case 2: uc2();
                  break;
          case 3: uc3();
                  break;
      }
  }
  
  static void uc5(){
      int wagePerMonth = 0;
      for(int i = 0; i < 20; i++){
          wagePerMonth += (wagePerHour*noOfHours);
      }
      
      Console.WriteLine("Total wage for a month is " + wagePerMonth);
  }
  
  static void uc6(){
      int hours = 100, days = 20, totalWage = 0;
      for(int h = 0, d = 0; h < hours && d < days;){
          totalWage += 160;
          h += noOfHours;
          d++;
      }
      
      Console.WriteLine("Total salary is " + totalWage);
  }
  static void Main() {
    wagePerHour = 20;
    noOfHours = 8;
    Console.WriteLine("Welcome to Employee Wage Computation Program on Master Branch");
    uc1();
    uc2();
    uc3();
    uc4();
    uc5();
    uc6();
  }
}