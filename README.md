# Slime Modding Utilities (SMU)
A utility mod for Nickelodeon All Star Brawl. This mod does nothing on its own, but has a bunch of nifty features that modders can make use of.

-----

### SMU.Constants

Contains methods to translate character and stage IDs into their human-readable names, and vice versa.

```cs
// Try to get character/stage ID from the character's name.
public static bool TryGetIdFromName(string name, out string id);

// Get character/stage ID from the character's name.
public static string GetIdFromName(string name);

// Try to get character/stage name from the character's ID.
public static bool TryGetNameFromId(string id, out string name);

// Get character/stage name from the character's ID.
public static string GetNameFromId(string id);

// Get a list of all character IDs.
public static List<string> GetCharacterIds();

// Get a list of all stage IDs.
public static List<string> GetStageIds();
```
### SMU.Events

Contains handy extension methods for safely firing off events, without the worry of an exception stopping the chain.

```cs
// Invoke an action, catching errors that occur along the way without causing the rest to fail.
public static void InvokeAll(this Action action, params object[] args)
```

### SMU.Extensions

Contains handy extension methods for various common tasks

```cs
// Loop through every element in the sequence, applying the given action.
public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> act);

// Recursively search through a Transform's children to find one with a given name.
public static Transform FindRecursive(this Transform transform, string transformName);
```

### SMU.Reflection

Contains handy extension methods to help get and set private fields and properties, invoke private methods, and copy Unity components.

```cs
// Gets the value of a field, as gotten from T.
public static U GetField<T, U>(this T obj, string fieldName);

// Gets a property on the target object, as gotten from T.
public static U GetProperty<T, U>(this T obj, string propertyName);

// Sets a field on the target object, as gotten from T.
public static void SetField<T, U>(this T obj, string fieldName, U value);

// Sets a property on the target object, as gotten from T.
public static void SetProperty<T, U>(this T obj, string propertyName, U value);

// Invokes a method from T on an object.
public static T InvokeMethod<T>(this object obj, string methodName, params object[] args);

// Copies a component "original to a component of "overridingType" on the destination GameObject.
public static Component CopyComponent(this Component original, Type overridingType,
                                      GameObject destination, Type originalTypeOverride = null);
```

### SMU.Utilities

Contains extra utility classes with miscellaneous functionality

- ImageHelper
  - Utility class for loading external images from various locations; creates Texture2D and Sprite objects
  ```cs
  // Load a texture, given an array of bytes.
  public static Texture2D LoadTextureRaw(byte[] bytes);

  // Load a texture, given a file path.
  public static Texture2D LoadTextureFromFile(string path);

  // Load a texture from an embedded resource, given the path to the resource.
  public static Texture2D LoadTextureFromResources(string resourcePath);

  // Load a Sprite, given an array of bytes.
  public static Sprite LoadSpriteRaw(byte[] image, float pixelsPerUnit = 100.0f);

  // Load a Sprite, given a Texture2D.
  public static Sprite LoadSpriteFromTexture(Texture2D texture, float pixelsPerUnit = 100.0f);

  // Load a Sprite, given a file path.
  public static Sprite LoadSpriteFromFile(string path, float pixelsPerUnit = 100.0f);

  // Load a texture from an embedded resource, given the path to the resource.
  public static Sprite LoadSpriteFromResources(string resourcePath, float pixelsPerUnit = 100.0f);
  ```
- SharedCoroutineStarter
  - Provides a way to start coroutines from any class, without having to derive from MonoBehaviour 
  ```cs
  // Starts a coroutine, without the need for the calling class to inherit from Monobehaviour.
  public static new Coroutine StartCoroutine(IEnumerator routine);
  ```
