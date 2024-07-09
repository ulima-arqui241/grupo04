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

| ID    | Decisión de Diseño                        | Fundamentación                                                                                     |
| ----- | ----------------------------------------- | -------------------------------------------------------------------------------------------------- |
| DEC-7 | Descomponer en módulos                    | Esta decisión brinda una oportunidad para la implementación de prácticas de modularidad y reusabilidad. |
| DEC-8 | Uso de caching                            | Implementado con el objetivo principal de agilizar las consultas más usadas en el sistema.             |
| DEC-9 | S3 para el almacenamiento de archivos     | Se almacenarán en un S3 los archivos y grabaciones que los usuarios deseen subir. La alta escalabilidad y seguridad del servicio son fundamentales. |
| DEC-10 | Uso de solución de videollamadas Agora.io | Por su escalabilidad, servidores distribuidos y fácil integración, asegurando alto rendimiento y seguridad. |

### Paso 5: Instanciar Elementos de Arquitectura, Asignar Responsabilidades y Definir Interfaces

- **Amazon S3**: Servicio de almacenamiento en la nube ofrecido por AWS. Implementado para el almacenamiento de archivos de usuarios.
- **Agora.io**: Servicio de videollamadas que permite a la aplicación web crear aplicaciones de chat y transmisión en tiempo real.

### Paso 6: Bosquejar Vistas y Registrar Decisiones de Diseño

![image](https://github.com/ulima-arqui241/grupo04/assets/122492617/4271d8ff-ff40-4199-88d6-d64d91414e36)


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
