$(document).ready(function () {


   

    var FechaInicioContrato = $("#FechaInicioContrato").val();
    var espacio = FechaInicioContrato.indexOf(" ");
    var Fecha = FechaInicioContrato.substring(0, espacio)
   // alert(Fecha);
   // var fechas = $("#fechas");
   // fechas.val("01/01/2017");

  //  var SelectRazonSociales = $("SelectRazonSocial option:selected").text();
    //var SelectRazonSocial = $("#SelectRazonSocial").length;
    //console.log(SelectRazonSociales);


    var tipoServicio =$("#tipoServicio").val();
   if(tipoServicio =="Outsourcing contable"){

         var p = $(".auditoria");
           p.hide();



}
 if(tipoServicio !="Outsourcing contable"){

   var out = $(".out");
     out.hide();


}



 



    obtenerClientes();
    ObtenerServivios();
    ObtenerSector();
    ObtenerAntiguedad();
    selectManejaCuotaIniciales();
    ObtenerPorcentaje();
    ObtenerGravado();
    ObtenerFactruaMensaul();
    ObtenerFechaEntregaFacturacion();
    CondicionInicialFacturacion();
    ObtenerGerente();
    ObtenerDirector();

    obtenerTipoContribuyente();

    var SelectRazonSocial = $("#SelectRazonSocial");
    SelectRazonSocial.change(function () {

        var idCliente = ($("#SelectRazonSocial option:selected").val());

        if (idCliente == "0") {

            limpiarFormulario();

        }


        if (idCliente != 0) {

            var data =
           {

               id: idCliente

           }
            $.ajax({
                type: "POST",
                url: '/Home/obtenerCliente',
                contentType: "application/json; charset=utf-8",
                data: JSON.stringify(data),
                dataType: "json",
                success: function (result) {

                    console.log(result);
                    //     var data = JSON.parse(result.d)[0];

                    var nit = $("#NIT");
                    nit.val(result.Nit);
                    var Dv = $("#dv");
                    Dv.val(result.Dv);
                    var direccion = $("#direccion");
                    direccion.val(result.direccion);
                    var tipoContribuyente = $("#tipoContribuyente");
                 //   tipoContribuyente.val(result.TipoContribuyente);
                    var telefono = $("#telefono");
                    telefono.val(result.Telefono);

                    var celular = $("#celular");
                    celular.val(result.Celular);

                    var ContactoCliente = $("#ContactoCliente");
                    ContactoCliente.val(result.ContactoCliente);

                    var email = $("#email");
                    email.val(result.Email);


                }


            });


        }

    });



  

    var SelectServicio = $("#SelectServicio");
    SelectServicio.change(function () {

        var servicio = $("#SelectServicio option:selected").val();
        if (servicio == "e782171e-b9d4-4722-ac6e-2f2720ce438c") {

            var p = $(".auditoria");
            p.hide();


            var out = $(".out");
            out.show();


        } else {

            var p = $(".auditoria");
            p.show();


            var out = $(".out");
            out.hide();
        }


    });

    var d = new Date();
    var n = d.getFullYear();
    var h = parseFloat(n) + 1;

    var FechaInicioFacturacion = $("#fechaIniciosContrato");

    $(FechaInicioFacturacion).blur(function () {

        console.log("ddkf");


        cambiarAños();

    });



    //var horasAno = $("#horasAno");
    //horasAno.text(n);
    //var horasAnoProx = $("#horasAnoProx");
    //horasAnoProx.text(h);

    var ValorCuotaInicial = $("#ValorCuotaInicial");
    var ValorCoutasMensuales = $("#ValorCoutasMensuales");
    var MesesCuotasEjecucion = $("#MesesCuotasEjecucion");
    var selectCuotaInicial = $("#selectCuotaInicial");
    selectCuotaInicial.change(function () {

        calcularValor();

    });


    MesesCuotasEjecucion.change(function () {

        calcularValor();

    });

    ValorCoutasMensuales.change(function () {

        calcularValor();

    });

    var Gravado = $("#SelectGravado").change(function () {

        calcularValor();

    });


    ValorCuotaInicial.change(function () {

        calcularValor();

    });
    var selectManejaCuotaInicial = $("#selectManejaCuotaInicial")
    selectManejaCuotaInicial.change(function () {

        calcularValor();

    });

    var ValorAnualSinIva = $("#ValorAnualSinIva");
    ValorAnualSinIva.blur(function () {

        calcularValor();
    });

    var guardarFacturaF = $("#guardarFacturaF");
    guardarFacturaF.click(function () {

     
        EditarFacturas();


    });



    var guardar = $("#guardarFactura");
    guardar.click(function () {



        var modalFacturas = $("#EdiatFactura");
        modalFacturas.modal("show");



    });

    var SelectDirectoresAcargo = $("#IdDirectorCargo");
    var SelectGerenteAcargo = $("#IdGerenteCargo");

  


    var SelectAntiguedad = $("#selectAntiguedad");
    var SelectTipoContribuyente = $("#SelectTipoContribuyente");
    var SelectServicio = $("#SelectServicio");
    var SelectSector = $("#SelectSector");
  
 //   SelectServicio.prepend(
 //    $('<option  selected="selected"></option>').val(0).html("Seleccionar")
 //);

    var SelectRazonSocial = $("#SelectRazonSocial");



  //  SelectRazonSocial.prepend(
  //    $('<option  selected="selected"></option>').val(0).html("Seleccionar")
    //);

    SelectTipoContribuyente.attr('data-live-search', true);
    SelectDirectoresAcargo.attr('data-live-search', true);
    SelectGerenteAcargo.attr('data-live-search', true);
    SelectAntiguedad.attr('data-live-search', true);
    SelectRazonSocial.attr('data-live-search', true);
    SelectServicio.attr('data-live-search', true);
    SelectSector.attr('data-live-search', true);
    var auditor = $("#auditor");
    auditor.blur(function () {
        calcularTiempoTotal();


    });

    var Impuestos = $("#HorasImpuestos");
    Impuestos.blur(function () {
        calcularTiempoTotal();
    });


    var HorasAuditoria = $("#HorasAuditoria");
    HorasAuditoria.blur(function () {
        calcularTiempoTotal();
    });

    var Legal = $("#HorasLegales");
    Legal.blur(function () {
        calcularTiempoTotal();
    });

    var Sistema = $("#HorasSistemas");
    Sistema.blur(function () {
        calcularTiempoTotal();
    });
    var ifrs = $("#HorasIFRS");
    ifrs.blur(function () {
        calcularTiempoTotal();
    });



   


})

