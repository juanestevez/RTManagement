# RT Management CHANGELOG

### 1.6.0.1 - 2019.03-05
##### Fixed
- **[Usuarios Portal]**
 - Se eliminan etiquetas de debug.
 - Se corrige error que cerraba la aplicación al consultar los usuarios cuando no hay resultados.
 - Las columnas de resultado se muestran correctamente (mismo tamaño) al realizar una búsqueda por nombre.

### 1.6 - 2019-03-05
#### Changed
- Nuevos íconos para la aplicación.
- Al ingresar al sistema ya no se abre el modulo de deducibles de forma automática.

##### Fixed
- **[Ventana principal]** Al entrar como invitado se ocultan correctamente los menús, únicamente se muestra el módulo de deducibles y la opción de cambiar contraseña.

##### Added
- Se agrega módulo para gestión de usuarios para el portal.

### 1.5.8.1 - 2019-01-17
##### Changed
- Se agrega el año 2019 para la búsqueda y al agregar un expediente como Good Will.

### 1.5.8 - 2018-12-03
##### Changed
- Se eliminan dos campos de la base de datos (tabla deducibles), se aplican correcciones para que la aplicación siga funcionando.
- Se optimiza la función para obtener la consulta al cambiar el estado de un expediente.
- Al guardar un nuevo expediente, el teléfono celular ya no es un campo obligatorio.
- Mejoras menores de legibilidad en el código.

##### Added
- El sistema ahora permite cambiar un expediente "Archivado" a "Para envío".

### 1.5.7 - 2018-09-26
##### Added
- Se agrega, en el módulo de deducibles, opción para marcar los expedientes para seguimiento.

### 1.5.6 - 2018-03-21
##### Added
- Se añade botón para ver los expedientes por vencer (siniestro mayor a un año).

##### Fixed
- Se muestra el botón para cancelar 'Good Will' en los expedientes procedentes.

### 1.5.5 - 2018-02-08
##### Fixed
- Se corrige problema que no permitía cambiar el estado de un expediente de 'en proceso' a 'procedente' o 'no procedente'.

##### Changed
- Se permite el cambio de estado de un expediente de 'incompleto' a 'procedente' o 'no procedente'.

### 1.5.4 - 2018-02-06
##### Changed
- Se elimina el campo 'acuse' de los formuilarios deducibles y la ventana 'agregar registro'.
- Ya es posible cambiar el estatus a 'procedente' o 'no procedente' de un expediente archivado.

##### Added
- Se agrega botón para limpar los campos de la ventana 'agregar registro'.
- Se agrega confirmación para marcar o desmarcar un expediente como candidato a Good Will.
- Se agrega año 2018 a la búsqueda de Good Will.

### 1.5.3 - 2018-01-09
##### Fixed
- Se eliminan mensajes de debug que quedaron de la versión de desarrollo.

### 1.5.2 - 2018-01-09
##### Fixed
- Se corrige el desbloqueo de usuarios, ahora se puede desbloquear cualquier usuario y no sólo el administrador.

### 1.5.1.10 - 2018-01-09
##### Fixed
- **[Deducibles]** Se corrige comportamiento al calcular las fechas en los campos Good Will, si el mes actual es enero se muestra correctamente el año anterior y el mes de diciembre. Con esto se elimina el mensaje de error al cargar el expediente.
- **[Login]** Se corrige el comportamiento del desbloqueo de usuarios, ya se desbloquea el usuario deseado y no el administrador.

### 1.5.1.9 - 2017-10-24
##### Changed
- **[Deducibles]** Ajuste en la barra de resultados, todos los elementos quedan visibles. 

### 1.5.1.8  2017-04-30
##### Changed
- **[Deducibles]** Se permite cambiar el estado de un expediente de "Para envío" a "Incompleto.
- **[Deducibles]** Cambio menor en Layout, los resultados ocupan   menos espacio en pantallas pequeñas.

### 1.5.1.7  2017-03-06
##### Added
- **[Deducibles]** Se agrega validación al añadir expediente si el VIN ya existe en la base de datos no se agregará nuevamente.

##### Changed
- **[Deducibles]** Se cambia el orden de las columnas en los expedientes incompletos para mostrar la aseguradora.

### 1.5.1.6  2017-02-28
##### Added
- **[Deducibles]** Se agrega año 2017 a las opciones de Good Will.

### 1.5.1.5  2016-12-27
##### Changed
- **[Deducibles]** Cambio en layout de documentos encontrados para una mejor visualización de requisitos y opcionales.
- **[Deducibles]** Al hacer doble click en el campo de email se seleccionará todo el contenido sin importar la longitud. 

