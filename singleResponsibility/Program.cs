



public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string storeId { get; set; }
    public Store Store { get; set; }

    public void Save()
    {
        Console.WriteLine("Starting Save()");
        //use EF to save Inventory to DB

        Console.WriteLine("End Save()");
    }

    public void Delete()
    {
        Console.WriteLine("Starting Delete()");

        //check if already  Used -processed- Product  Inventory then don't delete

        Console.WriteLine("End Delete()");
    }

    public IList<Store> Sale(Store st)
    {
        Console.WriteLine("Starting Subscribe()");
        var result = new List<Store>();
        //apply business rules based on the store type 
        if (st.Type == "online")
        {
            //validate
            return result;
        }
        else if (st.Type == "realy")
        {
            return result;
        }
        return result;


        Console.WriteLine("End Subscribe()");
    }

    public void SendEmailToCustomer()
    {
        Console.WriteLine("Done !");
        //Setting for email and send 
    }

    //edite product quntity in store ....
}
public class Store
{
    public int Id { get; set; }
    public string StoreName { get; set; }
    public string Location { get; set; }
    public string Type { get; set; }

}