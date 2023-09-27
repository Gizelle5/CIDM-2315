namespace Week5._3;

class Program
{
    static void Main(string[] args)
    {
        createAccount(); 
    }
        static bool checkAge(int birth_year){
	// calculate the age based on the birth_year (age = 2022-birthyear)
        int age = (2023-birth_year);
	// if age >=18, return true;
         if(age >= 18){
            return true;
        }
	//else return false;
        else{
            return false;
        }
} 

static void createAccount(){
// ask user to input username
Console.WriteLine("Enter Your Username: ");
string Name = Console.ReadLine();
// ask user to input password
Console.WriteLine("Enter Your Password: ");
string password_1 = Console.ReadLine();
// ask user to input password again
Console.WriteLine("Enter Your Password Again: ");
string password_2 = Console.ReadLine();
// ask user to input birthyear
Console.WriteLine("Enter Your BirthYear: ");
int birth_year = Convert.ToInt16(Console.ReadLine());
// call checkAge(birthyear) method to check if age is greater than 18
    if(checkAge(birth_year)){
        if(password_1 == password_2){
            Console.WriteLine("Account is created successfully");
        }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else {
            Console.WriteLine("Could not create an account");
        }
    }

}

    

