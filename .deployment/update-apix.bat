cd ApiX
dotnet publish .\ApiX.csproj -c Release -o ./obj/Docker/publish
docker build -t apix .
cd ..
docker tag apix thiago.azurecr.io/apix:%1
docker push thiago.azurecr.io/apix:%1
kubectl set image deployment/apix apix=thiago.azurecr.io/apix:%1