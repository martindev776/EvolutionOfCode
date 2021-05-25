module Assignment2

open System

type Square = {
    Side: double
}

type Rectangle = {
    Height: double
    Length: double
}

type Circle = {
    Radius: double
}

type IShape =
    | Square of Square 
    | Rectangle of Rectangle
    | Circle of Circle

let PerimeterCalculationStrategy (shape: IShape) =
    match shape with
    | Square s -> s.Side * 4.0
    | Rectangle r -> r.Height * 2.0 + r.Length * 2.0
    | Circle c -> 2.0 * Math.PI * c.Radius

let AreaCalculationStrategy (shape: IShape) =
    match shape with
    | Square s -> s.Side * s.Side
    | Rectangle r -> r.Height * r.Length
    | Circle c -> Math.PI * Math.Pow(c.Radius, 2.0)

let Run () =
    let rectangle = Rectangle({Height = 2.0
                               Length = 5.0})

    let square = Square({ Side = 3.0 })

    let circle = Circle({ Radius = 2.0 })

    [|rectangle;square;circle|]
    |> Array.map AreaCalculationStrategy    