### 1.5.1.4  2016-11-25
##### Added
- **[Deducibles]** Se permite marcar un expediente en proceso con la bandera "Monto pendiente".
##### Changed
- **[Deducibles]** Se cambian las siglas de expediente GNP al agregar un expediente. G -> GNP.

### 1.5.1.3  2016-11-22
##### Fixed
- Arreglada opción para hacer copia de seguridad de la base de datos. Además, ahora es posible elegir el directorio y nombre de archivo a guardar.
##### Changed
- **[Deducibles]** Cambio de orden de columnas para resultados de búsqueda de expedientes con Good Will, de esta forma se muestra la aseguradora antes que las fechas.

### 1.5.1.2  2016-11-13
##### Changed
- Cambio de cadena de conexión a archivo app.config.

##### 1.5.1.1  2016-11-08
##### Fixed
- **[Deducibles]** Se corrige vista de números decimales en los campos valor factura, monto de deducible y suma asegurada. Ahora se muestran correctamente.
##### Changed
- **[Deducibles]** Se agrega una bandera para marcar los montos pendientes por enviar. Sólo aparecerá para expedientes con estado procedente o improcedente con good will.
- **[Deducibles]** El botón "Montos pendientes" ahora muestra únicamente los montos pendientes por enviar.
##### Added
- **[Deducibles]** En los expedientes entregados ya es posible ver los días hábiles transcurridos desde la entrega.
- **[Deducibles]** Se habilita el cambio de estado de un expediente entregado a incompleto.

### 1.5.1  2016-10-20
##### Added
- Se agrega módulo para desbloquear usuarios (sólo los administradores tienen permisos).
- **[Deducibles]** En la vista de expediente se agrega linklabel para enviar correo electrónico al cliente.
##### Changed
- **[Deducibles]** Se actualizan los prefijos de los expedientes NSC al seleccionar una aseguradora, además si el campo ya tiene texto éste no cambiará.
- **[Deducibles]** Al realizar consultas por tipo de expediente o estado, los campos del datagrid (fechas) cambiarán según sea necesario.

### 1.5.0.10  2016-08-29
##### Fixed
- **[Deducibles]** Corregido error en filtro de expedientes al buscar por fecha de visita.

### 1.5.0.9  2016-08-09
##### Changed
- **[Deducibles]** Se regresa al layout original pero aregando mejoras para vista en pantallas reducidas.
- Al agregar una llamada entrante ya no es necesario capturar un número de teléfono, si el espacio está en blanco se agregará un cero en la base de datos.

### 1.5.0.8  2016-07-21
##### Changed
- **[Deducibles]** Cambios en el layout del módulo para una mejor vista en pantallas reducidas.

### 1.5.0.7  2016-06-13
##### Fixed
- [Deducibles] Corregido el error que no permitía cambiar el estado de un expediente.

###1.5.0.6  2016-06-06
##### Changed
- **[Deducibles]** Se activa la marca de candidato a Good Will para todos los estados de expedientes excepto procedentes.
##### Fixed
- **[Deducibles]** Se arregla error con la fecha de dictamen al agregar un expediente con el estado 'en proceso'.
- **[Deducibles]** Al marcar un expediente como procedente, si este esta marcado como candidato a Good Will, la marca se quitará.

### 1.5.0.5 2016-05-20
##### Fixed
- Correción de errores generados con la actualización del motor de base de datos.

### 1.5.0.4 2016-04-07
##### Fixed
- **[Deducibles]** Los expedientes archivados que no tienen fecha de recepción se muestran correctamente
- **[Deducibles]** Corregido error al buscar por fecha (al dejar la aplicación abierta de un día a otro), ya es posible realizar la busqueda por fecha.
- **[Correccion gpo. int.]** Al cambiar de pestaña, los datos se ocultan correctamente.

### 1.5.0.3  2016-01-27
##### Fixed
- **[Correccion gpo. int.]** Corregido error que no permitía ver los datos en búsqueda por fecha.

### 1.5.0.2  2016-01-26
##### Changed
- **[Correccion gpo. int.]** Se quitan restricciones del campo grupo incorrecto.
##### Added
- **[Correccion gpo. int.]** Se agregan permisos para invitado.

### 1.5.0.1  2016-01-26
##### Fixed
- **[Correccion gpo. int.]** Corregido el error al guardar modificaciones cuando el registro   está en proceso.
- **[Correccion gpo. int.]** Corregido el orden de los campos (tabindex).

