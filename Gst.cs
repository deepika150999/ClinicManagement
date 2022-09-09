using System;
 
class Gst
{
    static float Calculate_GST(float org_cost,
                                float N_price)
    {
        // return value after calculate GST%
        return (((N_price - org_cost)/  100)+(20/100));
    }
    


     static float Calculate_VAT(float org_cost,
                                float N_price)
    {
        
        return (((N_price - org_cost) /10)+ (12/100));
    }

    
    public static void Main ()
    {
        int n1,n2;
        float org_cost =2;
        Console.WriteLine("Enter the cost given by Store");
        n1 = Convert.ToInt32(Console.ReadLine());
    
        float N_price = 5;
        Console.WriteLine("Enter the cost of the product");
        n2 = Convert.ToInt32(Console.ReadLine());
        
         Console.Write(" VAT = Rs." + Calculate_VAT
                        (org_cost, N_price),n1 );
        Console.Write("\n\n GST = Rs." + Calculate_GST
                        (org_cost, N_price) ,n2);
    }
}
 