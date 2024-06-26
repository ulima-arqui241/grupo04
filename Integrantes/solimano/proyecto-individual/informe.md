# Arquitectura de Software: Microservicios

## Introducción
La arquitectura de microservicios es una metodología de desarrollo de software que estructura una aplicación como una colección de servicios pequeños y autónomos, cada uno ejecutándose en su propio proceso y comunicándose con mecanismos ligeros, generalmente HTTP. Este enfoque contrasta con la arquitectura monolítica tradicional, donde una aplicación se desarrolla y despliega como una única unidad cohesiva.

## Desarrollo Conceptual

### Microservicios

- **Definición**: Los microservicios son una técnica de desarrollo de software que descompone las aplicaciones en pequeños servicios independientes que se comunican entre sí a través de interfaces bien definidas.
- **Principios**:
  - **Desacoplamiento**: Cada servicio es independiente y puede desarrollarse, desplegarse y escalarse de manera autónoma.
  - **Orientación a Negocios**: Los servicios suelen alinearse con capacidades de negocio, facilitando un desarrollo más ágil y dirigido por las necesidades del cliente.
  - **Comunicación Ligera**: Utilizan protocolos ligeros como HTTP/REST o mensajería ligera para la comunicación entre servicios.
  - **Despliegue Independiente**: Los servicios pueden desplegarse sin necesidad de desplegar toda la aplicación.
  - **Tolerancia a Fallos**: Los servicios están diseñados para manejar fallos de manera autónoma y no afectar al sistema global.
 
<p align="center">
  <img src="https://github.com/ulima-arqui241/grupo04/assets/122492617/183755b4-9826-4ade-a34d-d52b4ad7fa43" alt="image">
</p>

## Comparación con Arquitectura Monolítica

### Arquitectura Monolítica

- **Definición**: Una aplicación monolítica es una aplicación de software donde diferentes componentes están interconectados y dependientes unos de otros, desplegados como una sola unidad.
- **Ventajas**:
  - **Simplicidad**: Fácil de desarrollar, probar y desplegar en etapas iniciales.
  - **Rendimiento**: Puede ser más eficiente en términos de rendimiento debido a la menor sobrecarga de comunicación.
  - **Transacciones**: Manejar transacciones distribuidas es más sencillo ya que todo el código está en un solo lugar.
- **Desventajas**:
  - **Escalabilidad**: Difícil de escalar horizontalmente ya que toda la aplicación debe escalarse.
  - **Mantenimiento**: A medida que la aplicación crece, el código se vuelve complejo y difícil de mantener.
  - **Despliegue**: Un pequeño cambio requiere volver a desplegar toda la aplicación, lo cual puede ser riesgoso y costoso en términos de tiempo.
  - **Flexibilidad**: Restringe el uso de diferentes tecnologías y lenguajes de programación.

<p align="center">
  <img src="https://github.com/ulima-arqui241/grupo04/assets/122492617/567b3116-b5fb-45ce-8b0e-7a225ba78f95" alt="image">
</p>

### Microservicios

- **Ventajas**:
  - **Escalabilidad**: Cada servicio puede escalarse de manera independiente según su necesidad de carga.
  - **Despliegue Continuo**: Permite despliegues frecuentes y más seguros, ya que los cambios se hacen en servicios pequeños y aislados.
  - **Tecnologías Diversas**: Cada servicio puede desarrollarse con la tecnología más adecuada para su función específica.
  - **Tolerancia a Fallos**: Aislamiento de fallos, donde el fallo de un servicio no necesariamente impacta a toda la aplicación.
  - **Mantenibilidad**: Facilita el mantenimiento y la evolución de la aplicación al permitir cambios en servicios individuales sin afectar a otros.
- **Desventajas**:
  - **Complejidad**: Introduce complejidades en términos de gestión de datos, transacciones distribuidas, y comunicación entre servicios.
  - **Sobrecarga Operativa**: Requiere una infraestructura más robusta para manejar la orquestación y monitoreo de múltiples servicios.
  - **Latencia**: La comunicación entre servicios puede introducir latencias adicionales.
  - **Seguridad**: Aumenta la superficie de ataque debido a la exposición de múltiples endpoints.

<p align="center">
  <img src="https://github.com/ulima-arqui241/grupo04/assets/122492617/8f2213a4-1885-4ccc-a6fc-c5dec0a0749f" alt="image">
</p>

## Consideraciones Técnicas

Para involucrarse con la arquitectura de microservicios, es crucial considerar ciertos aspectos técnicos:

1. **Descomposición del Sistema**:
   - Identificar las capacidades de negocio y descomponer la aplicación en servicios independientes.
   - Definir interfaces claras y bien documentadas para la comunicación entre servicios.

2. **Comunicación entre Servicios**:
   - Usar protocolos ligeros como HTTP/REST, gRPC o mensajería (e.g., RabbitMQ, Kafka).
   - Implementar patrones como API Gateway para centralizar las llamadas a servicios.

3. **Gestión de Datos**:
   - Adoptar bases de datos descentralizadas, donde cada servicio maneja su propia base de datos.
   - Manejar la consistencia eventual y evitar transacciones distribuidas complejas.

