#### [DiGi\.WebTracker](index.md 'index')

## DiGi\.WebTracker\.Classes Namespace
### Classes

<a name='DiGi.WebTracker.Classes.WebTracker'></a>

## WebTracker Class

Periodically fetches a URL and detects changes by comparing MD5 page hashes\.

```csharp
public class WebTracker : System.IDisposable
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → WebTracker

Implements [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='DiGi.WebTracker.Classes.WebTracker.WebTracker(string,int)'></a>

## WebTracker\(string, int\) Constructor

Creates a [WebTracker](DiGi.WebTracker.Classes.md#DiGi.WebTracker.Classes.WebTracker 'DiGi\.WebTracker\.Classes\.WebTracker') that polls [url](DiGi.WebTracker.Classes.md#DiGi.WebTracker.Classes.WebTracker.WebTracker(string,int).url 'DiGi\.WebTracker\.Classes\.WebTracker\.WebTracker\(string, int\)\.url') every [interval](DiGi.WebTracker.Classes.md#DiGi.WebTracker.Classes.WebTracker.WebTracker(string,int).interval 'DiGi\.WebTracker\.Classes\.WebTracker\.WebTracker\(string, int\)\.interval') milliseconds\.

```csharp
public WebTracker(string? url, int interval);
```
#### Parameters

<a name='DiGi.WebTracker.Classes.WebTracker.WebTracker(string,int).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.WebTracker.Classes.WebTracker.WebTracker(string,int).interval'></a>

`interval` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Properties

<a name='DiGi.WebTracker.Classes.WebTracker.Busy'></a>

## WebTracker\.Busy Property

Gets whether a change check is currently in progress\.

```csharp
public bool Busy { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')
### Methods

<a name='DiGi.WebTracker.Classes.WebTracker.Dispose()'></a>

## WebTracker\.Dispose\(\) Method

Releases the [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient') and [System\.Timers\.Timer](https://learn.microsoft.com/en-us/dotnet/api/system.timers.timer 'System\.Timers\.Timer') used for polling\.

```csharp
public void Dispose();
```

Implements [Dispose\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')

<a name='DiGi.WebTracker.Classes.WebTracker.Start()'></a>

## WebTracker\.Start\(\) Method

Starts periodic change detection\.

```csharp
public void Start();
```

<a name='DiGi.WebTracker.Classes.WebTracker.Stop()'></a>

## WebTracker\.Stop\(\) Method

Stops periodic change detection\.

```csharp
public void Stop();
```