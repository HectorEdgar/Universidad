<!DOCTYPE html>
<html>
    <head>
        AQUI FALTA CODIGO, PERO YA LO SABEN
    </head>
    <body>

        <div class="container">
        <br/><br/>
        <p>
        AGREGA AQUI LOS DOS LINK CON LAS IMAGENES
        </p>
        <div id="list-refacciones" role="main">
            <h1><g:message code="default.list.label" args="[entityName]" /></h1>
            <g:if test="${flash.message}">
                <div class="message" role="status">${flash.message}</div>
            </g:if>
            <f:table collection="${refaccionesList}" SI SABES QUE FALTA AGREGALO />
            <div class="pagination">
                <g:paginate total="${refaccionesCount ?: 0}" />
            </div>
            
            <div id="divImp">
            <h4>Todas las refacciones</h4>
            <table style="border: 1px solid #a59f9f;" class="table table-hover">
                
				CREA TODO EL CONTENIDO DE LA TABLA DINAMICAMENTE
				USANDO EL EL TAG QUE TIENE GRAILS PARECIDO AL FOR
				
            </table>
            <p>
            <h4>Precio entre $1 y $20:</h4><h6> !! AQUI LOS RESULTADOS !! </h6>
            </p>
            <h4>Precio mayor a $500</h4>
            <table style="border: 1px solid #a59f9f;" class="table table-hover">
                
				CREA TODO EL CONTENIDO DE LA TABLA DINAMICAMENTE
				USANDO EL EL TAG QUE TIENE GRAILS PARECIDO AL FOR
				
            </table>
            </div>
            
        </div>
        </div>
    </body>
</html>