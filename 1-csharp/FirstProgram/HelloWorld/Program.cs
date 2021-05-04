using System;
/* namimng conventions:
  in .net, we use PascalCase. Name artifacts like this: EveryFirstLetterIsCapitalized.
  we use camelCase for naming fields.
*/

namespace HelloWorld {

    // this class is by default called program, is the starting point of your application
    // because it contains the Main method
    class Program {

        // This is the main method, very special, its the first method that gets called/run. The compiler looks for this
        // method when you run a program. Things to note about the main method:
        // 1.Static meaning, I don't have to instantiate the Program class, i.e. create an object for it to call the method
        // 2.Void, I'm not returning anything. Don't expect any results from this method
        // 3.string[] args
        static void Main(string[] args) {
            // To run your console app, run dotnet run on the folder that contains the .NET project.
            // dotnet build => this commands makes sure that your code compiles
            // dotnet run  =>  builds and runs your code 
            Console.WriteLine("Hello World!");
        }
    }
}
