open System

//let somaCom3 numero = numero + 3
let somaCom3 = (+) 3

let somaCom = (+)

let somaCom2 = somaCom 2

let somaCom10 = (+) 10
let somarNumeroCom10 =
    3 |> somaCom10

let multiplicarPor = (*)

let multiplicarPor2 = multiplicarPor 2
let multiplicarPor4 = multiplicarPor 4

let dobrarValoresDeUmaLista() =
    let lista = [0..10]
    let listaComValoresMenoresQue5 =
        List.filter (fun numero -> numero < 5) lista
    List.map multiplicarPor2 listaComValoresMenoresQue5

let dobrarValoresDeUmaListaComOperador() =
    [0..10]
    |> List.filter (fun numero -> numero < 5)
    |> List.map multiplicarPor2

let variasOperacoes valor1 valor2 =
    valor1 + valor2
    |> somaCom10
    |> somaCom2
    |> multiplicarPor2

let exemploInverso valor1 valor2 =
    somaCom10 <| valor1 valor2

let numeroImparOperadorInverso valor =
    let numeroPar numero = numero % 2 = 0
    not <| numeroPar valor

let numeroImpar valor =
    let numeroPar numero = numero % 2 = 0
    not <| numeroPar valor

let numeroImparParenteses valor =
    let numeroPar numero = numero % 2 = 0
    not (numeroPar valor)

let compor funcao1 funcao2 parametro =
    funcao2(funcao1(parametro))

let converteBooleanoParaTexto valor =
    if valor
        then "Sim"
        else "Não"

let verificaSeONumeroEImpar valor =
    let resultado = numeroImpar valor
    converteBooleanoParaTexto resultado

let verificaSeONumeroEImparUsandoCompor =
    numeroImpar >> converteBooleanoParaTexto

let verificaSeONumeroEImparUsandoComporComPipeline numero =
    numeroImpar numero |> converteBooleanoParaTexto

let somaComTresEVerificaSeONumeroEImparUsandoCompor =
    somaCom3 >> numeroImpar >> converteBooleanoParaTexto

let somaDepoisMultiplica =
    compor ((+)1) ((*)2)

let somaDepoisMultiplicaUsandoOperador valorParaSomar =
    (+)valorParaSomar >> (*)

let dobraDepoisSoma =
    (+) << (*)2

[<EntryPoint>]
let main argv =
    let resultado = somaDepoisMultiplicaUsandoOperador 1 1 <| 2
    0
