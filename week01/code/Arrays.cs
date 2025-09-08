public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// 
    /// IN solving this problem i have come up with a plan that
    /// 1. I will have to create a list which data type is double which i will store the starting number multiple so i can display it later.
    /// 2. I will need a for loop that will countinue to run as untill.
    /// 3. i will need a varible to store the list 

    /// 
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {

        /// creating a double array seting the size to the lenght number
        var doubles = new Double[length];

        int count = 0;
        // creating a for loop that will countinue to run untill the loop equal to the length number.
        for (int i = 1; i <= length; i++) // what happend here is that i is a varaible that set I to 1,
        // and then i said in the other line to check if i is qual to the lenght number, if is equal to it the loop will stop. the last part is that 
        // if i didnt equal to the lenght i  will add 1 to it self.
        {

            // to get the multiples of the number provided i need to mutipy it with i because at all time i will countinue to increase by 1.
            double multiples = number * i;
            // adding the result from the mutiply of starting * i to the double array
            doubles[count] = multiples;
            count++;

        }

        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.



        // returning the resuilt
            
            return doubles; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // The plan i have to solve this problem is to use some method like Getrange,RemoveRange, IntertRange etc
        // I will need a list with a variable name ints
        // The  list is to store a ranage of number i will get from data list through the GetRanage method
        // I will use the RemoveRange to remove item starting from the data.Count - amount index and removing the item according the nmount number
        // then i will then use insertRange to add the ints list to the data list starting from the index 0
        
        // TODO Problem 2 Start




        // creating a list name ints 
        List<int> ints = data.GetRange(data.Count - amount, amount); // getting some items from the data list tarting from dataCount - amount index. getting item accourding to the amount of number provided index.
       // removing item from the data list starting from dataCount - amount index. remove item accourding to the amount of number provided
        data.RemoveRange(data.Count - amount, amount);
     
     // insert the ints lsit to the data list staring at index 0
        data.InsertRange(0,ints);
        


       

        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
    }
}
