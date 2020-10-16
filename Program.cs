using FastMember;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EjemploReglasNegocio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ha iniciado la carga de Reglas de Negocio");

            #region Carga de Reglas de Negocio

            #region Regla por Defecto: No tiene atención si el contrato está en mora, sin más condicionamientos


            Condicion condicion01_00 = new Condicion
            {
                hecho = "contratoEnMora",
                operador = "igual",
                valor = "si"
            };

            Advertencia advertencia01_00 = new Advertencia
            {
                respuesta = "habilitacion",
                valor = "no"
            };

            Advertencia advertencia02_00 = new Advertencia
            {
                respuesta = "mensaje",
                valor = " El contrato se encuentra se encuentra impago. Le solicitamos que por favor regularice sus pagos"
            };

            ReglaNegocio regla00 = new ReglaNegocio
            {
                descripcion = "Por defecto: No tiene atención si el contrato está en mora, sin más condicionamientos",
                responsable = "nxlopez",
                version = "1.0.0",
                fechaCreacion = DateTime.Parse("2020/02/09 08:50:18"),
                fechaModificacion = DateTime.Parse("2020/02/09 08:50:18"),
                condiciones = new List<Condicion>(),
                advertencias = new List<Advertencia>()
            };
            
            regla00.condiciones.Add(condicion01_00);
            regla00.advertencias.Add(advertencia01_00);
            regla00.advertencias.Add(advertencia02_00);
            #endregion

            #region Produbanco: Atenciones por mes, a nivel de Afiliado, en todos los Procedimientos, cualquier Especialidad, cualquier Producto
            ReglaNegocio regla01 = new ReglaNegocio
            {
                descripcion = "Produbanco: Atenciones por mes, a nivel de Afiliado, en todos los Procedimientos, cualquier Especialidad, cualquier Producto",
                responsable = "nxlopez",
                version = "1.0.0",
                fechaCreacion = DateTime.Parse("2020/02/15 10:22:03"),
                fechaModificacion = DateTime.Parse("2020/02/15 10:22:03"),
                condiciones = new List<Condicion>(),
                advertencias = new List<Advertencia>()
            };

            Condicion condicion01_01 = new Condicion
            {
                hecho = "sponsor",
                operador = "igual",
                valor = "Produbanco"
            };

            Condicion condicion02_01 = new Condicion
            {
                hecho = "atencionesMensualesPorAfiliado",
                operador = "menorIgual",
                valor = "4"
            };

            Advertencia advertencia01_01 = new Advertencia
            {
                respuesta = "habilitacion",
                valor = "No"
            };

            Advertencia advertencia02_01 = new Advertencia
            {
                respuesta = "mensaje",
                valor = "El afiliado ha superado el número de atenciones a las que tiene acceso durante el mes"
            };

            regla01.condiciones.Add(condicion01_01);
            regla01.condiciones.Add(condicion02_01);
            regla01.advertencias.Add(advertencia01_01);
            regla01.advertencias.Add(advertencia02_01);
            #endregion

            #region Santa Maria: Atenciones anuales, a nivel de Contrato, para Consulta, en Especialidad Pediatría, cualquier Producto
            ReglaNegocio regla02 = new ReglaNegocio
            {
                descripcion = "Santa Maria: Atenciones anuales, a nivel de Contrato, para Consulta, en Especialidad Pediatría, cualquier Producto",
                responsable = "nxlopez",
                version = "1.0.0",
                fechaCreacion = DateTime.Parse("2020/03/30 12:00:00"),
                fechaModificacion = DateTime.Parse("2020/03/30 12:00:00"),
                condiciones = new List<Condicion>(),
                advertencias = new List<Advertencia>()
            };

            Condicion condicion01_02 = new Condicion
            {
                hecho = "sponsor",
                operador = "igual",
                valor = "Santa Maria"
            };

            Condicion condicion02_02 = new Condicion
            {
                hecho = "atencionesAnualesPorContrato",
                operador = "menorIgual",
                valor = "16"
            };

            Condicion condicion03_02 = new Condicion
            {
                hecho = "especialidad",
                operador = "igual",
                valor = "Pediatria"
            };

            Condicion condicion04_02 = new Condicion
            {
                hecho = "procedimiento",
                operador = "igual",
                valor = "Consulta"
            };

            Advertencia advertencia01_02 = new Advertencia
            {
                respuesta = "habilitacion",
                valor = "no"
            };

            Advertencia advertencia02_02 = new Advertencia
            {
                respuesta = "mensaje",
                valor = "El contrato al que está afiliado ha superado el número de consulta a las que tiene acceso en Pediatría durante este año"
            };

            regla02.condiciones.Add(condicion01_02);
            regla02.condiciones.Add(condicion02_02);
            regla02.condiciones.Add(condicion03_02);
            regla02.condiciones.Add(condicion04_02);
            regla02.advertencias.Add(advertencia01_02);
            regla02.advertencias.Add(advertencia02_02);
            #endregion

            #region Santa Maria: Descuento adicional de 10% a usuarios de Plan Plus, para procedimiento de Consulta, en cualquier Especialidad
            ReglaNegocio regla03 = new ReglaNegocio
            {
                descripcion = "Santa Maria: Descuento adicional de 10% a usuarios de Plan Plus, para procedimiento de Consulta, en cualquier Especialidad",
                responsable = "nxlopez",
                version = "1.0.0",
                fechaCreacion = DateTime.Parse("2020/03/31 09:48:00"),
                fechaModificacion = DateTime.Parse("2020/03/31 09:48:00"),
                condiciones = new List<Condicion>(),
                advertencias = new List<Advertencia>()
            };

            Condicion condicion01_03 = new Condicion
            {
                hecho = "sponsor",
                operador = "igual",
                valor = "Santa Maria"
            };

            Condicion condicion02_03 = new Condicion
            {
                hecho = "producto",
                operador = "igual",
                valor = "Plan Plus"
            };

            Condicion condicion03_03 = new Condicion
            {
                hecho = "procedimiento",
                operador = "igual",
                valor = "Consulta"
            };

            Advertencia advertencia01_03 = new Advertencia
            {
                respuesta = "descuento",
                valor = "10%"
            };

            Advertencia advertencia02_03 = new Advertencia
            {
                respuesta = "mensaje",
                valor = "Su contrato le hace acreedor a un descuento adicional de 10% en su tarifa"
            };

            regla03.condiciones.Add(condicion01_03);
            regla03.condiciones.Add(condicion02_03);
            regla03.condiciones.Add(condicion03_03);
            regla03.advertencias.Add(advertencia01_03);
            regla03.advertencias.Add(advertencia02_03);
            #endregion

            #region Produbanco: No tiene atención para Especialidad Odontología (ningún procedimiento) en la ciudad de Quevedo, para cualquier Producto
            ReglaNegocio regla04 = new ReglaNegocio
            {
                descripcion = "Produbanco: No tiene atención para Especialidad Odontología (ningún procedimiento) en la ciudad de Quevedo, para cualquier Producto",
                responsable = "nxlopez",
                version = "1.0.0",
                fechaCreacion = DateTime.Parse("2020/03/31 13:01:18"),
                fechaModificacion = DateTime.Parse("2020/03/31 13:01:18"),
                condiciones = new List<Condicion>(),
                advertencias = new List<Advertencia>()
            };

            Condicion condicion01_04 = new Condicion
            {
                hecho = "sponsor",
                operador = "igual",
                valor = "Produbanco"
            };

            Condicion condicion02_04 = new Condicion
            {
                hecho = "especialidad",
                operador = "igual",
                valor = "Odontologia"
            };

            Condicion condicion03_04 = new Condicion
            {
                hecho = "ciudadPrestacion",
                operador = "igual",
                valor = "Quevedo"
            };

            Advertencia advertencia01_04 = new Advertencia
            {
                respuesta = "habilitacion",
                valor = "No"
            };

            Advertencia advertencia02_04 = new Advertencia
            {
                respuesta = "mensaje",
                valor = "Lamentablemente la especialidad de Odontología no está diponible en la ciudad de Quevedo. Por favor, comuníquese con Servicio al Cliente para que le ayude a encontrar el servicio más cercano al lugar de su residencia"
            };

            regla04.condiciones.Add(condicion01_04);
            regla04.condiciones.Add(condicion02_04);
            regla04.condiciones.Add(condicion03_04);
            regla04.advertencias.Add(advertencia01_04);
            regla04.advertencias.Add(advertencia02_04);
            #endregion

            List<ReglaNegocio> ListaReglasNegocio = new List<ReglaNegocio>();
            ListaReglasNegocio.Add(regla00);
            ListaReglasNegocio.Add(regla01);
            ListaReglasNegocio.Add(regla02);
            ListaReglasNegocio.Add(regla03);
            ListaReglasNegocio.Add(regla04);
            #endregion

            Console.WriteLine("Ha finalizado la carga de Reglas de Negocio");

            Console.WriteLine("Ha iniciado la carga de Escenarios de Evaluación");

            #region Carga de Escenarios de Prueba que simulan ser una entrada para la evaluación de Reglas de Negocio
            Escenario escenario01 = new Escenario
            {
                codigo = "escenario01",
                sponsor = "Produbanco",
                producto = "Plan Privilegio",
                especialidad = "Oftalmologia",
                procedimiento = "Consulta",
                contratoEnMora = "no",
                diasImpago = "0",
                atencionesMensualesPorAfiliado = "5",
                atencionesAnualesPorContrato = "5",
                ciudadPrestacion = "Quito",
                descuento = "0%",
                habilitacion = "si",
                mensaje = ""
            };

            Escenario escenario02 = new Escenario
            {
                codigo = "escenario02",
                sponsor = "Produbanco",
                producto = "Plan Basico",
                especialidad = "Odontologia",
                procedimiento = "Consulta",
                contratoEnMora = "no",
                diasImpago = "0",
                atencionesMensualesPorAfiliado = "2",
                atencionesAnualesPorContrato = "5",
                ciudadPrestacion = "Quito",
                descuento = "0%",
                habilitacion = "si",
                mensaje = ""
            };

            Escenario escenario03 = new Escenario
            {
                codigo = "escenario03",
                sponsor = "Produbanco",
                producto = "Plan Basico",
                especialidad = "Odontologia",
                procedimiento = "Consulta",
                contratoEnMora = "no",
                diasImpago = "0",
                atencionesMensualesPorAfiliado = "1",
                atencionesAnualesPorContrato = "3",
                ciudadPrestacion = "Quevedo",
                descuento = "0%",
                habilitacion = "si",
                mensaje = ""
            };

            Escenario escenario04 = new Escenario
            {
                codigo = "escenario04",
                sponsor = "Santa Maria",
                producto = "Plan Inicial",
                especialidad = "Pediatria",
                procedimiento = "Consulta",
                contratoEnMora = "no",
                diasImpago = "0",
                atencionesMensualesPorAfiliado = "4",
                atencionesAnualesPorContrato = "17",
                ciudadPrestacion = "Daule",
                descuento = "0%",
                habilitacion = "si",
                mensaje = ""
            };

            Escenario escenario05 = new Escenario
            {
                codigo = "escenario05",
                sponsor = "Santa Maria",
                producto = "Plan Inicial",
                especialidad = "Pediatria",
                procedimiento = "Consulta",
                contratoEnMora = "si",
                diasImpago = "11",
                atencionesMensualesPorAfiliado = "4",
                atencionesAnualesPorContrato = "18",
                ciudadPrestacion = "Latacunga",
                descuento = "0%",
                habilitacion = "si",
                mensaje = ""
            };

            Escenario escenario06 = new Escenario
            {
                codigo = "escenario06",
                sponsor = "Santa Maria",
                producto = "Plan Plus",
                especialidad = "Gastroenterologia",
                procedimiento = "Consulta",
                contratoEnMora = "no",
                diasImpago = "0",
                atencionesMensualesPorAfiliado = "0",
                atencionesAnualesPorContrato = "2",
                ciudadPrestacion = "Machachi",
                descuento = "0%",
                habilitacion = "si",
                mensaje = ""
            };

            List<Escenario> EscenariosPrueba = new List<Escenario>();
            EscenariosPrueba.Add(escenario01);
            EscenariosPrueba.Add(escenario02);
            EscenariosPrueba.Add(escenario03);
            EscenariosPrueba.Add(escenario04);
            EscenariosPrueba.Add(escenario05);
            EscenariosPrueba.Add(escenario06);
            #endregion

            Console.WriteLine("Ha finalizado la carga de Escenarios de Evaluación");

            //Ejecución de Proceso de Evaluación
            Console.WriteLine("Ha iniciado Proceso de Evaluación");

            #region Proceso de evaluación de escenarios de prueba
            List<ReporteReglas> listaReporteReglasInfringidas = new List<ReporteReglas>();
            //NOTA: el siguiente "foreach" (el primero) solamente existe por propósito de prueba... en la programación final solamente existiría un escenario a evaluar
            foreach (Escenario escenario in EscenariosPrueba)
            {
                var descriptorObjeto = TypeAccessor.Create(escenario.GetType());
                ReporteReglas reglasInfringidas = new ReporteReglas
                {
                    nombreEscenario = descriptorObjeto[escenario,"codigo"].ToString(),
                    ListaReglas = new List<ReglaNegocio>()
                };

                foreach (ReglaNegocio regla in ListaReglasNegocio) {
                    int numCondicionesPorInfringir = regla.condiciones.Count();
                    int numCondicionesInfringidas = 0;

                    foreach (Condicion condicion in regla.condiciones) {
                        var condicionAEvaluar = descriptorObjeto.GetMembers().First(m => m.Name == condicion.hecho);

                        if (condicion.operador == "igual") {
                            if (condicion.valor == descriptorObjeto[escenario, condicionAEvaluar.Name].ToString()) { numCondicionesInfringidas++; }
                        }
                        else if(condicion.operador == "mayor"){
                            if (Int32.Parse(condicion.valor) > Int32.Parse(descriptorObjeto[escenario, condicionAEvaluar.Name].ToString())) { numCondicionesInfringidas++; }
                        }
                        else if (condicion.operador == "menor")
                        {
                            if (Int32.Parse(condicion.valor) < Int32.Parse(descriptorObjeto[escenario, condicionAEvaluar.Name].ToString())) { numCondicionesInfringidas++; }
                        }
                        else if (condicion.operador == "mayorIgual")
                        {
                            if (Int32.Parse(condicion.valor) >= Int32.Parse(descriptorObjeto[escenario, condicionAEvaluar.Name].ToString())) { numCondicionesInfringidas++; }
                        }
                        else if (condicion.operador == "menorIgual")
                        {
                            if (Int32.Parse(condicion.valor) <= Int32.Parse(descriptorObjeto[escenario, condicionAEvaluar.Name].ToString())) { numCondicionesInfringidas++; }
                        }
                        //el asunto del manejo del operador diferente es controversial, hay que analizar a profundidad esta opción... por el momento se comenta
                        /*else if (condicion.operador != "diferente")
                        {
                            if (Int32.Parse(condicion.valor) != Int32.Parse(descriptorObjeto[escenario, condicionAEvaluar.Name].ToString())) { numCondicionesInfringidas++; }
                        }*/
                    }

                    //se añaden las reglas infringidas por el escenario
                    if (numCondicionesInfringidas == numCondicionesPorInfringir) {
                        reglasInfringidas.ListaReglas.Add(regla);
                    }
                }
                listaReporteReglasInfringidas.Add(reglasInfringidas);
            }
            #endregion

            Console.WriteLine("Ha finalizado Proceso de Evaluación");

            #region Impresion de salida
            foreach (ReporteReglas reporte in listaReporteReglasInfringidas) {
                Console.WriteLine("\nCodigo Escenario: " + reporte.nombreEscenario);
                foreach (ReglaNegocio regla in reporte.ListaReglas) {
                    Console.WriteLine("Regla Infringida: " + regla.descripcion);
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
