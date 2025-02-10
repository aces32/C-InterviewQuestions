using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLMs.DependencyInjection
{
    internal class DependencyInjection
    {
        /*
         * In .NET Core and ASP.NET Core, Dependency Injection (DI) is used to manage the lifecycle of objects (services). The three main service lifetimes are:

            1️⃣ Singleton – One instance for the entire application lifetime.
            2️⃣ Transient – A new instance every time the service is requested.
            3️⃣ Scoped – One instance per HTTP request (web app scenario).

        1️⃣ Singleton: One Instance for the Whole Application
            🔹 What is Singleton?
            The same instance of the service is used throughout the application.
            Created once when first requested, then shared across all requests and services.
            Best for services that need to maintain global state (e.g., caching, logging).
            ✅ Best Use Cases
            ✔ Caching services (e.g., in-memory caching, Redis clients).
            ✔ Configuration services (e.g., reading app settings).
            ✔ Database connection pools (e.g., single instance of a database client).

        Why Use Singleton?

            Improves performance (no need to create multiple instances).
            Ensures consistency (shared instance).
            🚨 Warning: Avoid modifying state in singletons because multiple requests might share data, leading to unexpected behavior.

        2️⃣ Transient: A New Instance Every Time
            🔹 What is Transient?
            A new instance is created every time the service is requested.
            No shared state between instances.
            Best for stateless, lightweight services.
            ✅ Best Use Cases
            ✔ Stateless services (e.g., utility classes, email senders).
            ✔ Performing short-lived operations (e.g., logging requests).
            ✔ Ensuring no shared data between requests.

        Each time the service is injected, it will have a different InstanceId.

            Why Use Transient?
            
            Best for lightweight, temporary objects.
            Ensures no unintended state sharing.
            🚨 Warning: Can be inefficient for expensive objects because a new instance is created each time.

        3️⃣ Scoped: One Instance Per Request
            🔹 What is Scoped?
            A single instance is created per HTTP request.
            The instance is shared within the request but not across multiple requests.
            Best for database contexts and per-request services.
            ✅ Best Use Cases
            ✔ Entity Framework DbContext (ensures DB operations are in the same transaction).
            ✔ Request-based operations (e.g., user authentication, tracking requests).
            ✔ Ensuring services are unique to each request.
            
            📌 Example: Registering a Scoped Servic
         */
    }
}