function obtenerTipoContribuyente() {


    var TipoContribuyente = $("#TipoContribuyente").val();
    var temp = "";

    if (TipoContribuyente == "Gran Contribuyente") {

        temp += "<option value='Gran Contribuyente' selected='selected' >Gran Contribuyente</option>";

    } else {

        temp += "<option value='Gran Contribuyente'>Gran Contribuyente</option>";

    }
    if (TipoContribuyente == "Empresa del estado") {

        temp += "<option value='Empresa del estado' selected='selected'>Empresa del estado</option>";

    } else {

        temp += "<option value='Empresa del estado'>Empresa del estado</option>";

    }
    if (TipoContribuyente == "Régimen Común ") {

        temp += "<option value='Régimen Común' selected='selected'>Régimen Común </option>";

    } else {

        temp += "<option value='Régimen Común'>Régimen Común</option>";

    }
    if (TipoContribuyente == "No residente en el país") {

        temp += "<option value='No residente en el país' selected='selected'>No residente en el país</option>";

    } else {

        temp += "<option value='No residente en el país'>No residente en el país</option>";

    }




    var SelectTipoContribuyente = $("#SelectTipoContribuyente");
    SelectTipoContribuyente.empty();
    SelectTipoContribuyente.append(temp);




}



function ObtenerPorcentaje() {


    var Porcentaje = $("#PorcentajeCuotaInicial").val();
    var temp = "";
    if (Porcentaje == "0") {

        temp += "<option value='0' selected='selected'>0%</option>";

    } else {

        temp += "<option value='0'>0%</option>";

    }

    if (Porcentaje == "10") {

        temp += "<option value='10' selected='selected' >10%</option>";

    } else {

        temp += "<option value='10'>10%</option>";

    }

    if (Porcentaje == "20") {

        temp += "<option value='20' selected='selected'>20%</option>";

    } else {

        temp += "<option value='20'>20%</option>";

    }
    if (Porcentaje == "30") {

        temp += "<option value='30' selected='selected' >30%</option>";

    } else {

        temp += "<option value='30'>30%</option>";

    }
    if (Porcentaje == "40") {

        temp += "<option value='40' selected='selected' >40%</option>";

    } else {

        temp += "<option value='40'>40%</option>";

    }
    if (Porcentaje == "50") {

        temp += "<option value='50' selected='selected'>50%</option>";

    } else {

        temp += "<option value='50'>50%</option>";

    }
    if (Porcentaje == "60") {

        temp += "<option value='60' selected='selected'>60%</option>";

    } else {

        temp += "<option value='60'>60%</option>";

    }
    if (Porcentaje == "70") {

        temp += "<option value='70' selected='selected'>70%</option>";

    } else {

        temp += "<option value='70'>70%</option>";

    }
    if (Porcentaje == "80") {

        temp += "<option value='80' selected='selected'>80%</option>";

    } else {

        temp += "<option value='80'>80%</option>";

    }
    if (Porcentaje == "90") {

        temp += "<option value='90' selected='selected'>90%</option>";

    } else {

        temp += "<option value='90'>90%</option>";

    }
    if (Porcentaje == "100") {

        temp += "<option value='100' selected='selected'>100%</option>";

    } else {

        temp += "<option value='100'>100%</option>";

    }



    var serviciosCliente = $("#selectCuotaInicial");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}


function ObtenerGravado() {


    var Gravado = $("#gravado").val();
    var temp = "";

    if (Gravado == "SI") {

        temp += "<option value='SI' selected='selected' >SI</option>";

    } else {

        temp += "<option value='SI'>SI</option>";

    }
    if (Gravado == "NO") {

        temp += "<option value='NO' selected='selected'>NO</option>";

    } else {

        temp += "<option value='NO'>NO</option>";

    }

   

    var serviciosCliente = $("#SelectGravado");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}


function ObtenerSector() {


    var sector = $("#tipoSector").val();
    var temp="";

    if (sector == "REAL") {

        temp += "<option value='REAL' selected='selected' >REAL</option>";

    } else {

        temp += "<option value='REAL'>REAL</option>";

    }

    if (sector == "BANCA-MULTILATERA") {

        temp += "<option value='BANCA-MULTILATERA' selected='selected' >BANCA-MULTILATERA</option>";

    } else {

        temp += "<option value='BANCA-MULTILATERA'>BANCA-MULTILATERA</option>";

    }
    if (sector == "FINANCIERA") {

        temp += "<option value='FINANCIERA' selected='selected' >FINANCIERA</option>";

    } else {

        temp += "<option value='FINANCIERA'>FINANCIERA</option>";

    }
    if (sector == "SOLIDARIO") {

        temp += "<option value='SOLIDARIO' selected='selected' >SOLIDARIO</option>";

    } else {

        temp += "<option value='SOLIDARIO'>SOLIDARIO</option>";

    }



   
 
   

    
    var serviciosCliente = $("#SelectSector");
            serviciosCliente.empty();
            serviciosCliente.append(temp);


     

}



function ObtenerAntiguedad() {


    var antigueda = $("#antigueda").val();
    var temp = "";

    if (antigueda == "Gran Contribuyente") {

        temp += "<option value='Gran Contribuyente' selected='selected' >Gran Contribuyente</option>";

    } else {

        temp += "<option value='Gran Contribuyente'>Gran Contribuyente</option>";

    }

    if (antigueda == "Empresa del estado") {

        temp += "<option value='Empresa del estado' selected='selected' >Empresa del estado</option>";

    } else {

        temp += "<option value='Empresa del estado'>Empresa del estado</option>";

    }
    if (antigueda == "Régimen Común") {

        temp += "<option value='Régimen Común' selected='selected' >Régimen Común</option>";

    } else {

        temp += "<option value='Régimen Común'>Régimen Común</option>";

    }
    if (antigueda == "No residente en el país") {

        temp += "<option value='No residente en el país' selected='selected' >No residente en el país</option>";

    } else {

        temp += "<option value='No residente en el país'>No residente en el país</option>";

    }
   



    var serviciosCliente = $("#selectAntiguedad");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}

