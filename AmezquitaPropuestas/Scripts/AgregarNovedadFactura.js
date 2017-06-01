var idClieneteAux ="";
$(document).ready(function () {

    var modificarTelefonoCliente = $("#modificarTelefonoCliente");
    modificarTelefonoCliente.click(function () {

        modificarTelefonoClientes();

    });

    var modificarDireccionCliente = $("#modificarDireccionCliente");
    modificarDireccionCliente.click(function () {
        EditarDireccionContacto();

    });

    var modificarEmailCliente = $("#modificarEmailCliente");
    modificarEmailCliente.click(function () {
        EditarEmailContacto();

    });

    var modificarCelularCliente = $("#modificarCelularCliente");
    modificarCelularCliente.click(function () {


        EditarCelularContacto();

    });

    var modificarContactoCliente = $("#modificarContactoCliente");
    modificarContactoCliente.click(function () {

        EditarNombreContacto();

    });
   
    var out = $(".out");
    out.hide();

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

    var FechaInicioFacturacion = $("#FechaInicioContrato");
   
    $(FechaInicioFacturacion).blur(function () {
       
        cambiarAños();

    });


  
    var horasAno = $("#horasAno");
    horasAno.text(n);
    var horasAnoProx = $("#horasAnoProx");
    horasAnoProx.text(h);

    var ValorCuotaInicial = $("#ValorCuotaInicial");
    var ValorCoutasMensuales = $("#ValorCoutasMensuales");
    var MesesCuotasEjecucion = $("#MesesCuotasEjecucion");
    var PorcentajeCuotaInicial = $("#PorcentajeCuotaInicial");
    PorcentajeCuotaInicial.change(function () {

        calcularValor();

    });


    MesesCuotasEjecucion.change(function () {

        calcularValor();

    });

    ValorCoutasMensuales.change(function () {

        calcularValor();

    });

    var Gravado = $("#Gravado").change(function () {

        calcularValor();

    });


    ValorCuotaInicial.change(function () {

        calcularValor();

    });
    var ManejoCuotaInicial = $("#ManejoCuotaInicial")
    ManejoCuotaInicial.change(function () {

        calcularValor();

    });

    var ValorAnualSinIva = $("#ValorAnualSinIva");
    ValorAnualSinIva.blur(function () {

        calcularValor();
    });

    var guardarFacturaF = $("#guardarFacturaF");
    guardarFacturaF.click(function () {


      


       guardarFacturas();


    });



    var guardar = $("#guardarFactura");
    guardar.click(function () {

    

        var modalFacturas = $("#modalFacturas");

        var validacion = validacionDatos();
        if (validacion == true) {

            modalFacturas.modal("show");

        } else {

            var ValidacionFactura = $("#ValidacionFactura");
            ValidacionFactura.modal("show");

        }
     

    

    });
    
    var SelectDirectoresAcargo = $("#IdDirectorCargo");
    var SelectGerenteAcargo = $("#IdGerenteCargo");

    SelectGerenteAcargo.prepend(
   $('<option  selected="selected"></option>').val(0).html("Seleccionar")
);


    var SelectAntiguedad = $("#SelectAntiguedad");
    var SelectServicio = $("#SelectServicio");
    var SelectSector = $("#SelectSector");
    SelectDirectoresAcargo.prepend(
   $('<option  selected="selected"></option>').val(0).html("Seleccionar")
);
    SelectServicio.prepend(
     $('<option  selected="selected"></option>').val(0).html("Seleccionar")
 );

    var SelectRazonSocial = $("#SelectRazonSocial");


  
    SelectRazonSocial.prepend(
      $('<option  selected="selected"></option>').val(0).html("Seleccionar")
  );
    var tipoContribuyentes = $("#tipoContribuyentes");

    tipoContribuyentes.attr('data-live-search', true);
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
    


    var SelectRazonSocial = $("#SelectRazonSocial");
    SelectRazonSocial.change(function () {

        removeclass();

        var idCliente = ($("#SelectRazonSocial option:selected").val());

        idClieneteAux = idCliente;


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
                    tipoContribuyente.val(result.TipoContribuyente);
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

 

})


function validacionDatos() {


    var rSult = true;



    var ValorAnualSinIva = $("#ValorAnualSinIva").val();
    var ValorAnualSinIvaNotificacion = $("#ValorAnualSinIvaNotificacion");

    if (ValorAnualSinIva == "") {

        rSult = false;
        ValorAnualSinIvaNotificacion.css("color", "red");
    } else {

        ValorAnualSinIvaNotificacion.css("color", "black");

    }




    var FechaInicioContratoNotificacion = $("#FechaInicioContratoNotificacion");
    var FechaInicioContrato = $("#FechaInicioContrato").val();


    var FechaFinalizacionContrato = $("#FechaFinalizacionContrato").val();
    var FechaFinalizacionContratoNotificacion = $("#FechaFinalizacionContratoNotificacion");

  //  alert(FechaInicioContrato);
    
    var tipoNovedadResult = $("#tipoNovedadResult");
    var SelectAntiguedad = $("#SelectAntiguedad").val();

    var SelectRazonSocial = $("#SelectRazonSocial").val();
    var SelectServicio = $("#SelectServicio").val();

    var SelectSector = $("#SelectSector").val();
    var SectorNoticacion = $("#SectorNoticacion");
    var TipoServicioNotificacion = $("#TipoServicioNotificacion")
    var RazonSocialValiditation = $("#RazonSocialValiditation");
    var tipoContribuyentes = $("#tipoContribuyentes").val();
    var validacionTipoContribuyente = $("#validacionTipoContribuyente");
    var FechaInicioFacturacion = $("#FechaInicioFacturacion").val();

    var IdDirectorCargo = $("#IdDirectorCargo").val();
    var IdDirectorCargoNotificacion = $("#IdDirectorCargoNotificacion");
    if (IdDirectorCargo == 0) {

        rSult = false;
        IdDirectorCargoNotificacion.css("color", "red");
    } else {

        IdDirectorCargoNotificacion.css("color", "black");

    }




    var IdGerenteCargo = $("#IdGerenteCargo").val();
    var IdGerenteCargoNotificacion = $("#IdGerenteCargoNotificacion");
    if (IdGerenteCargo == 0) {
        rSult = false;
        IdGerenteCargoNotificacion.css("color", "red");
    } else {

        IdGerenteCargoNotificacion.css("color", "black");

    }


    var FechaInicioFacturacionNotificacion = $("#FechaInicioFacturacionNotificacion");

    if (FechaInicioFacturacion == 0) {
        rSult = false;
        FechaInicioFacturacionNotificacion.css("color", "red");
    } else {

        FechaInicioFacturacionNotificacion.css("color", "black");

    }

    if (FechaFinalizacionContrato == 0) {
        rSult = false;
        FechaFinalizacionContratoNotificacion.css("color", "red");
    } else {

        FechaFinalizacionContratoNotificacion.css("color", "black");

    }


    if (FechaInicioContrato == 0) {
        rSult = false;
        FechaInicioContratoNotificacion.css("color", "red");
    } else {

        FechaInicioContratoNotificacion.css("color", "black");

    }


    if (SelectAntiguedad == 0) {
        rSult = false;
        tipoNovedadResult.css("color", "red");
    } else {

        tipoNovedadResult.css("color", "black");

    }




    if (SelectSector == 0) {
        rSult = false;
        SectorNoticacion.css("color", "red");
    } else {

        SectorNoticacion.css("color", "black");

    }

    if (SelectServicio == 0) {
        rSult = false;
        TipoServicioNotificacion.css("color", "red");
    } else {

        TipoServicioNotificacion.css("color", "black");

    }


    if (tipoContribuyentes == 0) {
        rSult = false;
        validacionTipoContribuyente.css("color", "red");
    } else {

        validacionTipoContribuyente.css("color", "black");

    }
    if (SelectRazonSocial == 0) {
        rSult = false;
      
        RazonSocialValiditation.css("color", "red");
      

    } else {

        RazonSocialValiditation.css("color", "black");

    }


    return rSult;



}

function cambiarAños() {

    var FechaInicioContrato = $("#FechaInicioContrato").val();
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
    var Gravado = $("#Gravado option:selected").val();
    var ValorCoutasMensuales = $("#ValorCoutasMensuales");




    var ManejoCuotaInicial = $("#ManejoCuotaInicial option:selected").val();
   
    if (ManejoCuotaInicial == "SI")
    {


        var PorcentajeCuotaInicial = $("#PorcentajeCuotaInicial option:selected").val();
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

         

            var sRulstG = (parseFloat(ValorAnualSinIva) +  parseFloat(ValorAnualSinIva * 0.19));
            ValorTotalContratoIncluidoIvaAnual.val(sRulstG);

        }
        if (Gravado == "NO") {

           
            
            ValorTotalContratoIncluidoIvaAnual.val(ValorAnualSinIva);

        }

      
        
      

    }
    



}

function guardarFacturas() {

    var TipoContribuyente = $("#tipoContribuyentes option:selected").val();
  
    $('#guardarFacturaF').attr("disabled", true);
    
    var fecha = $("#fecha").val();
    var ConsecutivoControlTiempos = "cons";
    var SelectRazonSocial = $("#SelectRazonSocial option:selected").val();
    var SelectServicio = $("#SelectServicio option:selected").val();
    var SelectSector = $("#SelectSector").val();

    var tipoContribuyente = $("#tipoContribuyente option:selected").val();

    var SelectAntiguedad = $("#SelectAntiguedad option:selected").val();
    var numeroContrato = $("#numeroContrato").val();
    var ValorAnualSinIva = $("#ValorAnualSinIva").val();
    var MesesCuotasEjecucion = $("#MesesCuotasEjecucion").val();
    var ManejoCuotaInicial = $("#ManejoCuotaInicial").val();
    var PorcentajeCuotaInicial = $("#PorcentajeCuotaInicial").val();
    var ValorCuotaInicial = $("#ValorCuotaInicial").val();
    var ValorCoutasMensuales = $("#ValorCoutasMensuales").val();
    var ValorMensualSinIva = $("#ValorMensualSinIva").val();
    var Gravado = $("#Gravado").val();
    var ValorTotalContratoIncluidoIvaAnual = $("#ValorTotalContratoIncluidoIvaAnual").val();
    var FechaInicioContrato = $("#FechaInicioContrato").val();
    var FechaFinalizacionContrato = $("#FechaFinalizacionContrato").val();
    var FechaInicioFacturacion = $("#FechaInicioFacturacion").val();
    var FacturacionMensual = $("#FacturacionMensual").val();
    var FechaEntregaFacturacion = $("#FechaEntregaFacturacion option:selected").val();
    var FechaEntregaFacturacion = $("#FechaEntregaFacturacion option:selected").val();
    var CondicionIniciarFacturacion = $("#CondicionIniciarFacturacion").val();
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

    var Totalauditoria = Auditorias;
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
    var vaueAuditoriaAprox = $("#vaueAuditoriaAprox").val();
    var AuditorTIAprox = $("#AuditorTIAprox").val();
    var supervisorTIAprox = $("#supervisorTIAprox").val();
    var GerenteTIAprox = $("#GerenteTIAprox").val();
    var AuditorImpuestoAprox = $("#AuditorImpuestoAprox").val();
    var GerenteimpuestosAprox = $("#GerenteimpuestosAprox").val();
    var AsesorJuridicoProx = $("#AsesorJuridicoProx").val();
    var GJuridicoAprox = $("#GJuridicoAprox").val();
    var valueEx = $("#valueExAprox").val();
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
    var RsultTotalesOut = $("#RsultTotalesOut").text();
    var RsultTotalAproxes = $("#RsultTotalAproxes").text();
    var Totaloutsourcing = parseFloat(RsultTotalesOut) + parseFloat(RsultTotalAproxes);
    var ventaCargo1 = $("#ventaCargo1").val();
    var porcentajeCargo1 = $("#porcentajeCargo1").val();


    var ventaCargo2 = $("#ventaCargo2").val();
    var porcentajeCargo2 = $("#porcentajeCargo2").val();

    var ventaCargo3 = $("#ventaCargo3").val();
    var porcentajeCargo3 = $("#porcentajeCargo3").val();

   
   




    var TotalAuditoriaTI = parseFloat(AuditorTI) + parseFloat(GerenteTI) + parseFloat(SupervisorTI) + parseFloat(AuditorTIAprox) + parseFloat(supervisorTIAprox) + parseFloat(GerenteTIAprox);
    var TotalAuditoriaJuridica = parseFloat(AsesorJurídico) + parseFloat(GerenteJurídico) + parseFloat(AsesorJuridicoProx) + parseFloat(GJuridicoAprox);
    var TotalAuditoriaImpuesto = parseFloat(Auditorimpuestos) + parseFloat(GerenteImpuestos) + parseFloat(AuditorImpuestoAprox) + parseFloat(GerenteimpuestosAprox);

    if (isNaN(Totaloutsourcing)) {

        var rSultTotalFinal = Auditorias + TotalAuditoriaTI + TotalAuditoriaJuridica + TotalAuditoriaImpuesto;

    } else {

        var rSultTotalFinal = Auditorias + TotalAuditoriaTI + TotalAuditoriaJuridica + TotalAuditoriaImpuesto + Totaloutsourcing;

    }
      


   


    var Total = rSultTotalFinal;




    var data = {

        TipoContribuyente: TipoContribuyente,
        ventaCargo1: ventaCargo1,
        ProcentajeventaCargo1: porcentajeCargo1,

        ventaCargo2: ventaCargo2,
        ProcentajeventaCargo2: porcentajeCargo2,

        ventaCargo3: ventaCargo3,
        ProcentajeventaCargo3: porcentajeCargo3,



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
        url: '/Home/guardarfACTURA',
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

        
        result =  parseFloat(Aauditoria) + parseFloat(Ajunior) + parseFloat(ASemisenior) + parseFloat(ASenior) + parseFloat(Sjunior) + parseFloat(Ssemisenior) + parseFloat(Ssenior) + parseFloat(GJunior) + parseFloat(GSemi) + parseFloat(GSenior) + parseFloat(DJunior) + parseFloat(DSemi) + parseFloat(DSenior);
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



        result =  parseFloat(Aauditoria) + parseFloat(Ajunior) + parseFloat(ASemisenior) + parseFloat(ASenior) + parseFloat(Sjunior) + parseFloat(Ssemisenior) + parseFloat(Ssenior) + parseFloat(GJunior) + parseFloat(GSemi) + parseFloat(GSenior) + parseFloat(DJunior) + parseFloat(DSemi) + parseFloat(DSenior);
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

function sumatoriaOut(value , id) {

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

function removeclass() {

    var ModificaTelefonoResult = $("#ModificaTelefonoResult");
    ModificaTelefonoResult.removeClass("has-success");

    var ModificaDireccionResult = $("#ModificaDireccionResult");
    ModificaDireccionResult.removeClass("has-success");

    var ModificaEmailResult = $("#ModificaEmailResult");
    ModificaEmailResult.removeClass("has-success");

    var ModificaCelularResult = $("#ModificaCelularResult");
    ModificaCelularResult.removeClass("has-success");

    var ModificaContatoResult = $("#ModificaContatoResult");
    ModificaContatoResult.removeClass("has-success");



}


function modificarTelefonoClientes() {


    var Telefono = $("#telefono").val();

    // alert(nombreCliente);

    $.ajax({
        type: "POST",
        url: '/Home/EditarTelefonoContato',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ Telefono: Telefono, idCliente: idClieneteAux }),
        dataType: "json",
        success: function (result) {

            var ModificaTelefonoResult = $("#ModificaTelefonoResult");
            ModificaTelefonoResult.addClass("has-success");


        }
    });


}


function EditarDireccionContacto() {


    var direccion = $("#direccion").val();

    // alert(nombreCliente);

    $.ajax({
        type: "POST",
        url: '/Home/EditarDireccionContato',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ direccion: direccion, idCliente: idClieneteAux }),
        dataType: "json",
        success: function (result) {

            var ModificaDireccionResult = $("#ModificaDireccionResult");
            ModificaDireccionResult.addClass("has-success");


        }
    });


}



