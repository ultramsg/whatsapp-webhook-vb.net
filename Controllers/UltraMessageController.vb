Imports Microsoft.AspNetCore.Mvc
Imports System
Imports System.Text.Json

Namespace WebHookVB.Controllers
    <Route("api/")>
    <ApiController>
    Public Class UltraMessageController
        Inherits ControllerBase
        <HttpPost>
        Public Function Post(
        <FromBody> ByVal data As HookData) As IActionResult
            Console.WriteLine(JsonSerializer.Serialize(data))
            Return MyBase.Ok(data)
        End Function
    End Class
End Namespace
