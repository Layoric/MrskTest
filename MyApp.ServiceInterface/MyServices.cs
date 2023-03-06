using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStack;
using ServiceStack.Script;
using ServiceStack.DataAnnotations;
using MyApp.ServiceModel;

namespace MyApp.ServiceInterface;

public class MyServices : Service
{
    public object Any(Hello request)
    {
        return new HelloResponse { Result = $"Hello, {request.Name}!" };
    }

    public object Get(HealthCheck request)
    {
        return new HealthCheckResponse();
    }
}
