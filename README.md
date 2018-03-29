Sharp Session
================

Just in case someone needs session for Windows forms/WPF



## Installation

It is recommended to use NuGet. F.ex through the VS Package Manager Console `Install-Package iQuantile.DotLib.SessionManager` or using the VS "Manage NuGet Packages..." extension. 


## How to use

Session is a static class. add reference.

```c#
using static SessionManager.SharpSession;
```

#### Start Session

```c#
SessionStart();
```


```c#
Session["A"] = 5;
int y = (int)Session["A"];
```

## Special Methods

### GET<T>
In stead of type casting use GET<T>("key"). this will work like (T)Session["key"]
```c#
Session["A"] = 5;

int x = Get<int>("A");

```


### SET
In stead of type casting use SET("Key",value).this will store the data on Session[key]

```c#
Set("A", 10);
int y =  (int)Session["A"];
```

# OTHER SESSION METHODS

```C#

SessionDestroy(); //destroys the session
SessionUnset();  //re initialize session
SessionReset(); //Sets all keys to null
            

RegenerateId();      // Creates new ID and appends to sessionID
int x = CreateId(); //Returns a new SessionID

```


# OTHER PROPERTIES

```C#
public static int SessionId { get; set; } //Holds the session ID
public static string SessionName { get; set; } //Holds the session name

```


