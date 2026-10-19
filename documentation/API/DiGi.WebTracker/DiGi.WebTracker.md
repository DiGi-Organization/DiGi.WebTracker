#### [DiGi\.WebTracker](index.md 'index')

## DiGi\.WebTracker Namespace
### Classes

<a name='DiGi.WebTracker.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.WebTracker.Query.PageHash(System.Net.Http.HttpClient,string)'></a>

## Query\.PageHash\(HttpClient, string\) Method

Computes the MD5 hash of the page at [url](DiGi.WebTracker.md#DiGi.WebTracker.Query.PageHash(System.Net.Http.HttpClient,string).url 'DiGi\.WebTracker\.Query\.PageHash\(System\.Net\.Http\.HttpClient, string\)\.url'), used for change detection\.

```csharp
public static System.Threading.Tasks.Task<string?> PageHash(System.Net.Http.HttpClient? client, string? url);
```
#### Parameters

<a name='DiGi.WebTracker.Query.PageHash(System.Net.Http.HttpClient,string).client'></a>

`client` [System\.Net\.Http\.HttpClient](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpclient 'System\.Net\.Http\.HttpClient')

The HTTP client used to fetch the page\.

<a name='DiGi.WebTracker.Query.PageHash(System.Net.Http.HttpClient,string).url'></a>

`url` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The URL of the page to hash\.

#### Returns
[System\.Threading\.Tasks\.Task&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1 'System\.Threading\.Tasks\.Task\`1')  
The lowercase MD5 hash of the page content, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the inputs are invalid\.