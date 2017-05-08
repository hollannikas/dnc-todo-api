FROM microsoft/aspnetcore-build
COPY . /app
WORKDIR /app/TodoApp.Test
RUN ["dotnet", "restore"]
RUN ["dotnet", "xunit"]
WORKDIR /app/TodoApp
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
EXPOSE 80/tcp
RUN chmod +x ./entrypoint.sh
CMD /bin/bash ./entrypoint.sh