
# Arrays As Tables

A simple dll (or source) made for my class



## Features

- Print Array as a table
- Print 2d Array (Matrix) as a table
- Fill Arrays with random numbers up to 100,000 (Can be changed)
- Fill 2d Arrays with random numbers up to 100,000 (Can be changed)

## Deployment

To deploy this project

-  Refrence ArraysAsTables.dll to your C# project

- At the top of your .cs file, add
```cs
    using ArraysAsTables;
```

## Usage/Examples

```csharp
using System;
using ArraysAsTables;

...

    //1d Arrays

    int[] arr = new int[100]; //Example size
    AAT.FillArray(arr); //Fills the Array with random numbers up to 100,000
    AAT.PrintArray(arr); //Prints the Array as a table

    //2d Arrays

    int[,] arr = new int[30,30]; //Example size
    AAT.Fill2dArray(arr); //Fills the 2d Array with random numbers up to 100,000
    AAT.Print2dArray(arr); //Prints the 2d Array as a table
```


## Screenshots

- Array printing

    ![Array Printing](https://media.discordapp.net/attachments/728303111663517756/1100124526886527136/image.png?width=1014&height=70)

## Roadmap

- Add control of Array printing padding & size (Which will support higher numbers)

## Authors

- [@trhi2409](https://www.github.com/trhi2409)

## Used By

- Ram's Class 💪

