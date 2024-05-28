### Tópicos en Arquitectura de Software: Microservicios

#### 1. Tema

Para el siguiente componente individual del trabajo, se abordará el tema de Microservicios, el cual pertenece a la categoría de Arquitectura de Software.

#### 2. Desarrollo Conceptual

Los microservicios representan una arquitectura de software donde una aplicación se divide en un conjunto de servicios pequeños e independientes. Cada servicio es autónomo y se comunica con otros servicios a través de APIs bien definidas. Esta arquitectura permite que cada microservicio se desarrolle, despliegue y escale de manera independiente, facilitando una mayor agilidad y resiliencia en el desarrollo y operación de software.

Según Newman (2015), los microservicios permiten a las organizaciones ser más ágiles, ya que los equipos pueden trabajar en diferentes servicios de manera simultánea, sin afectar a los demás. Fowler (2014) resalta que los microservicios son una evolución de las arquitecturas orientadas a servicios (SOA), con un enfoque en servicios más pequeños y especializados. Estos servicios están diseñados para cumplir con una funcionalidad específica del negocio, lo que reduce el acoplamiento y permite una mayor flexibilidad y escalabilidad.

En la arquitectura de microservicios, cada servicio se centra en una funcionalidad específica del negocio, y puede ser desarrollado con diferentes tecnologías y lenguajes de programación. Esta independencia técnica permite una mejor adopción de nuevas tecnologías y una mayor flexibilidad para los equipos de desarrollo. Además, la arquitectura de microservicios facilita el despliegue continuo y la entrega rápida de nuevas funcionalidades, lo que es esencial en entornos de desarrollo ágiles y dinámicos.

Los microservicios también promueven la resiliencia y la tolerancia a fallos. Dado que cada servicio es independiente, el fallo de un microservicio no afecta a toda la aplicación. Esto permite que los sistemas sean más robustos y capaces de manejar errores sin interrupciones significativas. La independencia de los servicios también facilita la implementación de prácticas de DevOps, como la integración continua y el despliegue continuo (CI/CD), lo que mejora la eficiencia y la calidad del software.

#### 3. Consideraciones Técnicas

**3.1. Instalación y Configuración**

Para implementar microservicios, se pueden utilizar diferentes herramientas y plataformas. En este caso, utilizaré .NET y Docker para contenerizar los microservicios, y Kubernetes para su orquestación.

**Instalación de Docker**

1. **Descargar Docker Desktop** desde [Docker Desktop para Windows](https://www.docker.com/products/docker-desktop).
2. **Instalar Docker Desktop** siguiendo las instrucciones del instalador.
3. **Verificar la instalación** ejecutando `docker --version` en el terminal.

**Instalación de Kubernetes**

1. Kubernetes se incluye con Docker Desktop. Asegúrate de habilitar Kubernetes en las configuraciones de Docker Desktop.
2. Verificar la instalación de Kubernetes ejecutando `kubectl version` en el terminal.

**3.2. Contenerización de Microservicios**

Crear un archivo `Dockerfile` para contenerizar un servicio.

# Establecer la imagen base para la fase de construcción
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copiar el archivo de proyecto y restaurar dependencias
COPY myFirstService/myFirstService.csproj .
RUN dotnet restore

# Copiar el resto del código y construir el proyecto
COPY . .
RUN dotnet build "myFirstService.csproj" -c Release -o /app/build

# Publicar el proyecto
RUN dotnet publish "myFirstService.csproj" -c Release -o /app/publish

# Establecer la imagen base para el contenedor de producción
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copiar los archivos publicados desde la fase de construcción
COPY --from=build /app/publish .

# Establecer el punto de entrada
ENTRYPOINT ["dotnet", "myFirstService.dll"]


Construir y ejecutar la imagen Docker:


docker build -t myfirstservice .
docker run -d -p 8080:80 --name myfirstservicecontainer myfirstservice


#### 4. Demo

**Repositorio en GitHub:**
- [Microservicios con .Net](https://github.com/MXLEOMX/Microservicios-con-.Net)

**4.1. Escenario Práctico**

Tengo una tienda llamada "MyShop". Quiero asegurarme de que el servicio de gestión de productos sea robusto y escalable. Por eso, decido implementar este servicio como un microservicio independiente utilizando .NET y Docker.

**4.2. Pasos para la Demo**

1. **Crear el Proyecto en .NET**


dotnet new webapi -n ProductService --no-https
cd ProductService


2. **Escribir el Dockerfile**

Crear un archivo `Dockerfile` en el directorio raíz del proyecto con el contenido proporcionado anteriormente.

3. **Construir y Ejecutar la Imagen Docker**


docker build -t productservice .
docker run -d -p 8080:80 --name productservicecontainer productservice


4. **Verificar el Servicio**

Abre un navegador web y navega a `http://localhost:8080/swagger` para ver la documentación Swagger generada automáticamente de la API.

**4.3. Código del Servicio en github**

https://github.com/MXLEOMX/Microservicios-con-.Net

**4.4. Resultados**

La API de gestión de productos debería estar operativa y accesible a través de Swagger en el puerto 8080. Esto permite interactuar con los endpoints del microservicio y verificar su funcionamiento. La implementación de este servicio demuestra la capacidad de los microservicios para ser desplegados y escalados de manera independiente, mejorando la resiliencia y la capacidad de respuesta del sistema.

### 5. Referencias

- Newman, S. (2015). Building Microservices: Designing Fine-Grained Systems. O'Reilly Media, Inc.
- Fowler, M. (2014). Microservices: a definition of this new architectural term. martinfowler.com.

