class Customer{
    private int cus_id = 0;
    public string cus_name = string.Empty;
    public int cus_age = 0;
    
    public Customer(int cus_id, string cus_name, int cus_age){
        this.cus_age = cus_age;
        this.cus_name = cus_name;
        this.cus_id = cus_id;
    }
    public void ChangeID(int new_id){
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer){
        if(this.cus_age >= objCustomer.cus_age){
            Console.WriteLine($"{this.cus_name} is older");
        }
    }
}