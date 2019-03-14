FROM codercom/code-server:latest
EXPOSE 5000
EXPOSE 5001
EXPOSE 4200

RUN apt-get install -y wget
RUN apt install -y curl
RUN apt-get install -y software-properties-common
#node
RUN curl -sL https://deb.nodesource.com/setup_10.x | bash -
RUN apt install -y nodejs
RUN npm install -g @angular/cli

#dotnet core
RUN wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN add-apt-repository universe
RUN apt-get install -y apt-transport-https
RUN apt-get update
RUN apt-get install -y dotnet-sdk-2.2
#opzetten reverse proxy (NGINX)
#docker run -t -p 127.0.0.1:8443:8443 -p 127.0.0.1:5000:5000 -p 127.0.0.1:4200:4200 -v "C:\src\github\GraphQL-Heroes:/root/project" coreserver --allow-http --no-auth