function ObtenerAntiguedad() {


    var antigueda = $("#antigueda").val();
    var temp = "";

    if (antigueda == "INCREMENTO") {

        temp += "<option value='INCREMENTO' selected='selected' >INCREMENTO</option>";

    } else {

        temp += "<option value='INCREMENTO'>INCREMENTO</option>";

    }

    if (antigueda == "TERMINACION DE CONTRATO") {

        temp += "<option value='TERMINACION DE CONTRATO' selected='selected' >TERMINACION DE CONTRATO</option>";

    } else {

        temp += "<option value='TERMINACION DE CONTRATO'>TERMINACION DE CONTRATO</option>";

    }
    if (antigueda == "FACTURA ADICIONAL") {

        temp += "<option value='FACTURA ADICIONAL' selected='selected' >FACTURA ADICIONAL</option>";

    } else {

        temp += "<option value='FACTURA ADICIONAL'>FACTURA ADICIONAL</option>";

    }
    if (antigueda == "CLIENTE NUEVO") {

        temp += "<option value='CLIENTE NUEVO' selected='selected' >CLIENTE NUEVO</option>";

    } else {

        temp += "<option value='CLIENTE NUEVO'>CLIENTE NUEVO</option>";

    }
    if (antigueda == "REDISTRIBUCIÓN DE HORAS") {

        temp += "<option value='REDISTRIBUCIÓN DE HORAS' selected='selected'>REDISTRIBUCIÓN DE HORAS</option>";

    } else {

        temp += "<option value='REDISTRIBUCIÓN DE HORAS'>REDISTRIBUCIÓN DE HORAS</option>";

    }



    var serviciosCliente = $("#selectAntiguedad");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}

function ObtenerFactruaMensaul() {


    var FacturaMensual = $("#FacturaMensual").val();
   // alert(FacturaMensual);
    var temp = "";

    if (FacturaMensual == "ANTICIPADA") {

        temp += "<option value='ANTICIPADA' selected='selected'>ANTICIPADA</option>";

    } else {

        temp += "<option value='ANTICIPADA'>ANTICIPADA</option>";

    }
    if (FacturaMensual == "VENCIDA") {

        temp += "<option value='VENCIDA' selected='selected'>VENCIDA</option>";

    } else {

        temp += "<option value='VENCIDA'>VENCIDA</option>";

    }



    var serviciosCliente = $("#SelectFacturaMensual");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}


function ObtenerFechaEntregaFacturacion() {


    var FacturaMensual = $("#FechaEntregaFacturas").val();
 console.log(FacturaMensual);
    var temp = "";

    if (FacturaMensual == "5 DÍAS DE CADA MES") {

        temp += "<option value='5 DÍAS DE CADA MES' selected='selected'>5 DÍAS DE CADA MES</option>";

    } else {

        temp += "<option value='5 DÍAS DE CADA MES'>5 DÍAS DE CADA MES</option>";

    }
    if (FacturaMensual == "10 DÍAS DE CADA MES") {

        temp += "<option value='10 DÍAS DE CADA MES' selected='selected'>10 DÍAS DE CADA MES</option>";

    } else {

        temp += "<option value='10 DÍAS DE CADA MES'>10 DÍAS DE CADA MES</option>";

    }
      if (FacturaMensual == "20 DÍAS DE CADA MES") {

        temp += "<option value='20 DÍAS DE CADA MES' selected='selected'>20 DÍAS DE CADA MES</option>";

    } else {

        temp += "<option value='20 DÍAS DE CADA MES'>20 DÍAS DE CADA MES</option>";

    }
    if (FacturaMensual == "CUANDO LO INFORME EL GERENTE") {

        temp += "<option value='CUANDO LO INFORME EL GERENTE' selected='selected'>CUANDO LO INFORME EL GERENTE</option>";

    } else {

        temp += "<option value='CUANDO LO INFORME EL GERENTE'>CUANDO LO INFORME EL GERENTE</option>";

    }



    var serviciosCliente = $("#SelectFechaEntregaFactura");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}


function CondicionInicialFacturacion() {


    var FacturaMensual = $("#CondicionIniciarFacturacion").val();
    // alert(FacturaMensual);
    var temp = "";

    if (FacturaMensual == "AUTORIZACIÓN DEL GERENTE A CARGO POR MEDIO DE CORREO ELECTRONICO") {

        temp += "<option value='AUTORIZACIÓN DEL GERENTE A CARGO POR MEDIO DE CORREO ELECTRONICO' selected='selected'>AUTORIZACIÓN DEL GERENTE A CARGO POR MEDIO DE CORREO ELECTRONICO</option>";

    } else {

        temp += "<option value='AUTORIZACIÓN DEL GERENTE A CARGO POR MEDIO DE CORREO ELECTRONICO'>AUTORIZACIÓN DEL GERENTE A CARGO POR MEDIO DE CORREO ELECTRONICO</option>";

    }
    if (FacturaMensual == "CONTRA ENTREGA DE INFORME") {

        temp += "<option value='CONTRA ENTREGA DE INFORME' selected='selected'>CONTRA ENTREGA DE INFORME</option>";

    } else {

        temp += "<option value='10 DÍAS DE CADA MES'>10 DÍAS DE CADA MES</option>";

    }
    if (FacturaMensual == "NOMBRAMIENTO EN CÁMARA DE COMERCIO") {

        temp += "<option value='NOMBRAMIENTO EN CÁMARA DE COMERCIO' selected='selected'>NOMBRAMIENTO EN CÁMARA DE COMERCIO</option>";

    } else {

        temp += "<option value='NOMBRAMIENTO EN CÁMARA DE COMERCIO'>NOMBRAMIENTO EN CÁMARA DE COMERCIO</option>";

    }
     if (FacturaMensual == "PREVIA ENTREGA DE LA ORDEN SE INICIA LA FACTURACIÓN") {

        temp += "<option value='PREVIA ENTREGA DE LA ORDEN SE INICIA LA FACTURACIÓN' selected='selected'>PREVIA ENTREGA DE LA ORDEN SE INICIA LA FACTURACIÓN</option>";

    } else {

        temp += "<option value='NOMBRAMIENTO EN CÁMARA DE COMERCIO'>PREVIA ENTREGA DE LA ORDEN SE INICIA LA FACTURACIÓN</option>";

    }



    var serviciosCliente = $("#SelectCondicionInicialFacturacion");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}


