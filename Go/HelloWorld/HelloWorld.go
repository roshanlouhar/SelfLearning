package main

import "fmt"

// fib returns a function that returns
// successive Fibonacci numbers.
func fib() func() int {
	a, b := 0, 1
	return func() int {
		a, b = b, a+b
		return a
	}
}

func main() {
	//f := fib()
	// Function calls are evaluated left-to-right.
	//fmt.Println(f())

	intnum := 10
	str := "Roshan"
	floatnum := 10.222

	fmt.Println(floatnum)
	fmt.Println(intnum)
	fmt.Println(str)

	// if (intnum < 10)
	// 	{fmt.Println("number is less then")}
	// else
	// {fmt.Println("number is greater then")}

}
