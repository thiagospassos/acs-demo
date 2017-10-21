cd Web
dotnet publish .\Web.csproj -c Release -o ./obj/Docker/publish
docker build -t demo-web .
cd ..
docker tag demo-web thiago.azurecr.io/demo-web:%1
docker push thiago.azurecr.io/demo-web:%1
kubectl set image deployment/demo-web demo-web=thiago.azurecr.io/demo-web:%1