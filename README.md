# Custom Event Listener and Trigger

This project demonstrates a simple implementation of a custom event listener and trigger mechanism using Windows API functions in C#.

## Overview

The project consists of two main components:

1. **CustomEventListener**: This class creates a named event using `CreateEvent` from `kernel32.dll` and listens for this event using `WaitForSingleObject`.

2. **CustomEventTrigger**: This class opens the named event created by `CustomEventListener` using `OpenEvent` and signals the event using `SetEvent`.

## Usage

### Prerequisites

- **Platform**: Windows operating system.
- **Development Environment**: Visual Studio or any other C# development environment.
- **Dependencies**: None other than standard .NET libraries.

### Instructions

1. **Build the Project**: Open the solution in Visual Studio and build the solution to compile the project.

2. **Run the Application**: Start the application. This will create an instance of `CustomEventListener` which will start listening for events.

3. **Trigger the Custom Event**: To trigger the event programmatically, you can use `CustomEventTrigger`. This can be done by calling `TriggerEvent()` method from another part of your application or another executable.

### Important Notes

- **Event Name**: Both `CustomEventListener` and `CustomEventTrigger` use the same event name (`Global\\MyCustomEvent`). Ensure that this name is unique and meaningful for your application, if you change it.



## Acknowledgments

- This project was inspired by the need for inter-process communication using named events on Windows.

## Author

- [Your Name](https://github.com/Alessio2405)

Feel free to fork this project, modify it, and use it according to your needs!
