#FROM microsoft/aspnet AS build-env
FROM microsoft/dotnet-framework:4.6.2 AS build-env
#WORKDIR /app

COPY ./Debug ./app
#ENTRYPOINT ConsoleApp4.exe
CMD c:\\app\\ConsoleApp4.exe
#CMD ["ping", "-t -4 localhost"]