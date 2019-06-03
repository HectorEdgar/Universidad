<!doctype html>
<html lang="en" class="no-js">
<head>
    
	******************************************************
	******* NO COPIES EL CODIGO !!!! INTERPRETALO !!!!!
	******************************************************
	
	LO QUE YA SABEN MAS LOS IMPORT DE CSS Y JS
	
    USAR CSS -> font-awesome.min.css
    USAR CSS -> bootstrap.css

    USAR JS -> jquery-slim.min.js
    USAR JS -> popper.min.js
    USAR JS -> bootstrap.min.js
    USAR JS -> miLibreria.js
    
</head>
<body>
	
	***** !!! SOLO MUESTRA EL DISEÑO BASICO (falta comportamiento) !!! *******
	
    <!-- MENU -->
    <nav class="navbar navbar-expand-md navbar-dark bg-dark">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">
                AGREGAR LA IMAGEN -> logoAutoRefacciones.png
            </a>
            <!-- button para diseño resposable -->
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarCollapse">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="${createLink(uri: '/')}">
                            Inicio <span class="sr-only">(actual)</span>
                        </a>
                    </li>
                    
                </ul>

                
				<div class="bg-inverse text-white">
					Bienvenido&nbsp; <h4>AQUI SE PONE QUIEN ESTA EN SESION</h4>
				</div>
				<a class="nav-link" href="lo que ya sabes para cerrar sesion">
					AGREGAR LA IMAGEN -> logout.png
				</a>

            </div>
        </div>
    </nav>
    
    <g:layoutBody />

    USAR JS -> application.js

</body>
</html>
