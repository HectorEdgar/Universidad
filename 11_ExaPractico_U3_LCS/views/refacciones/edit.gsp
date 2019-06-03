<!DOCTYPE html>
<html>
    <head>
        AQUI FALTA CODIGO, PERO YA LO SABEN
    </head>
    <body>
        <div class="container" role="main">
            <br/><br/>
            <h1><g:message code="default.edit.label" args="[entityName]" /></h1>
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
            <g:form resource="${this.refacciones}" method="PUT">
                <g:hiddenField name="version" value="${this.refacciones?.version}" />
                <fieldset class="form">
                    AQUI FALTA CODIGO, PERO YA LO SABEN
                </fieldset>
                <fieldset class="buttons">
                    <input class="btn btn-warning" type="submit" value="${message(code: 'default.button.update.label', default: 'Update')}" />
                </fieldset>
            </g:form>
        </div>
    </body>
</html>
