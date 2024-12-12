string[] orderIDs = {"B123", "C234" , "A345", "C15" ,"B177" ,"G3003" ,"C235" ,"B179"};

foreach (string ID in orderIDs){
    if(ID.StartsWith("B")){
        Console.WriteLine($@"Potential fraud found.
Order ID: {ID}");
    }
}
