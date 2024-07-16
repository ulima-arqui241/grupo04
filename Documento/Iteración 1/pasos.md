## Iteración 1: Establecer Estructura General del Sistema

## Paso 2: Establecer Objetivo de la Iteración

En base a las entradas especificadas, el objetivo de esta primera iteración es realizar un diseño inicial de la estructura de la plataforma, abarcando los atributos más importantes de disponibilidad, rendimiento y seguridad.

| Propósito                                         | Funcionalidad Primaria      | Escenarios de Calidad    | Restricciones y Preocupaciones       |
| ------------------------------------------------- | --------------------------- | ------------------------ | ------------------------------------- |
| Plataforma desde 0. Se busca producir un diseño detallado. | UC-01, UC-02, UC-03, UC-06 | QA-01, QA-03, QA-05     | CRN-01, CRN-02, CON-01, CON-02, CON-05 |

## Paso 3: Elegir uno o más Elementos del Sistema a Refinar

No hay elementos a refinar, pues se está diseñando el sistema desde 0.

## Diagrama de Contexto
![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/38008883-d9de-4632-ac5e-b16c7e9fee50)

**Fundamentación:**
El diagrama de contexto proporciona una visión general y simplificada de la plataforma educativa, destacando la interacción principal entre el cliente y los componentes clave del sistema. Este diagrama ayuda a entender cómo los usuarios finales interactúan con la plataforma y cómo se manejan las operaciones fundamentales.

- **Cliente:** Representa al usuario final que interactúa con la plataforma educativa. Los clientes pueden ser estudiantes, administradores, moderadores o cualquier persona que utilice la plataforma para acceder a recursos educativos, participar en grupos de estudio o realizar otras actividades relacionadas.
- **Plataforma Educativa:** Es el sistema central que facilita la interacción del usuario y maneja las operaciones críticas de la plataforma. Dentro de la plataforma educativa se encuentran los siguientes componentes:

  - **Servidor de Aplicaciones:** Maneja la lógica de negocio y procesa las solicitudes de los usuarios. Este componente es responsable de realizar las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre los datos almacenados en la base de datos. Asegura que las solicitudes del usuario se gestionen de manera eficiente y segura.
  - **Base de Datos:** Almacena de manera persistente toda la información relacionada con los usuarios, grupos, contenidos educativos y otras entidades relevantes. La base de datos es accesible a través del servidor de aplicaciones, que ejecuta las operaciones necesarias para mantener la integridad y disponibilidad de los datos.

### Paso 4: Elegir uno o más Conceptos de Diseño que Satisfacen el Driver Seleccionado

| ID   | Decisión de Diseño                                   | Fundamentación                                                                                                                                                                                                                                                                                                                                                                                                                                |
|------|------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| DEC-1 | App front y back serán deployeados en un EC2         | Elegimos Amazon EC2 para desplegar la plataforma educativa porque permite escalar recursos fácilmente según la demanda, lo que es vital durante periodos de alta actividad como exámenes. EC2 garantiza alta disponibilidad y rendimiento, asegurando que los usuarios siempre tengan acceso rápido y continuo. Además, su integración con otros servicios de AWS como CloudWatch e IAM nos facilita la gestión y el monitoreo, añadiendo una capa extra de seguridad y estabilidad. |
| DEC-2 | Base de datos relacional en RDS y uso de DynamoDB    | Optamos por una base de datos relacional en RDS para manejar relaciones complejas y asegurar la integridad de los datos. DynamoDB se utiliza por su escalabilidad y alto rendimiento en operaciones de lectura y escritura. RDS nos facilita la administración y recuperación ante desastres, mientras que DynamoDB maneja grandes volúmenes de datos con baja latencia. Esta combinación es esencial para gestionar eficazmente los recursos educativos y la interacción entre los usuarios. |
| DEC-3 | Patrón de despliegue three-tier                      | Implementamos un patrón three-tier que divide la aplicación en capas de presentación, lógica de negocio y datos. Esto mejora la mantenibilidad y escalabilidad del sistema, permitiendo un desarrollo modular y una mejor seguridad al restringir el acceso directo a la base de datos. Cada capa puede escalarse independientemente, optimizando recursos y mejorando el rendimiento general, lo cual es especialmente beneficioso para nuestra plataforma educativa. |
| DEC-4 | Interfaz de plataforma en React y TailwindCSS        | Usamos React por su eficiencia en la gestión del DOM virtual y su estructura basada en componentes, lo que facilita la creación de interfaces de usuario dinámicas y responsivas. TailwindCSS nos permite un diseño rápido y personalizable, utilizando clases utilitarias que agilizan el desarrollo. Ambas tecnologías son populares y bien soportadas, reduciendo la curva de aprendizaje y facilitando el mantenimiento y la evolución de la plataforma. Estas características son clave para ofrecer una experiencia de usuario atractiva y eficiente. |
| DEC-5 | MVC en backend                                       | El patrón MVC (Modelo-Vista-Controlador) nos permite una clara separación de responsabilidades, mejorando la organización y mantenibilidad del código. Este enfoque modular facilita la adición de nuevas funcionalidades, la modificación de las existentes y la resolución de problemas. Además, asegura una mayor consistencia y coherencia en el desarrollo de la aplicación. MVC es ampliamente adoptado y compatible con muchas tecnologías backend, proporcionando flexibilidad y soporte, esencial para la robustez y escalabilidad de nuestra plataforma educativa. |