function selectManejaCuotaIniciales() {


    var antigueda = $("#ManejoCuotaInicial").val();
    var temp = "";

    if (antigueda == "SI") {

        temp += "<option value='SI' selected='selected'>SI</option>";

    } else {

        temp += "<option value='SI'>SI</option>";

    }

    if (antigueda == "NO") {

        temp += "<option value='NO' selected='selected' >NO</option>";

    } else {

        temp += "<option value='NO'>NO</option>";

    }




    var serviciosCliente = $("#selectManejaCuotaInicial");
    serviciosCliente.empty();
    serviciosCliente.append(temp);




}

function ObtenerGerente() {

    var IdGerenteaCargos = $("#IdGerenteaCargos");

    var IdGerenteaCargos = $("#IdGerenteaCargos").val();
  

    console.log("------------------------------");

    $("#IdGerenteCargo option").each(function (index) {


        if (IdGerenteaCargos == $(this).val()) {

            $(this).selected = true;

            //  $(this).remove();

            // var option = "<option value='" + $(this).val() + "' selected='selected'>" + $(this).text() + "</option> ";

            // console.log(option);

            //            SelectRazonSocial.append(option);


        }


    });

}


function ObtenerDirector() {

    var NombreDirector = $("#NombreDirector");

    var NombreDirector = $("#NombreDirector").val();


    console.log("------------------------------");

    $("#IdDirectorCargo option").each(function (index) {


        if (NombreDirector == $(this).val()) {

            $(this).selected = true;

            //  $(this).remove();

            // var option = "<option value='" + $(this).val() + "' selected='selected'>" + $(this).text() + "</option> ";

            // console.log(option);

            //            SelectRazonSocial.append(option);


        }


    });





}


function ObtenerServivios() {

    var SelectRazonSocial = $("#SelectServicio");

    var RazonSocialEs = $("#ServicioId").val();
    console.log(RazonSocialEs);

    console.log("------------------------------");

    $("#SelectServicio option").each(function (index) {
      //  SelectServicio

       if (RazonSocialEs == $(this).val()) {
    
     

          $(this).selected = true;
   

       }


    });
}

function obtenerClientes() {

    var SelectRazonSocial = $("#SelectRazonSocial");

    var RazonSocialEs = $("#idCliente").val();
    console.log(RazonSocialEs);

    console.log("------------------------------");

    $("#SelectRazonSocial option").each(function (index) {


        if (RazonSocialEs == $(this).val()) {

            $(this).selected = true;

          //  $(this).remove();

           // var option = "<option value='" + $(this).val() + "' selected='selected'>" + $(this).text() + "</option> ";

           // console.log(option);

//            SelectRazonSocial.append(option);

          
        }

       
    });


}




function cambiarAños() {


  
   

    var FechaInicioContrato = $("#fechaIniciosContrato").val();
    var d = new Date(FechaInicioContrato);
    var n = d.getFullYear();
    var h = parseFloat(n) + 1;


    var horasAno = $("#horasAno");
    horasAno.text(n);
    var horasAnoProx = $("#horasAnoProx");
    horasAnoProx.text(h);

   


 

};


function calcularValor() {


    var ValorAnualSinIva = $("#ValorAnualSinIva").val();
    var ValorMensualSinIva = $("#ValorMensualSinIva");
    var ValorCuotaInicial2 = $("#ValorCuotaInicial");
    var ValorCuotaInicial = $("#ValorCuotaInicial").val();
    var ValorTotalContratoIncluidoIvaAnual = $("#ValorTotalContratoIncluidoIvaAnual");
    var MesesCuotasEjecucion = $("#MesesCuotasEjecucion").val();
    var Gravado = $("#SelectGravado option:selected").val();
    var ValorCoutasMensuales = $("#ValorCoutasMensuales");




    var ManejoCuotaInicial = $("#selectManejaCuotaInicial option:selected").val();

    if (ManejoCuotaInicial == "SI") {


        var PorcentajeCuotaInicial = $("#selectCuotaInicial option:selected").val();
        var rsultPorcentaje = ((parseFloat(ValorAnualSinIva) * parseFloat(PorcentajeCuotaInicial)) / 100);
        ValorCuotaInicial2.val(rsultPorcentaje);


        ValorMensualSinIva.val(0);

        if (Gravado == "SI") {

            var rSult = ((parseFloat(ValorAnualSinIva) - parseFloat(rsultPorcentaje)) / parseFloat(MesesCuotasEjecucion));
            rSult = rSult + (rSult * 0.19);

            ValorCoutasMensuales.val(rSult);

            var sRulstG = (parseFloat(ValorAnualSinIva) + parseFloat(ValorAnualSinIva * 0.19));
            ValorTotalContratoIncluidoIvaAnual.val(sRulstG);

        }
        if (Gravado == "NO") {

            var rSult = ((parseFloat(ValorAnualSinIva) - parseFloat(rsultPorcentaje)) / parseFloat(MesesCuotasEjecucion));


            ValorCoutasMensuales.val(rSult);


            ValorTotalContratoIncluidoIvaAnual.val(ValorAnualSinIva);

        }




    }
    if (ManejoCuotaInicial == "NO") {



        ValorCuotaInicial2.val(0);
        ValorCoutasMensuales.val(0);
        ValorMensualSinIva.val(parseFloat(ValorAnualSinIva) / parseFloat(MesesCuotasEjecucion));
        if (Gravado == "SI") {



            var sRulstG = (parseFloat(ValorAnualSinIva) + parseFloat(ValorAnualSinIva * 0.19));
            ValorTotalContratoIncluidoIvaAnual.val(sRulstG);

        }
        if (Gravado == "NO") {



            ValorTotalContratoIncluidoIvaAnual.val(ValorAnualSinIva);

        }





    }




}



