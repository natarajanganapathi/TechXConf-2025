using System;
using System.IO;
using System.ComponentModel;
using System.ClientModel;
using System.Diagnostics;

using Microsoft.Extensions.AI;
using Microsoft.Agents.AI;

using OpenAI;
using OpenAI.Chat;

using Azure;
using Azure.AI.OpenAI;
using Azure.Identity;


using System.Text.Json;
using System.Threading.Tasks;

using OpenTelemetry;
using OpenTelemetry.Trace;

using DotNetEnv;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ModelContextProtocol.Server;

using System.Text.Json;


Env.Load("./.env");

var endpoint = Environment.GetEnvironmentVariable("ENDPOINT") ?? throw new InvalidOperationException("ENDPOINT is required");
var model_id = Environment.GetEnvironmentVariable("MODEL_ID") ?? throw new InvalidOperationException("MODEL_ID is required");
var token = Environment.GetEnvironmentVariable("TOKEN") ?? throw new InvalidOperationException("TOKEN is required");
var uri = new Uri(endpoint);

using var tracerProvider = Sdk.CreateTracerProviderBuilder()
    .AddSource("agent-telemetry-source")
    .AddConsoleExporter()
    .Build();

var agent = new AzureOpenAIClient(uri, new AzureKeyCredential(token))
.GetChatClient(model_id)
.CreateAIAgent(
    name: "VacationPlannerAgent",
    description: "An AI Agent that helps customers plan vacations at random destinations",
    instructions: "You are a helpful AI Agent that can help plan vacations for customers at random destinations.",
    tools: []
// AIFunctionFactory.Create((Func<string>)GetRandomDestination)
)
.AsBuilder()
.UseOpenTelemetry(sourceName: "agent-telemetry-source")
.Build();

Console.WriteLine(await agent.RunAsync("Plan me a day trip. result in table format. destination is india "));

// McpServerTool tool = McpServerTool.Create(agent.AsAIFunction());
// HostApplicationBuilder builder = Host.CreateEmptyApplicationBuilder(settings: null);
// builder.Services
//     .AddMcpServer()
//     .WithStdioServerTransport()
//     .WithTools([tool]);

// await builder.Build().RunAsync();

