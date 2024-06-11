
# Patrón Circuit Breaker

## Introducción
El patrón Circuit Breaker es una técnica de diseño utilizada en el desarrollo de software para mejorar la resiliencia y estabilidad de las aplicaciones, especialmente en sistemas distribuidos. Este patrón permite manejar errores y fallos intermitentes en servicios o recursos remotos, controlando el flujo de llamadas y evitando que los sistemas se vean abrumados por intentos fallidos repetidos.

## ¿Qué es el Patrón Circuit Breaker?
El patrón Circuit Breaker se basa en la analogía de un disyuntor eléctrico. Cuando un servicio externo o recurso empieza a fallar repetidamente, el "circuito" se abre, previniendo que se realicen más llamadas fallidas hasta que el servicio se recupere. Esto ayuda a evitar que las aplicaciones gasten recursos valiosos en operaciones que están destinadas a fallar y a proteger el sistema de sobrecargas.

### Estados del Circuit Breaker
El patrón Circuit Breaker opera en tres estados principales:
- **Cerrado**: Las llamadas al servicio se realizan normalmente. Si un número configurable de llamadas falla, el circuito se abre.
- **Abierto**: Las llamadas al servicio fallan inmediatamente sin intentar la operación. Después de un período de tiempo, el circuito pasa al estado de medio abierto.
- **Medio Abierto**: Se permite un número limitado de llamadas para probar si el servicio se ha recuperado. Si estas llamadas tienen éxito, el circuito se cierra; si fallan, el circuito vuelve a abrirse.

### Implementación Básica
La implementación básica del patrón Circuit Breaker implica monitorear las llamadas a un servicio y contar los fallos. Si el número de fallos excede un umbral, el circuito se abre. Después de un tiempo de espera, el circuito pasa a medio abierto para probar la recuperación del servicio.

## Ventajas del Patrón Circuit Breaker

### 1. Mejora la Resiliencia
El patrón Circuit Breaker mejora la resiliencia de la aplicación al prevenir que continúe realizando operaciones fallidas. Esto es crucial en sistemas distribuidos donde los fallos en servicios remotos pueden tener un impacto significativo en la estabilidad del sistema.

### 2. Protección del Sistema
Al abrir el circuito y evitar llamadas fallidas, el patrón Circuit Breaker protege los sistemas de sobrecargas y evita que los recursos sean desperdiciados en operaciones que no tienen éxito.

### 3. Mejora del Rendimiento
El patrón Circuit Breaker puede mejorar el rendimiento general de una aplicación al reducir la cantidad de tiempo y recursos dedicados a llamadas fallidas. Esto permite que los recursos se utilicen de manera más eficiente.

### 4. Facilitación de la Recuperación
Al permitir que el sistema pruebe de manera controlada si un servicio se ha recuperado (estado medio abierto), el patrón Circuit Breaker facilita la recuperación de servicios fallidos de manera gradual y controlada.

### 5. Simplificación de la Gestión de Errores
El patrón Circuit Breaker simplifica la gestión de errores en aplicaciones distribuidas, proporcionando un mecanismo claro para manejar fallos y recuperar servicios.

## Estrategias de Implementación

### Circuit Breaker Simple
Una implementación simple del patrón Circuit Breaker implica monitorear las llamadas a un servicio y abrir el circuito después de un número definido de fallos consecutivos. Esta es una estrategia efectiva para muchos escenarios comunes.

### Circuit Breaker con Retardos y Exponenciación
Una estrategia más avanzada incluye la aplicación de retardos exponenciales y el uso de ventanas de tiempo para contar fallos y éxitos. Esta estrategia puede ser más adecuada para sistemas complejos y de gran escala.

### Circuit Breaker con Monitoreo y Alertas
Integrar el patrón Circuit Breaker con herramientas de monitoreo y alertas puede proporcionar una visión en tiempo real del estado de los servicios y permitir respuestas rápidas a fallos.

## Casos de Uso Comunes
El patrón Circuit Breaker es ampliamente utilizado en sistemas distribuidos y microservicios donde los servicios dependen de otros servicios externos o remotos. Algunos ejemplos incluyen:

### Servicios Web y APIs
En aplicaciones que consumen servicios web o APIs de terceros, el patrón Circuit Breaker puede prevenir que un fallo en el servicio externo afecte negativamente a la aplicación.

### Microservicios
En arquitecturas de microservicios, el patrón Circuit Breaker ayuda a aislar fallos y prevenir la propagación de errores a través de múltiples servicios interdependientes.

### Sistemas de Pago y Autenticación
El patrón Circuit Breaker es útil en sistemas críticos como pagos y autenticación, donde la disponibilidad y la fiabilidad son cruciales y los fallos deben manejarse de manera eficaz.

## Ejemplo de Implementación en Python

### Código de Implementación

https://github.com/MXLEOMX/PatronesCloud
### video de implementación


### Cómo Ejecutarlo
Para ejecutar el código de implementación del patrón Circuit Breaker en Python, sigue estos pasos:

1. Asegúrate de tener Python instalado en tu sistema.
2. Crea un archivo llamado `circuit_breaker_example.py` y copia el código de implementación en él.
3. Abre una terminal y navega hasta el directorio donde guardaste `circuit_breaker_example.py`.
4. Ejecuta el siguiente comando:
   ```
   python circuit_breaker_example.py
   ```
5. Observa los resultados en la terminal. Verás cómo el circuito se abre después de un número definido de fallos consecutivos y cómo intenta recuperarse después de un tiempo de espera.

## Conclusiones
El patrón Circuit Breaker es una herramienta esencial para mejorar la resiliencia y la fiabilidad de las aplicaciones distribuidas. Sin embargo, debe ser implementado y configurado cuidadosamente para balancear la protección del sistema con la disponibilidad de los servicios. Combinado con otros patrones de diseño, como Retry y Bulkhead, el patrón Circuit Breaker puede formar parte de una estrategia integral de resiliencia y manejo de errores en aplicaciones modernas.

## Referencias

- [Design Patterns: Elements of Reusable Object-Oriented Software](https://en.wikipedia.org/wiki/Design_Patterns)
- [Microsoft Azure Architecture Patterns](https://docs.microsoft.com/en-us/azure/architecture/patterns/)
- [Circuit Breaker Pattern - Martin Fowler](https://martinfowler.com/bliki/CircuitBreaker.html)

---