### Paso 5: Instanciar Elementos de Arquitectura, Asignar Responsabilidades y Definir Interfaces

| Elemento de Arquitectura | Descripción                                                                                          | Fundamentación                                                                                                                                                                                                                                                                                                                                                  |
|--------------------------|------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Amazon EC2               | Implementación de un servicio web externo en la nube, principalmente por la facilidad de implementación de diversos servicios AWS. | Amazon EC2 permite ajustar los recursos según la demanda, asegurando alta disponibilidad y rendimiento. La infraestructura de AWS ofrece soporte y herramientas adicionales para la gestión y monitoreo del sistema, lo cual es crucial para garantizar la seguridad y la estabilidad de una plataforma educativa que requiere alta disponibilidad y capacidad de adaptación rápida a cambios en la carga de trabajo. |
| Patrón de despliegue three-tier | Despliegue de la aplicación en tres capas: presentación, aplicación y datos.                      | La implementación de un patrón Three-tier divide la aplicación en capas de presentación, lógica de negocio y datos, mejorando la mantenibilidad y escalabilidad del sistema. Esta separación permite un desarrollo modular, facilita la identificación y resolución de problemas, y mejora la seguridad al restringir el acceso directo a la base de datos. Además, cada capa puede escalarse independientemente, optimizando el uso de recursos y mejorando el rendimiento general. Esto es particularmente beneficioso para una plataforma educativa donde la carga puede variar significativamente. |
| Patrón de arquitectura MVC | Implementación del patrón MVC para la arquitectura del backend de la aplicación web.                  | El patrón MVC (Modelo-Vista-Controlador) permite una clara separación de responsabilidades, mejorando la organización y mantenibilidad del código. Este enfoque modular facilita la adición de nuevas funcionalidades, la modificación de las existentes y la resolución de problemas, al mismo tiempo que asegura una mayor consistencia y coherencia en el desarrollo de la aplicación. MVC también es ampliamente adoptado y compatible con muchas tecnologías backend, lo que proporciona flexibilidad y soporte. Esto es esencial para la robustez y escalabilidad de una plataforma educativa compleja. |

## Paso 6: Bosquejar Vistas y Registrar Decisiones de Diseño
## Diagrama de Contenedores
![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/f846ce97-36a8-49e0-be2a-aa8225e7a963)

**Fundamentación:**
El diagrama de contenedores ilustra la arquitectura de alto nivel de la plataforma educativa, destacando la interacción entre los componentes principales. La separación en distintos contenedores facilita la comprensión de cómo se comunican los distintos elementos del sistema y cómo se gestionan las responsabilidades.

