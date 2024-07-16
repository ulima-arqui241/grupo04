## Iteración 1: Establecer Estructura General del Sistema

## Paso 2: Establecer Objetivo de la Iteración

En base a las entradas especificadas, el objetivo de esta primera iteración es realizar un diseño inicial de la estructura de la plataforma, abarcando los atributos más importantes de disponibilidad, rendimiento y seguridad.

| Propósito                                         | Funcionalidad Primaria      | Escenarios de Calidad    | Restricciones y Preocupaciones       |
| ------------------------------------------------- | --------------------------- | ------------------------ | ------------------------------------- |
| Plataforma desde 0. Se busca producir un diseño detallado. | UC-01, UC-02, UC-03, UC-06 | QA-01, QA-03, QA-05     | CRN-01, CRN-02, CON-01, CON-02, CON-05 |

## Paso 3: Elegir uno o más Elementos del Sistema a Refinar

No hay elementos a refinar, pues se está diseñando el sistema desde 0.

![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/38008883-d9de-4632-ac5e-b16c7e9fee50)

## Paso 4: Elegir uno o más Conceptos de Diseño que Satisfacen el Driver Seleccionado

| ID   | Decisión de Diseño                                     | Fundamentación                                                                                       |
| ---- | ------------------------------------------------------ | ---------------------------------------------------------------------------------------------------- |
| DEC-1 | App front y back serán deployeados en un EC2           | Se escoge Amazon EC2 para aprovechar la facilidad de escalamiento horizontal y vertical, así como la facilidad de implementación en diferentes instancias. Amazon EC2 permite ajustar los recursos según la demanda, asegurando alta disponibilidad y rendimiento. Además, la infraestructura de AWS ofrece soporte y herramientas adicionales para la gestión y monitoreo del sistema, lo cual es crucial para garantizar la seguridad y la estabilidad de una plataforma educativa que requiere alta disponibilidad y capacidad de adaptación rápida a cambios en la carga de trabajo. |
| DEC-2 | Base de datos relacional en RDS y uso de DynamoDB      | Se opta por una instancia de base de datos relacional en RDS para manejar las relaciones complejas y garantizar la integridad de los datos, y DynamoDB para aprovechar su escalabilidad y alto rendimiento en operaciones de lectura y escritura. RDS facilita la administración, respaldos automáticos y recuperación ante desastres, mientras que DynamoDB es ideal para manejar grandes volúmenes de datos con baja latencia, proporcionando flexibilidad en la arquitectura de datos. Esta combinación es esencial para gestionar eficazmente los recursos educativos y la interacción entre los usuarios en una plataforma educativa dinámica. |
| DEC-3 | Patrón de despliegue three-tier                        | La implementación de un patrón Three-tier divide la aplicación en capas de presentación, lógica de negocio y datos, mejorando la mantenibilidad y escalabilidad del sistema. Esta separación permite un desarrollo modular, facilita la identificación y resolución de problemas, y mejora la seguridad al restringir el acceso directo a la base de datos. Además, cada capa puede escalarse independientemente, optimizando el uso de recursos y mejorando el rendimiento general. Esto es particularmente beneficioso para una plataforma educativa donde la carga puede variar significativamente. |
| DEC-4 | Interfaz de plataforma en React y TailwindCSS          | React es conocido por su eficiencia en la gestión del DOM virtual y su estructura basada en componentes, lo que facilita la creación de interfaces de usuario dinámicas y responsivas. TailwindCSS permite un diseño UI rápido y personalizable, utilizando clases utilitarias que agilizan el desarrollo. Ambas tecnologías son populares y bien soportadas, lo que reduce la curva de aprendizaje y facilita el mantenimiento y la evolución de la plataforma. Estas características son cruciales para ofrecer una experiencia de usuario atractiva y eficiente en una plataforma educativa. |
| DEC-5 | MVC en backend                                         | El patrón MVC (Modelo-Vista-Controlador) permite una clara separación de responsabilidades, mejorando la organización y mantenibilidad del código. Este enfoque modular facilita la adición de nuevas funcionalidades, la modificación de las existentes y la resolución de problemas, al mismo tiempo que asegura una mayor consistencia y coherencia en el desarrollo de la aplicación. MVC también es ampliamente adoptado y compatible con muchas tecnologías backend, lo que proporciona flexibilidad y soporte. Esto es esencial para la robustez y escalabilidad de una plataforma educativa compleja. |

## Paso 5: Instanciar Elementos de Arquitectura, Asignar Responsabilidades y Definir Interfaces

| Elemento de Arquitectura                    | Descripción                                                                                       | Fundamentación                                                                                       |
|---------------------------------------------|---------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| Amazon EC2                                  | Implementación de un servicio web externo en la nube, principalmente por la facilidad de implementación de diversos servicios AWS. | Amazon EC2 permite ajustar los recursos según la demanda, asegurando alta disponibilidad y rendimiento. La infraestructura de AWS ofrece soporte y herramientas adicionales para la gestión y monitoreo del sistema, lo cual es crucial para garantizar la seguridad y la estabilidad de una plataforma educativa que requiere alta disponibilidad y capacidad de adaptación rápida a cambios en la carga de trabajo. |
| Patrón de despliegue three-tier             | Despliegue de la aplicación en tres capas: presentación, aplicación y datos.                      | La implementación de un patrón Three-tier divide la aplicación en capas de presentación, lógica de negocio y datos, mejorando la mantenibilidad y escalabilidad del sistema. Esta separación permite un desarrollo modular, facilita la identificación y resolución de problemas, y mejora la seguridad al restringir el acceso directo a la base de datos. Además, cada capa puede escalarse independientemente, optimizando el uso de recursos y mejorando el rendimiento general. Esto es particularmente beneficioso para una plataforma educativa donde la carga puede variar significativamente. |
| Patrón de arquitectura MVC                  | Implementación del patrón MVC para la arquitectura del backend de la aplicación web.              | El patrón MVC (Modelo-Vista-Controlador) permite una clara separación de responsabilidades, mejorando la organización y mantenibilidad del código. Este enfoque modular facilita la adición de nuevas funcionalidades, la modificación de las existentes y la resolución de problemas, al mismo tiempo que asegura una mayor consistencia y coherencia en el desarrollo de la aplicación. MVC también es ampliamente adoptado y compatible con muchas tecnologías backend, lo que proporciona flexibilidad y soporte. Esto es esencial para la robustez y escalabilidad de una plataforma educativa compleja. |

## Paso 6: Bosquejar Vistas y Registrar Decisiones de Diseño

![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/f846ce97-36a8-49e0-be2a-aa8225e7a963)

![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/ff78f2aa-ba72-4d40-a44b-cd1b9ebb1181)


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
