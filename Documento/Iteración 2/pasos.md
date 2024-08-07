## Iteración 2: Identificar Estructuras que Soporten Funcionalidad Primaria

### Paso 2: Establecer Objetivo de la Iteración

El objetivo de esta iteración será identificar las estructuras que soportan a los elementos de funcionalidad primaria. Para esta iteración, se podrían priorizar por dificultad e importancia los casos de uso, teniendo así los UC-01, UC-02, UC-03 y UC-06.

| Propósito                                                      | Funcionalidad Primaria                   | Escenarios de Calidad                    | Restricciones y Preocupaciones         |
| -------------------------------------------------------------- | ---------------------------------------- | ---------------------------------------- | -------------------------------------- |
| Implementación de estructuras que den soporte a la funcionalidad primaria. | UC-01, UC-05 soportan las funcionalidades anteriores | QA-06, QA-09, QA-11, QA-13, QA-15, QA-16 | CON-03, CON-04, CON-05, CON-06         |

### Paso 3: Elegir uno o más Elementos del Sistema a Refinar

Se refinarán las capas de arquitectura que fueron definidas en la iteración anterior, buscando asegurar que no existan problemas mayores en los siguientes componentes del sistema:

- Registro e inicio de sesión (UC-01, UC-02)
- Creación de grupos de estudio (UC-03)
- Gestión de contenidos (UC-06)

### Paso 4: Elegir uno o más Conceptos de Diseño que Satisfacen el Driver Seleccionado

| ID    | Decisión de Diseño                  | Fundamentación                                                                                                                                                                                                                                                                                                                                                                                                                        |
|-------|-------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| DEC-7 | Descomponer en módulos              | Esta decisión brinda una oportunidad para la implementación de prácticas de modularidad y reusabilidad. En el contexto de una plataforma educativa, la modularidad permite que diferentes equipos trabajen en paralelo en distintas funcionalidades como gestión de usuarios, grupos de estudio, y recursos educativos. Además, facilita el mantenimiento y la evolución de la plataforma, permitiendo añadir o modificar módulos sin afectar al sistema completo. |
| DEC-8 | Uso de caching                      | Implementado con el objetivo principal de agilizar las consultas más usadas en el sistema. En una plataforma educativa, es crucial que las respuestas a consultas frecuentes, como la visualización de grupos, recursos educativos y mensajes, sean rápidas para mejorar la experiencia del usuario. El caching reduce la carga en la base de datos y mejora significativamente los tiempos de respuesta, lo cual es vital para mantener a los usuarios comprometidos y satisfechos. |
| DEC-9 | S3 para el almacenamiento de archivos| Se almacenarán en un S3 los archivos y grabaciones que los usuarios deseen subir. La alta escalabilidad y seguridad del servicio son fundamentales. En una plataforma educativa, los usuarios necesitan subir y acceder a una gran cantidad de materiales educativos, incluyendo documentos, videos y grabaciones de sesiones. Amazon S3 ofrece almacenamiento escalable y seguro, asegurando que los datos de los usuarios estén siempre disponibles y protegidos contra pérdidas y accesos no autorizados. |
| DEC-10| Uso de solución de videollamadas Agora.io | Por su escalabilidad, servidores distribuidos y fácil integración, asegurando alto rendimiento y seguridad. En una plataforma educativa, las videollamadas y transmisiones en tiempo real son esenciales para clases virtuales y reuniones de grupo. Agora.io proporciona una solución robusta que puede manejar altas demandas de conexión y mantener una calidad de servicio superior, lo cual es crítico para la efectividad del aprendizaje en línea. |

### Paso 5: Instanciar Elementos de Arquitectura, Asignar Responsabilidades y Definir Interfaces