- **Usuario:** Representa al cliente final que interactúa con la plataforma educativa a través de un navegador web.
- **Web Browser:** El navegador web actúa como el cliente desde donde los usuarios interactúan con la plataforma educativa. Esta separación es crucial para mantener la modularidad y escalabilidad del sistema, permitiendo actualizaciones y mejoras en la interfaz de usuario sin afectar la lógica del servidor.
- **REST API y API Gateway:** Se utiliza un gateway de API para manejar las solicitudes de la API REST. Este componente es esencial para gestionar la autenticación, el enrutamiento de solicitudes y la agregación de datos, mejorando la seguridad y la eficiencia de la comunicación entre el cliente y el servidor.
- **Sistema de Autenticación:** Un sistema dedicado a la verificación de usuarios asegura que solo los usuarios autenticados puedan acceder a las funcionalidades de la plataforma, garantizando la seguridad y privacidad de los datos.
- **Servidor de Aplicaciones:** Maneja la lógica de negocio y las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre la base de datos. Esta separación permite una gestión más eficiente de los recursos y facilita el mantenimiento del sistema.
- **Base de Datos:** Se encarga del almacenamiento persistente de datos. La separación de la base de datos en un contenedor independiente permite una gestión más segura y eficiente de los datos, y facilita la implementación de mecanismos de replicación y recuperación ante desastres.



## Diagrama de Componentes
![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/ff78f2aa-ba72-4d40-a44b-cd1b9ebb1181)

**Fundamentación:**
El diagrama de componentes desglosa la arquitectura del servidor de aplicaciones en módulos más pequeños, detallando las responsabilidades y las interacciones entre ellos. Esta estructuración facilita el desarrollo, mantenimiento y escalabilidad del sistema.

- **Web Browser:** El navegador web actúa como el cliente desde donde los usuarios envían solicitudes a la plataforma educativa. Esta capa se encarga de la interacción del usuario con la interfaz de la aplicación.
- **Servidor de Aplicaciones:** Maneja la lógica de negocio de la plataforma y se descompone en varios controladores específicos para diferentes funcionalidades.

  - **Controlador de Usuarios:** Maneja todas las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) relacionadas con los usuarios, como el registro, la actualización de perfiles y la eliminación de cuentas. Esta separación mejora la organización del código y facilita el mantenimiento.
  - **Controlador de Grupos:** Responsable de las operaciones relacionadas con la gestión de grupos de estudio, incluyendo la creación, modificación y eliminación de grupos. Permite a los administradores y moderadores gestionar los grupos de manera eficiente.
  - **Controlador de Contenidos:** Gestiona los recursos educativos compartidos en la plataforma, permitiendo la subida, modificación y acceso a materiales educativos. Esta modularidad facilita la extensión y el mantenimiento del sistema.
- **Base de Datos:** La interacción con la base de datos se realiza a través de los controladores, que manejan las operaciones específicas. Esto asegura una separación clara entre la lógica de negocio y la gestión de datos, mejorando la escalabilidad y la seguridad del sistema. La base de datos almacena de manera persistente toda la información relacionada con usuarios, grupos y contenidos educativos.




## Paso 7: Analizar el Diseño Actual, Revisar Objetivo de la Iteración y Logro del Propósito de Diseño

| No Abordado | Parcialmente Abordado     | Completamente Abordado | Decisión de Diseño              |
| ----------- | ------------------------- | ---------------------- | ------------------------------- |
| UC-03       |                           |                        |                                 |
|             | UC-01, UC-02, UC-06       |                        | DEC-1, DEC-2, DEC-3, DEC-4      |
|             |                           | QA-01                  | DEC-1, DEC-3                    |
|             |                           | QA-03                  | DEC-4, DEC-5                    |
|             |                           | QA-05                  | DEC-3, DEC-4                    |
|             |                           | CRN-01                 | DEC-1, DEC-2, DEC-3, DEC-4      |
|             |                           | CRN-02                 | DEC-1, DEC-3                    |
|             |                           | CON-01                 | DEC-1, DEC-2, DEC-4             |
|             |                           | CON-02                 | DEC-1, DEC-3                    |
|             |                           | CON-05                 | DEC-4, DEC-5                    |