function EditarFacturas() {


    var RsultTotalesOut = $("#RsultTotalesOut").text();
    var RsultTotalAproxes = $("#RsultTotalAproxes").text();
    var Totaloutsourcing = parseFloat(RsultTotalesOut) + parseFloat(RsultTotalAproxes);




    var ventaCargo1 = $("#ventaCargo1").val();
  

    if (ventaCargo1 == "") {
        ventaCargo1 = " ";

    }

    var ProcentajeventaCargo1 = $("#ProcentajeventaCargo1").val();

    if (ProcentajeventaCargo1 == "") {
        ProcentajeventaCargo1 = " ";

    }

    var ventaCargo2 = $("#ventaCargo2").val();


    if (ventaCargo2 == "") {
        ventaCargo2 = " ";

    }

    var ProcentajeventaCargo2 = $("#ProcentajeventaCargo2").val();

    if (ProcentajeventaCargo2 == "") {
        ProcentajeventaCargo2 = " ";

    }

    var ventaCargo3 = $("#ventaCargo3").val();


    if (ventaCargo3 == "") {
        ventaCargo3 = " ";

    }

    var ProcentajeventaCargo3 = $("#ProcentajeventaCargo3").val();

    if (ProcentajeventaCargo3 == "") {
        ProcentajeventaCargo3 = " ";

    }










    var fecha = $("#fecha").val();
    var ConsecutivoControlTiempos = "cons";
    var SelectTipoContribuyente = $("#SelectTipoContribuyente option:selected").val();
    var SelectRazonSocial = $("#SelectRazonSocial option:selected").val();
    var SelectServicio = $("#SelectServicio option:selected").val();
    var SelectSector = $("#SelectSector").val();
    var SelectAntiguedad = $("#selectAntiguedad option:selected").val();
    var numeroContrato = $("#numeroContrato").val();
    var ValorAnualSinIva = $("#ValorAnualSinIva").val();
    var MesesCuotasEjecucion = $("#MesesCuotasEjecucion").val();
    var ManejoCuotaInicial = $("#selectManejaCuotaInicial").val();
    var PorcentajeCuotaInicial = $("#selectCuotaInicial").val();
    var ValorCuotaInicial = $("#ValorCuotaInicial").val();
    var ValorCoutasMensuales = $("#ValorCoutasMensuales").val();
    var ValorMensualSinIva = $("#ValorMensualSinIva").val();
    var Gravado = $("#SelectGravado").val();
    var ValorTotalContratoIncluidoIvaAnual = $("#ValorTotalContratoIncluidoIvaAnual").val();
    var FechaInicioContrato = $("#fechaIniciosContrato").val();
    var FechaFinalizacionContrato = $("#FechaFinalizacionContratos").val();
    var FechaInicioFacturacion = $("#FechaInicioFacturacion").val();
    var FacturacionMensual = $("#SelectFacturaMensual").val();
    var FechaEntregaFacturacion = $("#SelectFechaEntregaFactura option:selected").val();  
    var CondicionIniciarFacturacion = $("#SelectCondicionInicialFacturacion option:selected").val();
    var TextoFacturacionObservaciones = $("#TextoFacturacionObservaciones").val();
    var IdGerenteCargo = $("#IdGerenteCargo").val();
    var IdDirectorCargo = $("#IdDirectorCargo").val();
    var Asistenteauditoría = $("#Aauditoria").val();
    var AuditorJunior = $("#Ajunior").val();
    var AuditorSemisenior = $("#ASemisenior").val();
    var AuditorSenior = $("#ASenior").val();
    var SupervisorJunior = $("#Sjunior").val();
    var SupervisorSemisenior = $("#Ssemisenior").val();
    var SupervisorSenior = $("#Ssenior").val();
    var GerenteJunior = $("#GJunior").val();
    var GerenteSemisenior = $("#GSemi").val();
    var GerenteSenior = $("#GSenior").val();
    var DirectorJunior = $("#DJunior").val();
    var DirectorSemisenior = $("#DSemi").val();
    var DirectorSenior = $("#DSenior").val();

    var totalAuditoBd = $("#vaueAuditoria").text();
    var totalAuditoBdProx = $("#vaueAuditoriaAprox").text();

    var Auditorias = parseFloat(totalAuditoBd) + parseFloat(totalAuditoBdProx);

    console.log(TextoFacturacionObservaciones);

    var Totalauditoria = Auditorias;

    if (TextoFacturacionObservaciones == "") {

        TextoFacturacionObservaciones = " ";

    }

    if (isNaN(Totalauditoria)) {

        Totalauditoria = 0;

    }


    var AuditorTI = $("#AuditorTI").val();
    var SupervisorTI = $("#supervisorTI").val();
    var GerenteTI = $("#GerenteTI").val();
    var Auditorimpuestos = $("#AuditorImpuesto").val();
    var GerenteImpuestos = $("#Gerenteimpuestos").val();
    var AsesorJurídico = $("#AsesorJuridico").val();
    var GerenteJurídico = $("#GJuridico").val();


    var horasAno = $("#horasAno").text();
    var horasAnoProx = $("#horasAnoProx").text();




    var Totalespecialistas = $("#valueEx").text();
 

    var AauditoriaProx = $("#AauditoriaProx").val();
    var AjuniorAprox = $("#AjuniorAprox").val();
    var ASemiseniorAprox = $("#ASemiseniorAprox").val();
    var ASeniorAprox = $("#ASeniorAprox").val();
    var SjuniorAprox = $("#SjuniorAprox").val();
    var SsemiseniorAprox = $("#SsemiseniorAprox").val();
    var SseniorAprox = $("#SseniorAprox").val();
    var GJuniorAprox = $("#GJuniorAprox").val();
    var GSemiAprox = $("#GSemiAprox").val();
    var GSeniorAprox = $("#GSeniorAprox").val();
    var DJuniorAprox = $("#DJuniorAprox").val();
    var DSemiAprox = $("#DSemiAprox").val();
    var DSeniorAprox = $("#DSeniorAprox").val();
    var vaueAuditoriaAprox = $("#vaueAuditoriaAprox").text();
    var AuditorTIAprox = $("#AuditorTIAprox").val();
    var supervisorTIAprox = $("#supervisorTIAprox").val();
    var GerenteTIAprox = $("#GerenteTIAprox").val();
    var AuditorImpuestoAprox = $("#AuditorImpuestoAprox").val();
    var GerenteimpuestosAprox = $("#GerenteimpuestosAprox").val();
    var AsesorJuridicoProx = $("#AsesorJuridicoProx").val();
    var GJuridicoAprox = $("#GJuridicoAprox").val();
    var valueEx = $("#valueExAprox").text();
    var RsultTotalAprox = $("#RsultTotalAprox").val();


    var OutGerenteval = $("#OutGerenteval").val();
    var OutGerentevalAprox = $("#OutGerentevalAprox").val();
    var outSupervisorVal = $("#outSupervisorVal").val();
    var outSupervisorValProx = $("#outSupervisorValProx").val();
    var outcordinadorVal = $("#outcordinadorVal").val();
    var outcordinadorValProx = $("#outcordinadorValProx").val();
    var outAnalistaVal = $("#outAnalistaVal").val();
    var outAnalistaValProx = $("#outAnalistaValProx").val();
    var outAuxiliarVal = $("#outAuxiliarVal").val();
    var outAuxiliarValProx = $("#outAuxiliarValProx").val();
   




    if (RsultTotalAprox == "") {

        RsultTotalAprox = 0;

    }
    if (valueEx == "") {

        valueEx = 0;

    }

    if (vaueAuditoriaAprox == "") {

        vaueAuditoriaAprox = 0;

    }

    var FacturaID = $("#facturaId").val();
   
    if (RsultTotalesOut == "") {

        RsultTotalesOut = 0;
    }

    if (isNaN(Totaloutsourcing)) {

        Totaloutsourcing = 0;
    }

    if (RsultTotalAproxes == "") {

        RsultTotalAproxes = 0;
    }


    if (numeroContrato == "") {

        numeroContrato = " ";

    }



    var TotalAuditoriaTI = parseFloat(AuditorTI) + parseFloat(GerenteTI) + parseFloat(SupervisorTI) + parseFloat(AuditorTIAprox) + parseFloat(supervisorTIAprox) + parseFloat(GerenteTIAprox);
    var TotalAuditoriaJuridica = parseFloat(AsesorJurídico) + parseFloat(GerenteJurídico) + parseFloat(AsesorJuridicoProx) + parseFloat(GJuridicoAprox);
    var TotalAuditoriaImpuesto = parseFloat(Auditorimpuestos) + parseFloat(GerenteImpuestos) + parseFloat(AuditorImpuestoAprox) + parseFloat(GerenteimpuestosAprox);

    if (isNaN(Totaloutsourcing)) {

        var rSultTotalFinal = Auditorias + TotalAuditoriaTI + TotalAuditoriaJuridica + TotalAuditoriaImpuesto;

    } else {

        var rSultTotalFinal = Auditorias + TotalAuditoriaTI + TotalAuditoriaJuridica + TotalAuditoriaImpuesto + Totaloutsourcing;

    }
      


   


    var Total = rSultTotalFinal;


    if (isNaN(Total)) {

        Total = 0;

    }

  //  alert(Total);



    var data = {


        TipoContribuyente:SelectTipoContribuyente,

        ventaCargo1: ventaCargo1,
        ProcentajeventaCargo1: ProcentajeventaCargo1,

        ventaCargo2: ventaCargo2,
        ProcentajeventaCargo2: ProcentajeventaCargo2,

        ventaCargo3: ventaCargo3,
        ProcentajeventaCargo3: ProcentajeventaCargo3,



        FacturaID:FacturaID,
        OutGerenteval: OutGerenteval,
        OutGerentevalAprox: OutGerentevalAprox,
        outSupervisorVal: outSupervisorVal,
        outSupervisorValProx: outSupervisorValProx,
        outcordinadorVal: outcordinadorVal,
        outcordinadorValProx: outcordinadorValProx,
        outAnalistaVal: outAnalistaVal,
        outAnalistaValProx: outAnalistaValProx,
        outAuxiliarVal: outAuxiliarVal,
        outAuxiliarValProx: outAuxiliarValProx,
        RsultTotalesOut: RsultTotalesOut,
        RsultTotalAproxes: RsultTotalAproxes,
        Totaloutsourcing:Totaloutsourcing,




        RsultTotalAprox: RsultTotalAprox,
        valueEx: valueEx,
        GJuridicoAprox:GJuridicoAprox,
        AsesorJuridicoProx: AsesorJuridicoProx,
        GImpuestosAprox:GerenteimpuestosAprox,
        AuditorImpuestoAprox:AuditorImpuestoAprox,
        GerenteTIAprox:GerenteTIAprox,
        supervisorTIAprox: supervisorTIAprox,
        AuditorTIAprox: AuditorTIAprox,
        vaueAuditoriaAprox: vaueAuditoriaAprox,
        DSeniorAprox: DSeniorAprox,
        DSemiAprox: DSemiAprox,
        DJuniorAprox: DJuniorAprox,
        GSeniorAprox: GSeniorAprox,
        GSemiAprox: GSemiAprox,
        GJuniorAprox: GJuniorAprox,
        SseniorAprox: SseniorAprox,
        SsemiseniorAprox: SsemiseniorAprox,
        SjuniorAprox: SjuniorAprox,
        ASeniorAprox: ASeniorAprox,
        ASemiseniorAprox: ASemiseniorAprox,
        AjuniorAprox: AjuniorAprox,
        AauditoriaProx: AauditoriaProx,
        horasAnoProx: horasAnoProx,
        horasAno:horasAno,



        TotalHorasAuditoriaTI: TotalAuditoriaTI,
        TotalHorasAuditoriaImpuesto: TotalAuditoriaImpuesto,
        TotalHorasAuditoriaJuridica:TotalAuditoriaJuridica,
        Asistente_auditoría: Asistenteauditoría,
        Auditor_Junior: AuditorJunior,
        Auditor_Semisenior: AuditorSemisenior,
        Auditor_Senior: AuditorSenior,
        Supervisor_Junior: SupervisorJunior,
        Supervisor_Semisenior: SupervisorSemisenior,
        Supervisor_Senior: SupervisorSenior,
        Gerente_Junior: GerenteJunior,
        Gerente_Semisenior: GerenteSemisenior,
        Gerente_Senior: GerenteSenior,
        Director_Junior: DirectorJunior,
        Director_Semisenior: DirectorSemisenior,
        Director_Senior: DirectorSenior,
        Total_auditoría: Totalauditoria,
        Auditor_TI: AuditorTI,
        Supervisor_TI: SupervisorTI,
        Gerente_TI: GerenteTI,
        Auditor_impuestos: Auditorimpuestos,
        Gerente_impuestos: GerenteImpuestos,
        Asesor_Jurídico: AsesorJurídico,
        Gerente_Jurídico: GerenteJurídico,
        Total_especialistas: Totalespecialistas,
        TOTALTIEMPO:Total,

        FechaDiligenciamiento: fecha,
        ConsecutivoControlTiempo: ConsecutivoControlTiempos,
        IdCliente: SelectRazonSocial,
        TipoServicio: SelectServicio,
        Sector: SelectSector,
        Antiguedad: SelectAntiguedad,
        numeroContrato: numeroContrato,
        ValorAnualSinIva: ValorAnualSinIva,
        MesesCuotasEjecucion: MesesCuotasEjecucion,
        ManejoCuotaInicial: ManejoCuotaInicial,
        PorcentajeCuotaInicial: PorcentajeCuotaInicial,
        ValorCuotaInicial: ValorCuotaInicial,
        ValorCoutasMensuales: ValorCoutasMensuales,
        ValorMensualSinIva: ValorMensualSinIva,
        Gravado: Gravado,
        ValorTotalContratoIncluidoIvaAnual: ValorTotalContratoIncluidoIvaAnual,
        FechaInicioContrato: FechaInicioContrato,
        FechaFinalizacionContrato: FechaFinalizacionContrato,
        FechaInicioFacturacion: FechaInicioFacturacion,
        FacturacionMensual: FacturacionMensual,
        FechaEntregaFacturacion: FechaEntregaFacturacion,
        CondicionIniciarFacturacion: CondicionIniciarFacturacion,
        TextoFacturacionObservaciones: TextoFacturacionObservaciones,
    
        IdGerenteCargo: IdGerenteCargo,
        IdDirectorCargo: IdDirectorCargo


    }
    

   

    var mensaje = $("#comment").val();

    $.ajax({
        type: "POST",
        url: '/Home/EditarFacturass',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ NOVEDAD: data, mensaje: mensaje }),
        dataType: "json",
        success: function (result) {

            window.location.href = result.href;
            console.log(result);



        }
    });




}

