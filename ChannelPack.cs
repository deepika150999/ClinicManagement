using System;

class ChannelPack

{  
 
 public static void Main()
 
  
 {
       
 
Console.WriteLine ("Which Package do you Want");
 
 
    Console.WriteLine("Choose Package A or B or C");

  string packType=Console.ReadLine();
 
 switch(packType)
{
     case "A":
 
    Console.WriteLine("1.South Special \n2. Children's Club\n3. Movies");
 
    Console.WriteLine("\n Cost Will be rs.250");


break;

 case "B":
   
  Console.WriteLine("1.News Sports \n2.Movies\n 3. Regional-2");
     Console.WriteLine("\n Cost Will be rs.450");


break;

case "C":
   
  Console.WriteLine("1.Discovery \n2.History \n3.National");
     Console.WriteLine("\nCost Will be rs.350");

break;

}

}

}
