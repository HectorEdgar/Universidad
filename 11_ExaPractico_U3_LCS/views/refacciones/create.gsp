<!DOCTYPE html>
<html>
    <head>
        AQUI FALTA CODIGO, PERO YA LO SABEN
    </head>
    <body>
        <div id="create-refacciones" class="container" role="main">
            <h1><g:message code="default.create.label" args="[entityName]" /></h1>
            <g:if test="${flash.message}">
            <div class="message" role="status">${flash.message}</div>
            </g:if>
            <g:hasErrors bean="${this.refacciones}">
            <ul class="errors" role="alert">
                <g:eachError bean="${this.refacciones}" var="error">
                <li <g:if test="${error in org.springframework.validation.FieldError}">data-field-id="${error.field}"</g:if>><g:message error="${error}"/></li>
                </g:eachError>
            </ul>
            </g:hasErrors>
            <g:form resource="${this.refacciones}" method="POST">
                <fieldset class="form">
                    AQUI FALTA CODIGO, PERO YA LO SABEN
                </fieldset>
                <fieldset class="buttons">
                    <g:submitButton name="create" class="btn btn-primary" 
                        value="${message(code: 'default.button.create.label', default: 'Create')}" />
                </fieldset>
            </g:form>
        </div>
    </body>
</html>
