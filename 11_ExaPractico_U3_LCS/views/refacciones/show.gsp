<!DOCTYPE html>
<html>
    <head>
        AQUI FALTA CODIGO, PERO YA LO SABEN
    </head>
    <body>
        <div class="container">
            <br/><br/>
            <h1><g:message code="default.show.label" args="[entityName]" /></h1>
            <g:if test="${flash.message}">
            <div class="message" role="status">${flash.message}</div>
            </g:if>
            <f:display bean="refacciones" />
            <g:form resource="${this.refacciones}" method="DELETE">
                <fieldset class="buttons">
                    <g:link class="btn btn-success" action="edit" resource="${this.refacciones}">
                        <g:message code="default.button.edit.label" 
                            default="Edit" />
                    </g:link>
                    <input class="btn btn-danger" type="submit" 
                            value="${message(code: 'default.button.delete.label', default: 'Delete')}" 
                            onclick="return confirm('${message(code: 'default.button.delete.confirm.message', default: 'Are you sure?')}');" />
                </fieldset>
            </g:form>
        </div>
    </body>
</html>
