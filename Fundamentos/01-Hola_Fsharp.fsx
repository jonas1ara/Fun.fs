open System

let HolaYouTube() =  
    printf "Dime tú nombre: "

    let nombre = Console.ReadLine()
    
    printfn "Hola %s, bienvenido a FSharp" nombre
    // Console.WriteLine( "Hola {0} desde FSharp", nombre);

HolaYouTube()

Console.ReadKey() |> ignore