4. **Despliegue y Orquestación**:
   - Utilizar contenedores (e.g., Docker) para empaquetar servicios.
   - Implementar orquestadores como Kubernetes para gestionar el despliegue, escalado y monitoreo de los contenedores.

5. **Monitoreo y Trazabilidad**:
   - Implementar soluciones de monitoreo y logging centralizado (e.g., ELK Stack, Prometheus, Grafana).
   - Utilizar herramientas de trazabilidad distribuida (e.g., Jaeger, Zipkin) para rastrear las solicitudes a través de múltiples servicios.

6. **Seguridad**:
   - Implementar autenticación y autorización robusta (e.g., OAuth2, JWT).
   - Asegurar la comunicación entre servicios con TLS.

## Demo (Escenario / Código)

Imagina que estás construyendo una aplicación de tienda online donde los clientes pueden registrarse, navegar por los productos y hacer pedidos. Vamos a usar nuestros microservicios (UserService, ProductService y OrderService) para gestionar esta funcionalidad.

### Escenario

#### Registro de Usuarios:
- Un nuevo usuario se registra en la tienda online proporcionando su nombre y correo electrónico.

#### Registro de Productos:
- El administrador de la tienda agrega nuevos productos al catálogo, especificando el nombre y el precio de cada producto.

#### Creación de Pedidos:
- Un usuario registrado puede hacer un pedido seleccionando productos y especificando la cantidad.


El código de demostración se ha desarrollado utilizando .NET Core y se encuentra disponible en el [repositorio de GitHub](https://github.com/MXLEOMX/MicroservicesDemo). Este código incluye tres microservicios (`UserService`, `ProductService`, `OrderService`) que se comunican entre sí para manejar la creación y consulta de órdenes, usuarios y productos.

Además, en el siguiente enlace se proporcionará la guía para crear un microservicio desde CERO: https://docs.google.com/document/d/1kNID5updjBwSQpOm7Hvn0BKTityLwiak/edit?usp=sharing&ouid=111933879657736861856&rtpof=true&sd=true

Enlace a la guía del video por google drive: https://drive.google.com/file/d/1zmVBthpLbzWtXPCGtvA8hkYhSdeCNu-A/view?usp=drive_link

Enlace a la guía del video por youtube: https://youtu.be/jNX3jHkIxH4

## Recursos

#### Libros
- Newman, S. (2021). **Building Microservices: Designing Fine-Grained Systems** (2nd ed.). O'Reilly Media.
- Richardson, C. (2018). **Microservices Patterns: With examples in Java**. Manning Publications.

#### Artículo 
- Fowler, M. (2014). **Microservices: a definition of this new architectural term**. Retrieved from [https://martinfowler.com/articles/microservices.html](https://martinfowler.com/articles/microservices.html)

#### Documentación
- Microsoft. (2023). **Introduction to Microservices on Azure**. Retrieved from [https://docs.microsoft.com/en-us/azure/architecture/microservices/](https://docs.microsoft.com/en-us/azure/architecture/microservices/)
- Kubernetes. (2023). **Kubernetes Documentation**. Retrieved from [https://kubernetes.io/docs/home/](https://kubernetes.io/docs/home/)
- Docker. (2023). **Docker Documentation**. Retrieved from [https://docs.docker.com/](https://docs.docker.com/)

#### Curso

- Udemy. (2023). **Microservices with Node JS and React**. Available at [https://www.udemy.com/course/microservices-with-node-js-and-react/](https://www.udemy.com/course/microservices-with-node-js-and-react/)

## Conclusión

La arquitectura de microservicios ofrece ventajas significativas en términos de escalabilidad, despliegue y mantenibilidad en comparación con la arquitectura monolítica. Sin embargo, también introduce complejidades adicionales que deben ser gestionadas cuidadosamente. Adoptar microservicios requiere una comprensión profunda de los principios de diseño y un ecosistema tecnológico robusto para manejar la comunicación, seguridad y despliegue de servicios independientes.

Esta revisión proporciona una base sólida para comprender los beneficios y desafíos de los microservicios, ofreciendo una comparación clara con las arquitecturas monolíticas tradicionales. Con la correcta implementación y gestión, los microservicios pueden facilitar un desarrollo más ágil y resistente para aplicaciones modernas.

## Referencias

- Fowler, M. (2014). **Microservices: a definition of this new architectural term**. Retrieved from [https://martinfowler.com/articles/microservices.html](https://martinfowler.com/articles/microservices.html)
- Newman, S. (2021). **Building Microservices: Designing Fine-Grained Systems** (2nd ed.). O'Reilly Media.
- Microsoft. (2023). **Introduction to Microservices on Azure**. Retrieved from [https://docs.microsoft.com/en-us/azure/architecture/microservices/](https://docs.microsoft.com/en-us/azure/architecture/microservices/)
- Pahl, C., Brogi, A., Soldani, J., & Jamshidi, P. (2018). **Cloud Container Technologies: a State-of-the-Art Review**. *IEEE Transactions on Cloud Computing*, 7(3), 677-692. doi:10.1109/TCC.2017.2702586


