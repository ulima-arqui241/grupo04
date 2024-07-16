## Iteración 3: Refinar Componentes y Mejorar Disponibilidad

### Paso 2: Establecer Objetivo de la Iteración

En esta tercera iteración se busca refinar las iteraciones anteriores y continuar abarcando los escenarios de atributos de calidad restantes. En este caso, se elegirá refinar el atributo de Disponibilidad.

| Propósito                                                  | Funcionalidad Primaria | Escenarios de Calidad          | Restricciones y Preocupaciones       |
| ---------------------------------------------------------- | ---------------------- | ------------------------------ | ------------------------------------ |
| Enfoque en refinar los últimos componentes y las iteraciones anteriores. | UC-06                  | QA-03, QA-05, QA-10, QA-17     | CRN-02, CRN-03, CON-02, CON-04, CON-05, CON-06 |

### Paso 3: Elegir uno o más Elementos del Sistema a Refinar

Se da un mayor enfoque al refinamiento de la estructura de modelos en el elemento de despliegue:

- Servidores de almacenamiento de datos anteriormente especificados en la primera iteración.

## Paso 4: Elegir uno o más Conceptos de Diseño que Satisfacen el Driver Seleccionado

| ID    | Decisión de Diseño          | Fundamentación                                                                                                                                                                         |
|-------|-----------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| DEC-11| Escalabilidad horizontal    | RDS permite aumentar o disminuir la cantidad de instancias del backend en función de la demanda. En una plataforma educativa, esto es crucial para manejar fluctuaciones en el tráfico de usuarios, especialmente durante picos como exámenes y períodos de inscripción. La capacidad de escalar horizontalmente asegura que el sistema pueda mantener un rendimiento óptimo sin interrupciones. |
| DEC-12| Replicación                 | RDS ofrece replicación multi-AZ, que implica mantener una copia sincrónica de la base de datos en una zona de disponibilidad secundaria. Esto asegura alta disponibilidad y durabilidad de los datos, protegiendo contra fallos en la zona de disponibilidad principal. En una plataforma educativa, donde la integridad y disponibilidad de los datos son esenciales, esta característica proporciona una capa adicional de seguridad y confiabilidad. |
| DEC-13| Monitoreo y alertas         | Utilizar Amazon CloudWatch para monitorear métricas clave y establecer alarmas es importante para asegurar la disponibilidad. En una plataforma educativa, es vital detectar y responder rápidamente a problemas como aumentos inusuales en el tráfico, fallos en el sistema o problemas de rendimiento. CloudWatch proporciona las herramientas necesarias para monitorear el sistema en tiempo real y tomar medidas proactivas para mantener la estabilidad y disponibilidad del servicio. |

## Paso 5: Instanciar Elementos de Arquitectura, Asignar Responsabilidades y Definir Interfaces

| Elemento de Arquitectura               | Descripción                                                                                                                | Fundamentación                                                                                                                                                       |
|----------------------------------------|----------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Servicio de bases de datos relacional RDS | Implementado principalmente por sus capacidades de escalabilidad y replicación.                                              | RDS permite escalar instancias según la demanda y ofrece replicación multi-AZ para alta disponibilidad y durabilidad de datos, características esenciales para una plataforma educativa confiable y robusta. |
| Amazon CloudWatch                      | Servicio AWS de monitorización y administración conectado a la instancia de Amazon EC2.                                        | CloudWatch permite monitorear métricas clave y establecer alertas, lo cual es crucial para detectar y resolver problemas rápidamente, asegurando la disponibilidad y rendimiento del sistema educativo.       |
| Amazon Simple Email Service (SES)      | Para el envío de notificaciones por correo electrónico a usuarios de la plataforma.                                           | SES es un servicio escalable y fiable para enviar correos electrónicos, ideal para mantener a los usuarios informados sobre actualizaciones, recordatorios y notificaciones importantes de la plataforma.    |

### Paso 6: Bosquejar Vistas y Registrar Decisiones de Diseño

![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/0f53faae-420d-49fa-911b-bebaf3053233)

![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/aed1e3f1-01a1-45c3-a59c-bcff7bdf3e3f)

### Paso 7: Analizar el Diseño Actual, Revisar Objetivo de la Iteración y Logro del Propósito de Diseño

| No Abordado | Parcialmente Abordado | Completamente Abordado | Decisión de Diseño        |
| ----------- | --------------------- | ---------------------- | ------------------------- |
|             |                       | UC-06                  | DEC-11, DEC-12, DEC-13    |
|             | QA-03, QA-05          |                        | DEC-11, DEC-12            |
|             | QA-10, QA-17          |                        | DEC-13                    |
|             | CRN-02                |                        | Todos                     |
|             | CRN-03                |                        | Todos                     |
|             | CON-02, CON-04        |                        | DEC-12                    |
|             | CON-05                |                        | DEC-12                    |
|             | CON-06                |                        | DEC-13                    |
