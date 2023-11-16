namespace gyakorlas11._16
{
    struct Ingredient { 
    public string Name;
    public double Amount;
    public string Mou;      
    
    
    
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string dataRow = "liszt|1|kg";
            string dataRow1 = "cukor|0,5|kg";

            string[] iName = new string[2];
            double[] iAmount = new double [2];
            string[] iMou = new string [2];

            Ingredient[] ingredients = new Ingredient[2];

            string[] data = dataRow.Split('|');
            /*
             0 => liszt
             1 => 1
             2 => kg
             */

            Ingredient ing = new Ingredient();
            ing.Name = data[0];
            ing.Amount =double.Parse(data[1]);
            ing.Mou = data[2];

            iName[0] = data[0];
            iAmount[0] = double.Parse(data[1]);
            iMou[0] = data[2];

            data = dataRow1.Split('|');
            iName[1] = data[0];
            iAmount[1] = double.Parse(data[1]);
            iMou[1] = data[2];


            ingredients[1].Name = data[0];
            ingredients[1].Amount = double.Parse(data[1]);
            ingredients[1].Mou = data[2];


            Console.WriteLine(ingredients[1].Name + "-" + ingredients[1].Mou + ingredients[1].Amount);
            Console.WriteLine("Hello, World!");
            
        }
    }
}