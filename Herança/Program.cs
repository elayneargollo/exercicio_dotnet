using System.Text;
using System;

class Solution {
    
    static void Main(String[] args) {
        
        User userA = new Admin("administradora", "elayne", 15);
        User userM = new Moderador("moderadora", "natalia", 15);
        
        Console.WriteLine(string.Concat(userA.GetType(), ": ", userA.GetUserName())); 
        Console.WriteLine(string.Concat(userM.GetType(), ": ", userM.GetUserName())); 
    }
}