###1.5 2016-01-26
##### Added
- Se agrega módulo para control de correcciones de grupo e integrante.
- **[Deducibles]** Añadida opción para marcar un expediente como candidato a pago por Good Will, únicamente se mostrará esta opción si el expediente tiene el estado 'no procedente' y no tiene autorizado el pago por Good Will anteriormente.
- **[Deducibles]**Se agrega GNP como compañía aseguradora.
##### Changed
- **[Deducibles]**Al hacer el cálculo del monto por deducible, si el porcentaje es mayor a 20, se muestra el valor del monto y el monto a pagar.
- **[Deducibles]**Optimización del cálculo del monto de deducible. Se actualiza el valor del campo "monto" en todos los casos.
##### Fixed
- **[Deducibles]**Al desmarcar un expediente con Good Will los cambios se graban correctamente.

### 1.4.0.4  2016-01-20
##### Fixed
- **[Deducibles]** Corregida la visualización en la fecha de robo cuando el expediente tiene el estado 'incompleto'.

### 1.4.0.3 2016-01-12
##### Changed
- La ventana "Agregar llamada ya no se muestra en la barra de tareas.
- Cambio en la fecha de good will, ahora sólo aparece el mes y el año en que se autorizó el good will; lo mismo aplica para la búsqueda.
- Al realizar respaldo de la base de datos de instalaciones se realiza en una carpeta adicional.

### 1.4.0.2 2015-12-29
##### Fixed
- Se corrige error al respaldar base de datos, el resultado final ya toma en cuenta todas las tablas.
- **[Deducibles]** Corregido error en cálculo de los días en proceso para un expediente.

### 1.4.0.1 2015-12-28
##### Added
- Se agrega bloqueo de usuarios al iniciar sesión, de esta forma no se puede usar el programa con el mismo usuario a la vez.
- Se agrega la opción de respaldar la base de datos. Se muestra en el menú de administrador.

### 1.4.0.0 2015-12-28
- Cambio de motor de base de datos a MySQL.

### 1.3.14.3
##### Added
- Mejoras en el sistema de permisos. Ahora se cuenta con tre niveles de usuario:
  - Administrador
  - Usuario
  - Invitado

### 1.3.14.2
##### Fixed
- Corregido error de visualización en números de teléfono registrados.

### 1.3.14.1
##### Fixed
- Corrección de errorres en los expedientes "Archivados".
- Mejoras de usabilidad al capturar números de teléfono.
- La máscara del campo de texto se actualiza correctamente dependiendo de la longitud del número.
##### Changed
- Si la longitud del teléfono es menor a 8 digitos, el campo se muestra en blanco.

### 1.3.14.0
##### Fixed
- Se corrige el problema del ingreso de números   de teléfono, ya es posible ingresar número de 10 digitos.
##### Added
- Se agrega el estado "Archivado" para los expedientes.

### 1.3.13.0 (19/08/15)
##### Added
- Es posible navegar por los registros de expedientes usando las flechas del teclado.
- Añadidas teclas de acceso rápido al campo de búsqueda de expedientes.

### 1.3.3.12 (19/08/15)
##### Fixed
- Corrección de errores en la visualización de expedientes.

##### 1.3.3.11 (19/08/15)
##### Changed
- Se unifica la vista de expedientes en una única ventana.
##### Added
- Se añade campos para marcar un expediente como pago por Good Will.

##### 1.3.3.10 (08/04/15)
VERSION CON MEJORAS DE USABILIDAD
##### Added
- Se muestra el estado del expediente al realizar busquedas.
- Se muestran el número de resultados devueltos en las busquedas de expedientes.
- Nuevo campo en el registro de llamdas para ingresar el estado de la llamada realizada.

### 1.3.3.9 (27/07/15)
##### Fixed
- El campo 'Suma Asegurada' al agregar expedientes, ahora se reinicia correctamente.
##### Changed
- El módulo deducibles ahora se muestra al ingresar a la aplicación.

### 1.3.3.8 (15/07/15)
##### Changed
- Modo 'Sólo lectura' para la cuenta de invitado dentro del módulo DEDUCIBLES.

### 1.3.3.7 (15/07/15)
##### Fixed
- Mejoras de usabilidad en la búsqueda de expedentes.
- Corregido error al mostrar el monto a pagar cuando el campo monto está en blanco.
- Corregido el límite de captura de suma asegurada, al momento de agregar un expediente.

### 1.3.3.6 (07/07/15)
##### Fixed
- Corrección de cálculo por monto de deducible.

### 1.3.3.5 (29/06/15)
##### Fixed
- Corrección de guardado de fechas al cambiar de estado un expediente.

### 1.3.3.4 (24/06/15)
##### Fixed
- Corrección de errores en el filtrado de expedientes por fecha, ahora se muestran correctamente los registros del mismo día.

### 1.3.3.3 (23/06/15)
##### Fixed
- Corrección de error al mostrar la fecha de entrega a C3.
##### Changed
- Mejoras en la búsqueda de expediente, ahora se pueden filtrar por fecha de dictamen.
- Se cambia el sistema de comentarios para los expedientes, ya no es necesario editar el registro.

