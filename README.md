# TechnicalAPI

Se tuvieron en cuenta las siguientes consideraciones:

## API de autenticacion

- Un usuario solo posee _username_ y _password_ con los que se autentica
- Se retorna el _username_. Mejora: Retornar un JWT (sin implementar)
- Hay validaciones mínimas del request enviado a la API.
- Generación de usuarios mediante seed para testing

*Se aplicaron las siguientes herramientas:*
- Store Procedure para obtener un usuario según _username_ y _password_
- Se injecta un IUserService en el controlador que resuelve la petición
- Seeds de usuarios
- Migraciones para hacer el seed de usuarios, modificar la tabla, agregar/eliminar campos
- Swagger para documentación
- Serilog para trace (tanto en base de datos como aplicación)

## Consumo de API de gobierno

- Se retorna solo los datos de _lat_ y _long_ por lo que se mapea a la entidad correspondiente
- Dentro de la configuración del archivo _appsettings.json_ se encuentra la url y el nombre del método a consumir de la API

*Se aplicaron las siguientes herramientas:*
- HttpClient para comunicación con la API
- Se injecta un IHttpClient en el controlador que resuelve la petición

### Arquitectura general

La solución se basa en dos proyectos: una libería que se proporciona como una capa de dominio con Entites, DT0s, Filters, etc; y un proyecto WebAPI que expone dos métodos: 

1. GET --> State, info: retorna a partir del nombre de una provincia su lat y long.
2. POST --> User, authenticate: retorna el _username_ del usuario logueado en caso de que las credenciales ingresadas sean las correctas.

*Nivel de arquitectura/solución propuesta*

1. API -> User y State _controllers_
   - Servicio -> UserCustomer y State services
     - Repositorio -> UserRepository
       - SP -> GetUserByFilter
       - HttpClient -> GetStateByName

En ambos casos se utilizo un Patrón de repositorio con operaciones sencillas para el acceso a los datos. Además de DTOs, Validators, Filter y clases separadas para manejar _request_ y _response_

* Para mayor claridad de las tareas y su track correspondiente se utilizo un board en Trello. https://trello.com/b/16IuESv9/flockit-board
* Utilización de Git Flow con los branchs: _master_, _dev_, _features_, _us-xx_ (donde xx se corresponde con una US generada en Trello)

#### Limitaciones/bloqueantes

Se planteo el poder utilizar REFIT (https://github.com/reactiveui/refit) para el consumo de la API de gobierno, sin embargo al realizar el llamado a la interfaz asíncrona, el método del controlador no podía contener un await resultando en un dead lock, por lo que esto demoro la implementación de este punto sin poder encontrar una solución al problema. Se opto por utilizar entonces HttpClient.

## Unit testing - sin implementación al día 14/05
