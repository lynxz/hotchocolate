using System.Threading.Tasks;
using HotChocolate.Execution;
using Microsoft.AspNetCore.Http;
#if !NET6_0_OR_GREATER
using Microsoft.Net.Http.Headers;
#endif

namespace HotChocolate.Caching.Http;

internal sealed class HttpQueryCache : DefaultQueryCache
{
    private const string _httpContextKey = nameof(HttpContext);
    private const string _cacheControlValueTemplate = "{0}, max-age={1}";
    private const string _cacheControlPrivateScope = "private";
    private const string _cacheControlPublicScope = "public";

    public override Task CacheQueryResultAsync(IRequestContext context,
        ICacheControlResult result, ICacheControlOptions options)
    {
        if (!context.ContextData.TryGetValue(_httpContextKey, out var httpContextValue)
            || httpContextValue is not HttpContext httpContext)
        {
            return Task.CompletedTask;
        }

        var cacheType = result.Scope switch
        {
            CacheControlScope.Private => _cacheControlPrivateScope,
            CacheControlScope.Public => _cacheControlPublicScope,
            _ => throw ThrowHelper.UnexpectedCacheControlScopeValue(result.Scope)
        };

        var headerValue = string.Format(_cacheControlValueTemplate,
            cacheType, result.MaxAge);



#if NET6_0_OR_GREATER
        httpContext.Response.Headers.CacheControl = headerValue;
#else
        httpContext.Response.Headers.Add(HeaderNames.CacheControl, headerValue);
#endif

        return Task.CompletedTask;
    }
}
