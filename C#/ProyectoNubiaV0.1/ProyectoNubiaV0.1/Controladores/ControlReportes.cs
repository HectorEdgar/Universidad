using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop;
using Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data.SqlClient;
using System.Data;
using ProyectoNubiaV0._1.Controladores;


namespace ProyectoNubiaV0._1.Controladores
{
    class ControlReportes
    {
        private ControladorAsistencia control;
        public ControlReportes()
        {
            //metodoBasura();
            this.control = new ControladorAsistencia();
            //GenerarReporteExcelGrupos(3, 0);

        }

        public void GenerarReporteExcelGrupos(int numMaxFaltas, int numFaltasAprobar)
        {
            // Creamos un objeto Excel.
            Microsoft.Office.Interop.Excel.Application Mi_Excel = default(Microsoft.Office.Interop.Excel.Application);
            // Creamos un objeto WorkBook. Para crear el documento Excel.           
            Microsoft.Office.Interop.Excel.Workbook LibroExcel = default(Microsoft.Office.Interop.Excel.Workbook);
            // Creamos un objeto WorkSheet. Para crear la hoja del documento.
            Microsoft.Office.Interop.Excel.Worksheet HojaExcel = default(Microsoft.Office.Interop.Excel.Worksheet);

            // Iniciamos una instancia a Excel, y Hacemos visibles para ver como se va creando el reporte, 
            // podemos hacerlo visible al final si se desea.
            Mi_Excel = new Microsoft.Office.Interop.Excel.Application();
            Mi_Excel.Visible = false;

            /* Ahora creamos un nuevo documento y seleccionamos la primera hoja del 
             * documento en la cual crearemos nuestro informe. 
             */
            // Creamos una instancia del Workbooks de excel.            
            LibroExcel = Mi_Excel.Workbooks.Add();
            // Creamos una instancia de la primera hoja de trabajo de excel            
            HojaExcel = LibroExcel.Worksheets[1];
            HojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible;

            // Hacemos esta hoja la visible en pantalla 
            // (como seleccionamos la primera esto no es necesario
            // si seleccionamos una diferente a la primera si lo
            // necesitariamos).
            HojaExcel.Activate();

            int cont = 1;

            control.obtenerGruposGimnasio();

            HojaExcel.Range["A" + cont + ":G" + cont + ""].Merge();
            HojaExcel.Range["A" + cont + ":G" + cont + ""].Value = "Reporte generado el día: " + DateTime.Now;
            HojaExcel.Range["A" + cont + ":G" + cont + ""].Font.Italic = true;
            HojaExcel.Range["A" + cont + ":G" + cont + ""].Font.Size = 13;

            cont++;
            cont++;
            for (int i = 0; i < control.gruposGimnasio.Count; i++)
            {



                HojaExcel.Range["A" + cont + ":G" + cont + ""].Merge();
                HojaExcel.Range["A" + cont + ":G" + cont + ""].Value = control.gruposGimnasio[i].nombre;
                HojaExcel.Range["A" + cont + ":G" + cont + ""].Font.Italic = true;
                HojaExcel.Range["A" + cont + ":G" + cont + ""].Font.Size = 13;

                cont++;
                int aux = cont;
                Microsoft.Office.Interop.Excel.Range objCelda = HojaExcel.Range["A" + cont, Type.Missing];
                objCelda.Value = "Matrícula";

                objCelda = HojaExcel.Range["B" + cont, Type.Missing];
                objCelda.Value = "Licenciatura";
                objCelda = HojaExcel.Range["C" + cont, Type.Missing];
                objCelda.Value = "Grupo";

                objCelda = HojaExcel.Range["D" + cont, Type.Missing];
                objCelda.Value = "Nombre";

                objCelda = HojaExcel.Range["E" + cont, Type.Missing];
                objCelda.Value = "Número de Faltas";

                objCelda = HojaExcel.Range["F" + cont, Type.Missing];
                objCelda.Value = "Estado";
                objCelda = HojaExcel.Range["G" + cont, Type.Missing];
                objCelda.Value = "Fecha de las faltas";
                cont++;



                for (int j = 0; j < control.gruposGimnasio[i].Alumnos_GrupoGimnasio.ToList().Count; j++)
                {
                    HojaExcel.Cells[cont, "A"] = control.gruposGimnasio[i].Alumnos_GrupoGimnasio.ToList()[j].Alumno.Matricula;
                    HojaExcel.Cells[cont, "B"] = control.gruposGimnasio[i].Alumnos_GrupoGimnasio.ToList()[j].Alumno.Grupo.Licenciatura.Nombre;
                    HojaExcel.Cells[cont, "C"] = control.gruposGimnasio[i].Alumnos_GrupoGimnasio.ToList()[j].Alumno.Grupo.Nombre;

                    HojaExcel.Cells[cont, "D"] = control.gruposGimnasio[i].Alumnos_GrupoGimnasio.ToList()[j].Alumno.Nombre +
                        control.gruposGimnasio[i].Alumnos_GrupoGimnasio.ToList()[j].Alumno.Apellidos;

                    int numeroFaltas = control.contarFaltas(control.gruposGimnasio[i].Alumnos_GrupoGimnasio.ToList()[j].Alumno.Matricula, control.gruposGimnasio[i].idGimnasio);
                    HojaExcel.Cells[cont, "E"] = numeroFaltas;

                    if (numeroFaltas <= numFaltasAprobar)
                    {
                        HojaExcel.Cells[cont, "F"] = "Aprobado";
                    }
                    else
                    {

                        if (numeroFaltas > numMaxFaltas)
                        {
                            HojaExcel.Cells[cont, "F"] = "Sin derecho a extraordinario";
                        }
                        else
                        {
                            HojaExcel.Cells[cont, "F"] = "Reprobado";

                        }
                    }

                    if (control.fechasFaltas.Length != 0)
                    {
                        HojaExcel.Cells[cont, "G"] = control.fechasFaltas;
                    }
                    else
                    {
                        HojaExcel.Cells[cont, "G"] = "Sin faltas";
                    }

                    cont++;
                }
                cont++;
                cont++;
               
            }
            // Seleccionar todo el bloque desde A1 hasta D #de filas.
            Microsoft.Office.Interop.Excel.Range Rango = HojaExcel.Range["A" + 4 + ":G" + (cont - 1).ToString()];

            // Selecionado todo el rango especificado
            Rango.Select();

            // Ajustamos el ancho de las columnas al ancho máximo del
            // contenido de sus celdas
            Rango.Columns.AutoFit();

            // Asignar filtro por columna
            Rango.AutoFilter(1);

            // Crear un total general
            //LibroExcel.PrintPreview();
            Mi_Excel.Visible = true;



        }


