open System

let escreveSeNumeroEParOuImpar numero =
    let verificaSeNumeroEPar = numero % 2 = 0
    let escreveNumeroPar() = printfn "o número %i é par" numero
    let escreveNumeroImpar() = printfn "o número %i é ímpar" numero

    if verificaSeNumeroEPar then
        escreveNumeroPar()
    else
        escreveNumeroImpar()

let executarAcaoSobreOsElementos lista acao =
    lista |> List.iter acao

let imprimirNomes nomes =
    executarAcaoSobreOsElementos nomes (printfn "Olá %s")

let imprimirDobroDosNumeros numeros =
    executarAcaoSobreOsElementos numeros (fun numero -> printfn "%i." (numero * 2))

let somaCom5 numero = numero + 5
let somaCom5ViaLambda = fun numero -> numero + 5

let multiplicarEImprimirNumero multiplicador numero =
    printfn "%i." (numero * multiplicador)

let imprimirListaDeNumeros multiplicador numeros =
    executarAcaoSobreOsElementos numeros (multiplicarEImprimirNumero multiplicador)

let multiplicarEImprimirNumerosCurrying multiplicador =
    let imprimirNumero numero =
        printfn "%i." (numero * multiplicador)
    imprimirNumero

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0