### 1.3.3.2 (22/06/15)
##### Changed
- Mejoras de rendimiento.
- Cambio interno del formato de fecha.

### 1.3.3.1 (15/06/15)
##### Added
- Se agregan campos para registrar la documentación recibida.
##### Fixed
- Corrección de errores menores.

### 1.3.3.0 (10/06/15)
##### Fixed
- Arreglado el bug que no permitía ver los días transcurridos en un expediente no procedente.
##### Added
- Se agrega módulo de pendientes, es mostrado al inicio de la aplicación.
- Se agrega registro de llamadas para los expedientes, así como la opción de mostrar el historial de ellas.
- Cálculo del monto a pagar por deducible.

### 1.2.3.11 (19/05/15)
##### Added
- Nuevo estado para expedientes: "Para envío".
##### Changed
- Se eliminan prefijos para aseguradoras.
- Mejoras en usabilidad para el modulo deducibles.

### 1.2.3.10 (27/04/15)
##### Added
- Módulo deducibles. Se agrega campo para fecha de entrega a C3, la fecha probable y los días en procesos ahora se calcularán desde ese campo.
- Mejoras de usabilidad.

### 1.2.3.9 (09/04/15)
- Mejoras de usabilidad.

### 1.2.3.8 (10/03/15)
- Añadido campo CUENTA en módulo instalaciones.
- Corrección de errores.

### 1.2.3.7 (10/03/15)
##### Added
- Se añaden casillas de verificación para acuses y finiquitos.
- Corrección de errores.

### 1.2.3.6 (26/02/15)
##### Added
- Mejoras de usabilidad.
- Se agregan campos en la vista individual de instalaciones: Fallo, Solución.

### 1.2.3.5 (25/02/15)
##### Added
- Se agrega la posibilidad de editar los registros en el módulo instalaciones.

### 1.2.3.4 (23/02/15)
##### Fixed
- Corrección de errores menores.

### 1.2.3.3 (20/02/15)
##### Changed
- Cambio de librerías gráficas en el módulo de estadísticas.

### 1.2.3.2 (19/02/15)
##### Fixed
- Corrección de errores.

### 1.2.3.1 (19/02/15)
##### Fixed
- Corrección de errores.

### 1.2.3.0 (19/02/15)
##### Added
- Agregado el módulo de estadísticas.

### 1.1.3.5 (04/02/15)
##### Changed
- Mejoras visuales  en el formato de teléfonos.
##### Added
- Se agrega campo para registrar número de expediente NSC.

### 1.1.3.4 (03/02/15)
##### Fixed
- Corrección de errores.

### 1.1.3.3 (16/01/15)
- Mejoras en el tiempo de respuesta.

### 1.1.3.2
#### Fixed
- Corrección de errores en el guardado de expedientes.
- Mejoras de usabilidad en la pantalla de login.

### 1.1.3.1
- Mejoras de usabilidad en la búsqueda de expedientes.

### 1.1.3.0
- Corrección de errrores.
- Mejora de uso en la consulta de instalaciones.

### 1.0
##### Added
- Añadido el módulo de consulta de instalaciones.
- Corrección de errores.

### 0.8.1
##### Fixed
- Corrección de errorres y mejoras en rendimiento.

### 0.8
##### Added
- Se añade modulo de vista de modificaciones a expedientes. Sólo con permisos de administrador.

### 0.6
##### Added
- Modulo de administración (vista completa) de expedientes. Sólo con permisos de administrador.

### 0.4.2
##### Fixed
- Corrección de errores en la edición de expedientes.

### 0.4.1
##### Fixed
- Corrección de errores en las fechas al dar de alta un expediente.
##### Changed
- Cambio de formato interno de fecha.

### 0.4
##### Added
- Módulo de administración de usuarios.

### 0.2
##### Added
- Completadas las funcionalidades del modulo deducibles.

### 0.1.8.2
##### Added
- Se agrega función para mostrar días en proceso para expedientes.

### 0.1.8.1
##### Added
- Se agrega función para mostrar fecha probable de respuesta.

### 0.1.8
##### Added
- Agregada opción para cambiar el estado de los expedientes.

### 0.1.7
##### Fixed
- Corrección de errores en el módulo deducibles.
##### Added
- Se agrega vista individual para cada registro.

### 0.1.6.1
##### Fixed
- Corrección de errores menores en el módulo "deducibles"

### 0.1.6
##### Added
- Módulo "deducibles" con funcionalidad básica de búsqueda.

### 0.1.5
##### Added
- Módulo para cambiar contraseña.