function EditarEmailContacto() {


    var email = $("#email").val();

    // alert(nombreCliente);

    $.ajax({
        type: "POST",
        url: '/Home/EditarEmailContato',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ email: email, idCliente: idClieneteAux }),
        dataType: "json",
        success: function (result) {

            var ModificaEmailResult = $("#ModificaEmailResult");
            ModificaEmailResult.addClass("has-success");


        }
    });


}

function EditarCelularContacto() {


    var celular = $("#celular").val();

   // alert(nombreCliente);

    $.ajax({
        type: "POST",
        url: '/Home/EditarCelularContato',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ celularContato: celular, idCliente: idClieneteAux }),
        dataType: "json",
        success: function (result) {

            var ModificaCelularResult = $("#ModificaCelularResult");
            ModificaCelularResult.addClass("has-success");


        }
    });


}
function EditarNombreContacto() {


    var nombreCliente = $("#ContactoCliente").val();

  //  alert(nombreCliente);

    $.ajax({
        type: "POST",
        url: '/Home/EditarNombreContato',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ nombreContato: nombreCliente, idCliente: idClieneteAux }),
        dataType: "json",
        success: function (result) {

            var ModificaContatoResult = $("#ModificaContatoResult");
            ModificaContatoResult.addClass("has-success");


        }
    });


}