function cambiarNombreContacto() {
    
    var mensaje = $("#comment").val();

    $.ajax({
        type: "POST",
        url: '/Home/EditarFacturass',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ NOVEDAD: data, mensaje: mensaje }),
        dataType: "json",
        success: function (result) {

            window.location.href = result.href;
            console.log(result);



        }
    });


}

function limpiarFormulario() {




    var nit = $("#NIT");
    nit.val("");
    var Dv = $("#dv");
    Dv.val("");
    var direccion = $("#direccion");
    direccion.val("");
    var tipoContribuyente = $("#tipoContribuyente");
    tipoContribuyente.val("");
    var telefono = $("#telefono");
    telefono.val("");

    var celular = $("#celular");
    celular.val("");

    var ContactoCliente = $("#ContactoCliente");
    ContactoCliente.val("");

    var email = $("#email");
    email.val("");




}

function calcularTiempoTotal() {




    // var HorasAuditoria = parseFloat($("#HorasAuditoria").val());

    var Sistema = parseFloat($("#HorasSistemas").val());

    console.log(Sistema);

    var Impuestos = parseFloat($("#HorasImpuestos").val());
    var Legal = parseFloat($("#HorasLegales").val());
    var ifrs = parseFloat($("#HorasIFRS").val());
    var auditor = parseFloat($("#HorasAuditoria").val());



    var totalTiempo = Sistema + Impuestos + Legal + ifrs + auditor;


    var totalHoras = $("#TotalHoras");

    totalHoras.val(totalTiempo);



}
function sumatoria(value, id) {


    console.clear();
    console.log(value);

    var vaueAuditoria = $("#vaueAuditoria");
    var RsultTotal = $("#RsultTotal");
    var valueEx = $("#valueEx");
    var rsult = $.isNumeric(value);
    var result = 0;
    var resultExp = 0;
    var rsultadoF = 0;
    var rsultadoE = 0;


    if (rsult == false) {

        rsult = NaN;

        var idModificar = $("#" + id + "");
        idModificar.addClass("has-error");

    } else {


        var idModificar = $("#" + id + "");
        idModificar.removeClass("has-error");

        var Aauditoria = $("#Aauditoria").val();
        var Ajunior = $("#Ajunior").val();
        var ASemisenior = $("#ASemisenior").val();
        var ASenior = $("#ASenior").val();
        var Sjunior = $("#Sjunior").val();
        var Ssemisenior = $("#Ssemisenior").val();
        var Ssenior = $("#Ssenior").val();
        var GJunior = $("#GJunior").val();
        var GSemi = $("#GSemi").val();
        var GSenior = $("#GSenior").val();
        var DJunior = $("#DJunior").val();
        var DSemi = $("#DSemi").val();
        var DSenior = $("#DSenior").val();
        var AuditorTI = $("#AuditorTI").val();
        var supervisorTI = $("#supervisorTI").val();
        var GerenteTI = $("#GerenteTI").val();
        var AuditorImpuesto = $("#AuditorImpuesto").val();
        var Gerenteimpuestos = $("#Gerenteimpuestos").val();
        var GJuridico = $("#GJuridico").val();
        var AsesorJuridico = $("#AsesorJuridico").val();


        result = parseFloat(Aauditoria) + parseFloat(Ajunior) + parseFloat(ASemisenior) + parseFloat(ASenior) + parseFloat(Sjunior) + parseFloat(Ssemisenior) + parseFloat(Ssenior) + parseFloat(GJunior) + parseFloat(GSemi) + parseFloat(GSenior) + parseFloat(DJunior) + parseFloat(DSemi) + parseFloat(DSenior);
        resultExp = parseFloat(Gerenteimpuestos) + parseFloat(AuditorTI) + parseFloat(supervisorTI) + parseFloat(GerenteTI) + parseFloat(AuditorImpuesto) + parseFloat(GJuridico) + parseFloat(AsesorJuridico);



        if (isNaN(result) || isNaN(resultExp)) {

            var rs = ($.isNumeric(value));

            if (rs == false) {

                var idModificar = $("#" + id + "");
                idModificar.addClass("has-error");

            }

            rsult = NaN;
        }



    }



    if (isNaN(rsult) || isNaN(resultExp)) {

        result = "No se puede realizar la Suma Por favor revise los campos en rojo ";
        resultExp = "No se puede realizar la Suma Por favor revise los campos en rojo ";

        vaueAuditoria.text(result);
        vaueAuditoria.val(result);

    } else {


        RsultTotal
        RsultTotal = result;




        valueEx.val(resultExp);
        valueEx.text(resultExp);
        vaueAuditoria.text(RsultTotal);
        vaueAuditoria.val(RsultTotal);


        var RsultTotales = $("#RsultTotales");
        var Rsultados = parseFloat(resultExp) + parseFloat(RsultTotal);
        console.log(Rsultados);
        RsultTotales.val(Rsultados);
        RsultTotales.text(Rsultados);

    }




    rsult = true;





}
function sumatoriaAprox(value, id) {

    console.log(value);

    var vaueAuditoria = $("#vaueAuditoriaAprox");
    var RsultTotal = $("#RsultTotalAprox");
    var valueEx = $("#valueExAprox");
    var rsult = $.isNumeric(value);
    var result = 0;
    var resultExp = 0;
    var rsultadoF = 0;
    var rsultadoE = 0;


    if (rsult == false) {

        rsult = NaN;

        var idModificar = $("#" + id + "");
        idModificar.addClass("has-error");

    } else {


        var idModificar = $("#" + id + "");
        idModificar.removeClass("has-error");

        var Aauditoria = $("#AauditoriaProx").val();
        var Ajunior = $("#AjuniorAprox").val();
        var ASemisenior = $("#ASemiseniorAprox").val();
        var ASenior = $("#ASeniorAprox").val();
        var Sjunior = $("#SjuniorAprox").val();
        var Ssemisenior = $("#SsemiseniorAprox").val();
        var Ssenior = $("#SseniorAprox").val();
        var GJunior = $("#GJuniorAprox").val();
        var GSemi = $("#GSemiAprox").val();
        var GSenior = $("#GSeniorAprox").val();
        var DJunior = $("#DJuniorAprox").val();
        var DSemi = $("#DSemiAprox").val();
        var DSenior = $("#DSeniorAprox").val();
        var AuditorTI = $("#AuditorTIAprox").val();
        var supervisorTI = $("#supervisorTIAprox").val();
        var GerenteTI = $("#GerenteTIAprox").val();
        var AuditorImpuesto = $("#AuditorImpuestoAprox").val();
        var GJuridico = $("#GJuridicoAprox").val();

        var GImpuesto = $("#GerenteimpuestosAprox").val();
        var AsesorJuridico = $("#AsesorJuridicoProx").val();



        result = parseFloat(Aauditoria) + parseFloat(Ajunior) + parseFloat(ASemisenior) + parseFloat(ASenior) + parseFloat(Sjunior) + parseFloat(Ssemisenior) + parseFloat(Ssenior) + parseFloat(GJunior) + parseFloat(GSemi) + parseFloat(GSenior) + parseFloat(DJunior) + parseFloat(DSemi) + parseFloat(DSenior);
        resultExp = parseFloat(AsesorJuridico) + parseFloat(GImpuesto) + parseFloat(AuditorTI) + parseFloat(supervisorTI) + parseFloat(GerenteTI) + parseFloat(AuditorImpuesto) + parseFloat(GJuridico);



        if (isNaN(result) || isNaN(resultExp)) {

            var rs = ($.isNumeric(value));

            if (rs == false) {

                var idModificar = $("#" + id + "");
                idModificar.addClass("has-error");

            }

            rsult = NaN;
        }



    }



    if (isNaN(rsult) || isNaN(resultExp)) {

        result = "No se puede realizar la Suma Por favor revise los campos en rojo ";
        resultExp = "No se puede realizar la Suma Por favor revise los campos en rojo ";

        vaueAuditoria.text(result);
        vaueAuditoria.val(result);

    } else {



        RsultTotal = result;


        valueEx.val(resultExp);
        valueEx.text(resultExp);
        vaueAuditoria.text(RsultTotal);
        vaueAuditoria.val(RsultTotal);

        var RsultTotales = $("#RsultTotalAprox");
        var Rsultados = parseFloat(resultExp) + parseFloat(RsultTotal);
        console.log(Rsultados);
        RsultTotales.val(Rsultados);
        RsultTotales.text(Rsultados);


    }




    rsult = true;





}

