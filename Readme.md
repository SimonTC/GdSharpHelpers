# GdSharpHelpers

A small library with helper methods used for making my life easier when using Godot with C#.

## Helpers

### FindNodeLazy

An extension method to the `Node` class that lets you use `FindNode` lazily and strongly typed.

From Godot documentation:

>Finds a descendant of this node whose name matches mask as in String.match (i.e. case-sensitive, but "*" matches zero or more characters and "?" matches any single character except ".").  
Note: It does not match against the full path, just against individual node names.

#### Example

```C#
private Lazy<Slider> ValueSlider => this.FindNodeLazy<Slider>("MySlider");
```

### GetNodeLazy

An extension method to the `Node` class that lets you use `GetNode` lazily and strongly typed.

From Godot documentation:

>Fetches a node. The NodePath can be either a relative path (from the current node) or an absolute path (in the scene tree) to a node.

#### Example

```C#
private Lazy<Label> ValueLabel => this.GetNodeLazy<Label>("MyLabel");
```
