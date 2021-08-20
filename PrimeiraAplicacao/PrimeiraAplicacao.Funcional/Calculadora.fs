module Calculadora

let elevaNumeroAoQuadrado numero = numero * numero

let somaQuadradoDosNumerosAteDez =
    [1..10]
    |> List.map elevaNumeroAoQuadrado
    |> List.sum