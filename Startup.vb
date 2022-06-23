Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Namespace WebHookVB
    Public Class Startup
        Public Sub New(ByVal configuration As IConfiguration)
            Me.Configuration = configuration
        End Sub

        Public ReadOnly Property Configuration As IConfiguration

        Public Sub ConfigureServices(ByVal services As IServiceCollection)
            services.AddControllers()
        End Sub

        Public Sub Configure(ByVal app As IApplicationBuilder, ByVal env As IWebHostEnvironment)
            If env.IsDevelopment() Then

            End If

            app.UseHttpsRedirection()

            app.UseRouting()

            app.UseAuthorization()

            app.UseEndpoints(Sub(endpoints) endpoints.MapControllers())
        End Sub
    End Class
End Namespace
