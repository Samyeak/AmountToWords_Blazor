FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY bin/Release/netcoreapp3.1/publish/ BlazorAmountToWords/
COPY bin/Release/netcoreapp3.1/publish/wwwroot wwwroot/
# WORKDIR /BlazorAmountToWords
ENTRYPOINT ["dotnet", "BlazorAmountToWords/BlazorAmountToWords.dll"]
EXPOSE 80
EXPOSE 443