using System;  

namespace PixelSearch {
    class Main 
    {  
        static void Main()  
        {  
        #if DebugConfig  
            Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");  
        #endif  
            Console.WriteLine("Test");  
        }  
    }
}