function sumatoriaOut(value, id) {

    var OutGerenteval = $("#OutGerenteval").val();
    var outSupervisorVal = $("#outSupervisorVal").val();
    var outcordinadorVal = $("#outcordinadorVal").val();
    var outAnalistaVal = $("#outAnalistaVal").val();
    var outAuxiliarVal = $("#outAuxiliarVal").val();
    var RsultTotalesOut = $("#RsultTotalesOut");
    var result = parseFloat(OutGerenteval) + parseFloat(outSupervisorVal) + parseFloat(outcordinadorVal) + parseFloat(outAnalistaVal) + parseFloat(outAuxiliarVal);
    RsultTotalesOut.val(result);
    RsultTotalesOut.text(result);





}
function sumatoriaOutProx(value, id) {

    var OutGerenteval = $("#OutGerentevalAprox").val();
    var outSupervisorVal = $("#outSupervisorValProx").val();
    var outcordinadorVal = $("#outcordinadorValProx").val();
    var outAnalistaVal = $("#outAnalistaValProx").val();
    var outAuxiliarVal = $("#outAuxiliarValProx").val();
    var RsultTotalesOut = $("#RsultTotalAproxes");



    var result = parseFloat(OutGerenteval) + parseFloat(outSupervisorVal) + parseFloat(outcordinadorVal) + parseFloat(outAnalistaVal) + parseFloat(outAuxiliarVal);
    //   alert(result);
    RsultTotalesOut.val(result);
    RsultTotalesOut.text(result);





}



