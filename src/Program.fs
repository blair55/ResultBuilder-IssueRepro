
type ResultBuilder () =
  // member __.Return (x) = Ok x
  member __.ReturnFrom (m: Result<_, _>) = m
  // member __.Bind (m, f) = Result.bind f m
  // member __.Zero () = Error ()

let result =
  new ResultBuilder ()

let wtf () =
  result {
    return! Ok ()
  }