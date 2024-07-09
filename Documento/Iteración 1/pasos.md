## Iteración 1: Establecer Estructura General del Sistema

## Paso 2: Establecer Objetivo de la Iteración

En base a las entradas especificadas, el objetivo de esta primera iteración es realizar un diseño inicial de la estructura de la plataforma, abarcando los atributos más importantes de disponibilidad, rendimiento y seguridad.

| Propósito                                         | Funcionalidad Primaria      | Escenarios de Calidad    | Restricciones y Preocupaciones       |
| ------------------------------------------------- | --------------------------- | ------------------------ | ------------------------------------- |
| Plataforma desde 0. Se busca producir un diseño detallado. | UC-01, UC-02, UC-03, UC-06 | QA-01, QA-03, QA-05     | CRN-01, CRN-02, CON-01, CON-02, CON-05 |

## Paso 3: Elegir uno o más Elementos del Sistema a Refinar

No hay elementos a refinar, pues se está diseñando el sistema desde 0.

## Paso 4: Elegir uno o más Conceptos de Diseño que Satisfacen el Driver Seleccionado

| ID   | Decisión de Diseño                                     | Fundamentación                                                                                       |
| ---- | ------------------------------------------------------ | ---------------------------------------------------------------------------------------------------- |
| DEC-1 | App front y back serán deployeados en un EC2           | Se escoge Amazon EC2 para aprovechar la facilidad de escalamiento horizontal y vertical, al igual que la facilidad de implementación en diferentes instancias. |
| DEC-2 | Base de datos relacional en RDS y uso de DynamoDB      | Se creará una instancia de la BD relacional en RDS y DynamoDB para aprovechar sus ventajas de escalabilidad y rendimiento. |
| DEC-3 | Patrón de despliegue three-tier                        | Implementación de un patrón Three-tier por sus ventajas en mantenibilidad y escalabilidad al dividir el desarrollo entre capas. |
| DEC-4 | Interfaz de plataforma en React y TailwindCSS          | Se usa esta tecnología por ser conocida por los desarrolladores y facilitar el diseño UI. Angular se selecciona por su estructura de componentes. |
| DEC-5 | MVC en backend                                         | Se usa MVC para tener un mejor manejo de código y por ende mayor modificabilidad.                                                      |

## Paso 5: Instanciar Elementos de Arquitectura, Asignar Responsabilidades y Definir Interfaces

- **Amazon EC2**: Implementación de un servicio web externo en la nube, principalmente por la facilidad de implementación de diversos servicios AWS.
- **Patrón de despliegue three-tier**: Despliegue de la aplicación en tres capas: presentación, aplicación y datos.
- **Patrón de arquitectura MVC**: Implementación del patrón MVC para la arquitectura del backend de la aplicación web.

## Paso 6: Bosquejar Vistas y Registrar Decisiones de Diseño

![Diagrama de Contenedores](https://i.imgur.com/1aPfjJ4.png)
![Diagrama de Componentes](https://i.imgur.com/bYJeDZg.png)

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
