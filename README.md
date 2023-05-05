

# StrictHandler

`StrictHandler` is a lightweight library that provides a simple way to calculate the strictness mode for a given operation.

## Features

- Simple API with a single `StrictCalculator` class
- Supports three modes: `StrictDisabled`, `StrictEnabled`, and `Loose`
- Easy to integrate into any .NET application

## Usage

To use `StrictHandler`, first add a reference to the project or package in your application.

Then, create an instance of the `StrictCalculator` class, passing in the desired mode and the loose setting:

```c#
using StrictHandler;

var mode = StrictCalculator.Modes.StrictEnabled;
bool loose = true;
var calculator = new StrictCalculator(mode, loose);
```

You can then retrieve the calculated result using the result property:

```
bool strictResult = calculator.result;
```

# License
This project is licensed under the [MIT License](https://chat.openai.com/LICENSE).

