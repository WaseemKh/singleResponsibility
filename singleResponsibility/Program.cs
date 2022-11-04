Product<int> x =new Product<int>();
x.Save(1);
public class Product<T>
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public string storeId { get; set; }
    public Store Store { get; set; }

    EFRepository<T> _EFRepository = new EFRepository<T>();
    
    public void Save(T data)
    {
        Logging.Log("Starting Save");
        _EFRepository.AddAsync(data);
        Logging.Log("End Save");
    }

    public async Task Delete(T id)
    {
        Logging.Log("Starting Delete");
        //check if already  Used -processed- Product  Inventory then don't delete
        await _EFRepository.DeleteAsync(id);
        Logging.Log("End Delete");
    }


}



//Class for every DB operations -using EF 

public class EFRepository<T>
{
    public async Task<T> AddAsync(T entity)
    {
        //_db.Set<T>().Add(entity);
        // await _db.SaveChangesAsync();
        return entity;
    }
    public async Task DeleteAsync(T entity)
    {
        // _db.Set<T>().Remove(entity);
        //   await _db.SaveChangesAsync();
    }
    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        // return    await _db.Set<T>().ToListAsync();
        return new List<T>();
    }
}
public class Store
{
    public int Id { get; set; }
    public string StoreName { get; set; }
    public string Location { get; set; }
    public string Type { get; set; }


    public void AddToStore(Store st)
    {
        if (st.Type == "Online")
        {
            //add using EF add on online table
        }
        else
        {
            //add using EF add on reality table
        }
    }

}


public class Logging
{
    public static void Log(string log)

    {
        Console.WriteLine("Save Logs in any where,{0}",
        log);
    }
}
