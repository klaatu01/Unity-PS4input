## Unity-PS4input

Basic DS4 controller input for Unity.

# Installation

Replace your YourProject/ProjectSettings/InputManager.asset with the InputManager.asset located in this repo. **Be sure to back up your InputManager.asset**

Add the InputManager.cs to your Assets folder.

# Usage

```C#
  ...
  public int playerNumber
  InputManager manager;
  
  
  public void Start(){
  
      manager = new InputManager(playerNumber);
  
  }
  ...
```