| Elemento de Arquitectura | Descripción                                                                           | Fundamentación                                                                                                                                                                                                                                                                                                                                                  |
|--------------------------|---------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Amazon S3                | Servicio de almacenamiento en la nube ofrecido por AWS. Implementado para el almacenamiento de archivos de usuarios. | Amazon S3 ofrece almacenamiento escalable y seguro, asegurando que los datos de los usuarios estén siempre disponibles y protegidos contra pérdidas y accesos no autorizados. Esta capacidad es crucial para gestionar la gran cantidad de materiales educativos que los usuarios subirán y accederán en la plataforma.                                                                                                           |
| Agora.io                 | Servicio de videollamadas que permite a la aplicación web crear aplicaciones de chat y transmisión en tiempo real. | Agora.io proporciona una solución robusta que puede manejar altas demandas de conexión y mantener una calidad de servicio superior, lo cual es crítico para la efectividad del aprendizaje en línea. Su escalabilidad, servidores distribuidos y fácil integración aseguran un alto rendimiento y seguridad en las comunicaciones en tiempo real, esenciales para clases virtuales y reuniones de grupo.             |

### Paso 6: Bosquejar Vistas y Registrar Decisiones de Diseño
![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/4271d8ff-ff40-4199-88d6-d64d91414e36)

**Fundamentación:**
El diagrama de componentes refinados desglosa aún más la arquitectura del servidor de aplicaciones, integrando servicios externos esenciales para el funcionamiento de la plataforma educativa. Esta estructura detallada facilita la comprensión de cómo se manejan las diversas funcionalidades y cómo interactúan con servicios externos.

- **Web Browser:** El navegador web sigue siendo el punto de interacción del usuario con la plataforma educativa, enviando solicitudes al servidor de aplicaciones.
- **Servidor de Aplicaciones:** Maneja la lógica de negocio de la plataforma y se descompone en varios controladores específicos para diferentes funcionalidades:

  - **Controlador de Usuarios:** Gestiona todas las operaciones CRUD (Crear, Leer, Actualizar, Eliminar) relacionadas con los usuarios, como el registro, la actualización de perfiles y la eliminación de cuentas. Esta separación mejora la organización del código y facilita el mantenimiento.
  - **Controlador de Grupos:** Responsable de las operaciones relacionadas con la gestión de grupos de estudio, incluyendo la creación, modificación y eliminación de grupos. Permite a los administradores y moderadores gestionar los grupos de manera eficiente.
  - **Controlador de Contenidos:** Gestiona los recursos educativos compartidos en la plataforma, permitiendo la subida, modificación y acceso a materiales educativos. Esta modularidad facilita la extensión y el mantenimiento del sistema.

- **Base de Datos:** La interacción con la base de datos se realiza a través de los controladores, que manejan las operaciones específicas. Esto asegura una separación clara entre la lógica de negocio y la gestión de datos, mejorando la escalabilidad y la seguridad del sistema. La base de datos almacena de manera persistente toda la información relacionada con usuarios, grupos y contenidos educativos.
- **Servicios Externos:** La plataforma integra servicios externos que son esenciales para su funcionalidad:

  - **Amazon S3:** Utilizado para el almacenamiento de archivos y grabaciones que los usuarios deseen subir. La alta escalabilidad y seguridad del servicio son fundamentales para gestionar la gran cantidad de materiales educativos que los usuarios generan y consumen.
  - **Agora.io:** Servicio de videollamadas que permite a la aplicación web crear aplicaciones de chat y transmisión en tiempo real. Su escalabilidad, servidores distribuidos y fácil integración aseguran un alto rendimiento y seguridad en las comunicaciones en tiempo real, esenciales para clases virtuales y reuniones de grupo.


### Paso 7: Analizar el Diseño Actual, Revisar Objetivo de la Iteración y Logro del Propósito de Diseño

| No Abordado | Parcialmente Abordado | Completamente Abordado | Decisión de Diseño              |
| ----------- | --------------------- | ---------------------- | ------------------------------- |
| QA-06       |                       |                        |                                 |
| QA-09       |                       |                        |                                 |
| UC-01       | UC-02, UC-03, UC-06   |                        | DEC-7, DEC-8, DEC-9, DEC-10     |
| QA-11       |                       |                        |                                 |
| QA-13       |                       |                        |                                 |
| QA-15       |                       |                        |                                 |
| QA-16       |                       |                        |                                 |
| CON-03      | CON-04                |                        |                                 |
| CON-05      | CON-06                |                        |                                 |