        public void GenerarReportesExcelLicenciatura()
        {

        }


        public void excel1()
        {
            //Excel.Application Mi_Excel = default(Excel.Application);
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                return;
            }
            xlApp.Visible = true;

            Workbook wb = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Worksheet ws = (Worksheet)wb.Worksheets[1];

            if (ws == null)
            {
                Console.WriteLine("Worksheet could not be created. Check that your office installation and project references are correct.");
            }

            // Select the Excel cells, in the range c1 to c7 in the worksheet.
            Range aRange = ws.get_Range("C1", "C7");

            if (aRange == null)
            {
                Console.WriteLine("Could not get a range. Check to be sure you have the correct versions of the office DLLs.");
            }

            // Fill the cells in the C1 to C7 range of the worksheet with the number 6.
            Object[] args = new Object[1];
            args[0] = 6;
            aRange.GetType().InvokeMember("Value", BindingFlags.SetProperty, null, aRange, args);

            // Change the cells in the C1 to C7 range of the worksheet to the number 8.
            //aRange.Value2 = 8;
        }
        public void metodoBasura()
        {


            // Creamos un objeto Excel.
            Microsoft.Office.Interop.Excel.Application Mi_Excel = default(Microsoft.Office.Interop.Excel.Application);
            // Creamos un objeto WorkBook. Para crear el documento Excel.           
            Microsoft.Office.Interop.Excel.Workbook LibroExcel = default(Microsoft.Office.Interop.Excel.Workbook);
            // Creamos un objeto WorkSheet. Para crear la hoja del documento.
            Microsoft.Office.Interop.Excel.Worksheet HojaExcel = default(Microsoft.Office.Interop.Excel.Worksheet);

            // Iniciamos una instancia a Excel, y Hacemos visibles para ver como se va creando el reporte, 
            // podemos hacerlo visible al final si se desea.
            Mi_Excel = new Microsoft.Office.Interop.Excel.Application();
            Mi_Excel.Visible = true;

            /* Ahora creamos un nuevo documento y seleccionamos la primera hoja del 
             * documento en la cual crearemos nuestro informe. 
             */
            // Creamos una instancia del Workbooks de excel.            
            LibroExcel = Mi_Excel.Workbooks.Add();
            // Creamos una instancia de la primera hoja de trabajo de excel            
            HojaExcel = LibroExcel.Worksheets[1];
            HojaExcel.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible;

            // Hacemos esta hoja la visible en pantalla 
            // (como seleccionamos la primera esto no es necesario
            // si seleccionamos una diferente a la primera si lo
            // necesitariamos).
            HojaExcel.Activate();

            // Crear el encabezado de nuestro informe.
            // La primera línea une las celdas y las convierte un en una sola.            
            HojaExcel.Range["A1:E1"].Merge();
            // La segunda línea Asigna el nombre del encabezado.
            HojaExcel.Range["A1:E1"].Value = "----------------------------------------------";
            // La tercera línea asigna negrita al titulo.
            HojaExcel.Range["A1:E1"].Font.Bold = true;
            // La cuarta línea signa un Size a titulo de 15.
            HojaExcel.Range["A1:E1"].Font.Size = 15;

            // Crear el subencabezado de nuestro informe
            HojaExcel.Range["A2:E2"].Merge();
            HojaExcel.Range["A2:E2"].Value = "ENCUESTA DE SATISFACCIÓN AL CLIENTE EXTERNO";
            HojaExcel.Range["A2:E2"].Font.Italic = true;
            HojaExcel.Range["A2:E2"].Font.Size = 13;

            Microsoft.Office.Interop.Excel.Range objCelda = HojaExcel.Range["A3", Type.Missing];
            objCelda.Value = "ID";

            objCelda = HojaExcel.Range["B3", Type.Missing];
            objCelda.Value = "Preguntas";

            objCelda = HojaExcel.Range["C3", Type.Missing];
            objCelda.Value = "Opciones";

            objCelda = HojaExcel.Range["D3", Type.Missing];
            objCelda.Value = "Valor de la Respuesta";

            objCelda = HojaExcel.Range["E3", Type.Missing];
            objCelda.Value = "Numero Votos";

            objCelda.EntireColumn.NumberFormat = "###,###,###.00";

            int i = 4;
            for (int a = 0; a <= 10; a++)
            {
                // Asignar los valores de los registros a las celdas
                HojaExcel.Cells[i, "A"] = "Hola nena1";
                // ID
                HojaExcel.Cells[i, "B"] = "Hola nena2";
                // Pregunta
                HojaExcel.Cells[i, "C"] = "Hola nena 3";
                // Opciones
                HojaExcel.Cells[i, "D"] = "Hola nena 4";
                // Valor de la Respuesta
                HojaExcel.Cells[i, "E"] = "Hola nena 5";
                // Numero Votos

                // Avanzamos una fila
                i++;
            }

            // Seleccionar todo el bloque desde A1 hasta D #de filas.
            Microsoft.Office.Interop.Excel.Range Rango = HojaExcel.Range["A3:E" + (i - 1).ToString()];

            // Selecionado todo el rango especificado
            Rango.Select();

            // Ajustamos el ancho de las columnas al ancho máximo del
            // contenido de sus celdas
            Rango.Columns.AutoFit();

            // Asignar filtro por columna
            Rango.AutoFilter(1);

            // Crear un total general
            //LibroExcel.PrintPreview();
        }
    }
}
