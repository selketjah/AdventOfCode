// create (seq, list, array)
let listOneToFive = [1..5]
let listSixToTen = [6..10]

//append

let listTen =
  List.append listOneToFive listSixToTen

// -> appends listSixToTen to listOneToFive

let listTen2 =
  listOneToFive
  |> List.append listSixToTen

// -> appends listOneToFive to listSixToTen

// average


