using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
public class SerialTest {
    public void SerializeNow() {
        ClassToSerialize c = new ClassToSerialize();
        c.Name = "Deepika";
        c.Age = 23;
        c.Gender="Female";
        ClassToSerialize.CompanyName = "Softura";
        File f = new File("E:\\test.txt");
        Stream s = f.Open(FileMode.Create);
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(s, c);
        s.Close();
    }
    public void DeSerializeNow() {
        ClassToSerialize c = new ClassToSerialize();
        File f = new File("E:\\test.txt");
        Stream s = f.Open(FileMode.Open);
        BinaryFormatter b = new BinaryFormatter();
        c = (ClassToSerialize) b.Deserialize(s);
        Console.WriteLine("Name :" + c.Name);
        Console.WriteLine("Age :" + c.Age);
        Console.WriteLine("Gender :" + c.Gender);
        Console.WriteLine("Company Name :" + ClassToSerialize.CompanyName);
        Console.WriteLine("Company Name :" + c.GetSupportClassString());
        s.Close();
    }
    public static void Main(string[] s) {
        SerialTest st = new SerialTest();
        st.SerializeNow();
        st.DeSerializeNow();
    }
}
public class ClassToSerialize {
    string name;
    string companyname;
    SupportClass supp = new SupportClass();
    public ClassToSerialize() {
        supp.SupportClassString = "In support class";
    }
    public int Age {
        get {return  Age; }
        set {Age = value;}
    }
    public string Name {
        get { return name; }
           
        set {
            name = value;
        }
    }
    public string Gender {
        get { return  Gender; }
           
        set {
           Gender = value;
        }
    }
    
    public static string CompanyName {
        get {
            return CompanyName;
        }
        set {
           CompanyName = value;
        }
    }
   
