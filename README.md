# PlataformasMoviles
 Tutorial de feature de Juego de aporte a la Materia 
 
 ![image](https://github.com/Ji07y/PlataformasMoviles/assets/85076732/99f21f61-6f9a-4c48-b302-2346f3eb15ed)

La premisa es simple pero adictiva: mueve a tu personaje de plataforma en plataforma, presionando el botón en el momento justo para avanzar y superar obstáculos. 
Este es un simple script en C# para Unity que implementa la funcionalidad de una plataforma móvil. La plataforma se mueve de ida y vuelta entre dos puntos definidos.

# Características
Velocidad Ajustable: La velocidad de movimiento de la plataforma puede ser modificada en el editor de Unity.

Movimiento Cíclico: La plataforma se desplaza hacia adelante y hacia atrás entre dos puntos definidos, creando un movimiento cíclico.

# Uso
Asignación de Objetos:

Asegúrate de que la plataforma tenga un Transform llamado puntoFinal que marca el punto hacia el cual se mueve la plataforma.
Coloca el script en el objeto que representa la plataforma en tu escena de Unity.
Configuración de Velocidad:

Puedes ajustar la velocidad de la plataforma directamente desde el editor de Unity al modificar el valor de velocidadMovimiento.
Puntos de Inicio y Fin:

El punto de inicio de la plataforma se establece automáticamente al iniciar el juego, basándose en su posición inicial.
La plataforma se moverá hacia adelante hasta alcanzar puntoFinal y luego volverá hacia atrás hasta alcanzar su posición inicial.
Uso Adicional:

Puedes integrar este script con otros elementos del juego, como controles de jugador o sistemas de eventos, para crear mecánicas más complejas.

# Ejemplo de Implementación
![image](https://github.com/Ji07y/PlataformasMoviles/assets/85076732/edd386f9-c26e-4c40-80c5-c888bda54568)

