// Learn more about F# at http://fsharp.net. See the 'F# Tutorial' project
// for more guidance on F# programming.
#load "Component1.fs"

open DinDin.Android.Logic

let w = Class1()
let x = w.X
let y = w.GetType().Assembly
let v = y.GetName().Version.ToString(3)
