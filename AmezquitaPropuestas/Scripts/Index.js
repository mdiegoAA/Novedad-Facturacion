

var idFacturaAux="";
var idAux = 0;

var idAraAux = "";

var idFacturaModificarAux = "";
var AreaModificarAux = "";
var cargoAux = "";
var auxEliminarFacturaId = "";
var auxFacturaControl = "";



$(document).ready(function () {

    var GuardarNovedadFactura = $("#GuardarNovedadFactura");
    GuardarNovedadFactura.click(function () {

        guardarControlFacturacion();


    });

    var EliminarFacturaF = $("#EliminarFacturaF");
    EliminarFacturaF.click(function () {

        EliminarFacturaCliente();


    });

    var commentRechazarFactura = $("#commentRechazarFactura");
    commentRechazarFactura.click(function () {

        RechazarFacturaFinal();

    });


    var btnAprobacionContabilidad = $("#btnAprobacionContabilidad");
    btnAprobacionContabilidad.click(function () {

        AprobarFacturaContabilidad();

    });

    var btnAprobacionDirector = $("#btnAprobacionDirector");
    btnAprobacionDirector.click(function () {

        AprobarFacturaDirector();

    });


    var comenteAprobacionAsistenteGeneral = $("#comenteAprobacionAsistenteGeneral");
    comenteAprobacionAsistenteGeneral.click(function () {

        AprobarFacturaAsistenteGerenciaGeneral();

    });


    var btnGerenciaGeneral = $("#btnGerenciaGeneral");
    btnGerenciaGeneral.click(function () {

        AprobarFacturaGerenciaGeneral();

    });

    var btnModificar = $("#btnModificar");
    btnModificar.click(function () {

        modificarFinal();

    });

    var HorasIMPUESTOSEditar = $("#HorasIMPUESTOSEditar");
    HorasIMPUESTOSEditar.blur(function () {
        calcularHorasModificar();
    });

    var HorasifrsEditar = $("#HorasifrsEditar");
    HorasifrsEditar.blur(function () {
        calcularHorasModificar();

    });

    var HorasLegalesEditar = $("#HorasLegalesEditar");
    HorasLegalesEditar.blur(function () {

        calcularHorasModificar();
    });

    var HorasServicioEditar = $("#HorasServicioEditar");
    HorasServicioEditar.blur(function () {

        calcularHorasModificar();

    });

    var HorasTiEditar = $("#HorasTiEditar");
    HorasTiEditar.blur(function () {

        calcularHorasModificar();

    });

    var modificarHorasDiv = $("#modificarHorasDiv");
    modificarHorasDiv.click(function () {



    });

    var ModificarHoras = $("#ModificarHoras");
    ModificarHoras.click(function () {

        modificacionHorasXAreas();

    });
    var AprobarFacturaArea = $("#commentAprobacionArea");
    AprobarFacturaArea.click(function () {

      
        var mensaje = $("#commentAprobacionAreaTxt").val();
    
        $.ajax({
            type: "POST",
            url: '/Home/aprobarArea',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ idFactura: idFacturaAux, mensaje: mensaje, area: idAraAux }),
            dataType: "json",
            success: function (result) {


                var modalAprobacion = $("#modalAprobacionArea");
                modalAprobacion.modal("hide");

                location.reload();
            }, error: function (response) {

         

                 location.reload();
        }
        });



    });



    var guardarFacturaF = $("#guardarFacturaF");


    guardarFacturaF.click(function () {



        var mensaje = $("#commentAprobacion").val();

        $.ajax({
            type: "POST",
            url: '/Home/actualizarEstado',
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify({ idFactura: idFacturaAux, mensaje: mensaje }),
            dataType: "json",
            success: function (result) {

                //  console.log(result);
                var p = $("#item_" + idAux);
                var j = $("#item_" + idAux).html();

                var temp = "<tr>";
                temp += j;
                temp += "</tr>";

                console.log(j);
                var TableAprobado = $("#TableAprobado");
                TableAprobado.append(temp);

                p.empty();

                var modalAprobacion = $("#modalAprobacion");
                modalAprobacion.modal("hide");

                location.reload();


            },
            error: function (response) {

                alert("p");

                //  location.reload();
            }
        });




    });


 

    $("#complete").click(function () {
        alert("Pruebas");
    });


});

function EliminarFacturaCliente() {

    $.ajax({
        type: "POST",
        url: '/Home/EliminarFactura',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ idFactura: auxEliminarFacturaId}),
        dataType: "json",
        success: function (result) {
            location.reload();
        }, error: function (response) {



            location.reload();
        }
        
         
        
       

    })

}

function limpiar() {

    var fecha = $("#fecha");
    var Nfactura = $("#Nfactura");
    var Observaciones = $("#Observaciones");
    var ValorFacturado = $("#ValorFacturado");

    $("#Nfactura").val('');
    $("#Observaciones").val('');
    $("#ValorFacturado").val('');
  
}


function EliminarFactura(idFacturas, nombreCliente) {

    var EliminarFacturaText = $("#EliminarFacturaText");
    EliminarFacturaText.text("Se va eliminar la factura del cliente " + nombreCliente);

   // alert(nombreCliente);
    var modalEliminar = $("#modalEliminar");
    modalEliminar.modal("show");
    auxEliminarFacturaId = idFacturas;

   

}

function guardarControlFacturacion() {

    var fecha = $("#fecha").val();
    var Nfactura = $("#Nfactura").val();
    var Observaciones = $("#Observaciones").val();
    var ValorFacturado = $("#ValorFacturado").val();

    var data =
         {

             idFacturaNovedad: auxFacturaControl,
             periodo: fecha,
             NumeroFactura: Nfactura,
             obesrvaciones: Observaciones,
             ValorFacturado: ValorFacturado


         }
    $.ajax({
        type: "POST",
        url: '/Home/GuardarControlFactura',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(data),
        dataType: "json",
        success: function (result) {
          
            var temp = "";
      
            temp += "<tr class='table-active'>";
            temp += "<td>" + fecha + "</td>";
            temp += "<td>" + Nfactura + "</td>";
            temp += "<td>" + Observaciones + "</td>";
            temp += "<td>" + ValorFacturado + "</td>";
            temp += "</tr>";
            

            var RegistroControlFacturacion = $("#RegistroControlFacturacion");
            RegistroControlFacturacion.prepend(temp);

            limpiar();
         


        }
    });
   



}




function AprobarFacturaDirector () {


    var mensaje = $("#TxtAprobacionDirector").val();
 


    $.ajax({
        type: "POST",
        url: '/Home/AprobacionDirector',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ idFactura: idFacturaAux, mensaje: mensaje }),
        dataType: "json",
        success: function (result) {


            var modalAprobacion = $("#modalAprobacionArea");
            modalAprobacion.modal("hide");

            location.reload();
        }, error: function (response) {



            location.reload();
        }
    });



};

function AprobarFacturaContabilidad() {

   
    var mensaje = $("#TxtBtnAprobacionContabilidad").val();

    $.ajax({
        type: "POST",
        url: '/Home/AprobacionContabilidad',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ idFactura: idFacturaAux, mensaje: mensaje, area: idAraAux }),
        dataType: "json",
        success: function (result) {


            var modalAprobacion = $("#modalAprobacionArea");
            modalAprobacion.modal("hide");

            location.reload();
        }, error: function (response) {


            alert(response);
            location.reload();
        }
    });



};

function AprobarFacturaAsistenteGerenciaGeneral() {


    var mensaje = $("#commentAprobacionAsistenteGeneralAreaTxt").val();

    $.ajax({
        type: "POST",
        url: '/Home/AprobacionAsistenteGerenteGeneral',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ idFactura: idFacturaAux, mensaje: mensaje }),
        dataType: "json",
        success: function (result) {




            location.reload();
        }, error: function (response) {



            location.reload();
        }
    });



};


function AprobarFacturaGerenciaGeneral() {


    var mensaje = $("#TxtBtnAprobacion").val();

    $.ajax({
        type: "POST",
        url: '/Home/AprobacionGerenteGeneral',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ idFactura: idFacturaAux, mensaje: mensaje}),
        dataType: "json",
        success: function (result) {


        

            location.reload();
        }, error: function (response) {



            location.reload();
        }
    });



};

function RechazarFactura(idFactura, contador, cargo) {

    idFacturaAux = idFactura;
    cargoAux = cargo;

    var RechazarFactura = $("#ModalRechazarFactura");
    RechazarFactura.modal("show");



}



function EditarFactura(HorasTI, HorasImpuestos, HorasIFRS, HorasLegales, TotalHoras, HorasAuditoria, idFactura) {

    idFacturaModificarAux = idFactura;

    var HorasTiEditar = $("#HorasTiEditar");
    HorasTiEditar.val(HorasTI);

    var TotalHorasEditar = $("#TotalHorasEditar");
    TotalHorasEditar.val(TotalHoras);


    var HorasServicioEditar = $("#HorasServicioEditar");
    HorasServicioEditar.val(HorasAuditoria);

    var HorasLegalesEditar = $("#HorasLegalesEditar");
    HorasLegalesEditar.val(HorasLegales);

    var HorasifrsEditar = $("#HorasifrsEditar");
    HorasifrsEditar.val(HorasIFRS);



    var HorasIMPUESTOSEditar = $("#HorasIMPUESTOSEditar");
    HorasIMPUESTOSEditar.val(HorasImpuestos);

    var modificarHorasDiv = $("#modificarHorasDiv");
    modificarHorasDiv.modal("show");


}


function modificacionHorasXAreas() {

    var mensaje = $("#txtModificacion").val();
    var InputHorasMoficar =$("#InputHorasMoficar").val();
    
    $.ajax({
        type: "POST",
        url: '/Home/ActualizarTiemporArea',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ idFactura: idFacturaModificarAux, mensaje: mensaje, area: AreaModificarAux, Tiempo: InputHorasMoficar }),
        dataType: "json",
        success: function (result) {
        }, error: function (response) {
            location.reload();
        }
    });

    

}

function pruebaModificacionPrueba(servicio, horas, area, facturaId) {


    AreaModificarAux = area;
    idFacturaModificarAux = facturaId;



    var aux = horas;

    var InputHorasMoficar = $("#InputHorasMoficar");
    InputHorasMoficar.val(horas);
    var tituloModal = $("#tituloModal");
    tituloModal.text("Modificar horas del servicio " + servicio);
  
    
    var modalModificarHoras = $("#modalModificarHoras");
    modalModificarHoras.modal("show");

}

function unLoad() {

    
    var form = $("#form");
    form.removeClass("block-loading");

}

function load() {
    var form = $("#form");
  //  var form = $(this).closest("form");
   

   
    var block = $('<div class="block-loading" />');
    form.prepend(block);

    // En caso de que haya habido un mensaje de alerta
 

    // Para los formularios que tengan CKupdate
  
}




function AprobarFactura(idFactura, id, area) {

    idFacturaAux = idFactura;
    idAraAux = area;

    var modalAprobacion = $("#modalAprobacionArea");
    modalAprobacion.modal("show");

}
function modificarEstado(idFactura, id) {

  //  alert(idFactura);

    idFacturaAux = idFactura;
    idAux = id;

    var modalAprobacion = $("#modalAprobacion");
    modalAprobacion.modal("show");
}


function AprobacionDirector(idFactura, id) {

  

    idFacturaAux = idFactura;
    idAux = id;

    var modalAprobacion = $("#modalAprobacinDirector");
    modalAprobacion.modal("show");
}

function AprobacionContabilidad(idFactura, id) {



    idFacturaAux = idFactura;
    idAux = id;

    var modalAprobacion = $("#modalAprobacinContabilidad");
    modalAprobacion.modal("show");
}


function AprobacionGerenciaGeneral(idFactura, id) {

   

    idFacturaAux = idFactura;
    idAux = id;

    var modalAprobacion = $("#modalGerenciaGeneral");
    modalAprobacion.modal("show");
}

function AprobacionAsistenteGerenciaGeneral(idFactura, id) {



    idFacturaAux = idFactura;
    idAux = id;

    var modalAprobacion = $("#AprobacionAsistenteGenereal");
    modalAprobacion.modal("show");
}



function calcularHorasModificar() {

    var HorasTiEditar = $("#HorasTiEditar").val();
    var TotalHorasEditar = $("#TotalHorasEditar");
    var HorasServicioEditar = $("#HorasServicioEditar").val();
    var HorasLegalesEditar = $("#HorasLegalesEditar").val();
    var HorasIMPUESTOSEditar = $("#HorasIMPUESTOSEditar").val();
    var HorasifrsEditar = $("#HorasifrsEditar").val();

    var totalHoras = parseFloat(HorasTiEditar) + parseFloat(HorasServicioEditar) + parseFloat(HorasLegalesEditar) + parseFloat(HorasIMPUESTOSEditar) + parseFloat(HorasifrsEditar);
    TotalHorasEditar.val(totalHoras);

    
   // alert("fllffg");

}

function modalMensajes(Idfactura) {



  
    var data =
      {

          idFactur: Idfactura

      }
    $.ajax({
        type: "POST",
        url: '/Home/obtenerMensajes',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(data),
        dataType: "json",
        success: function (result) {

            var Mensajes = $("#Mensajes");

            Mensajes.empty();

            console.log(result.length);
         
            var temp = "";


            for (var i = 0; i <= result.length -1 ; i++) {

             
                temp += "<div class='media'>";
                temp += "<div class='media-left'>";
                temp += "<img src='../img/img_avatar1.png' class='media-object' style='width:45px'>";
                temp += "</div>";
                temp += "<div class='media-body'>";
                temp += "<h4 class='media-heading'>" + result[i].mensajeSistema +"  " + result[i].Usuario + " <small><i>" + result[i].fecha + "</i></small></h4>";
                temp += "<p>" + result[i].mensajeUsuario + "</p>";
                temp += "<hr/>";
                temp += "</div>";
                temp += "</div>";

            }
         



            Mensajes.append(temp);


            console.log(result);
        }
    });

    var modalMensajesText = $("#modalMensajesText");
    modalMensajesText.modal("show");

}

function modificarFinal() {
    
    var HorasTiEditar = $("#HorasTiEditar").val();
    var TotalHorasEditar = $("#TotalHorasEditar").val();
    var HorasServicioEditar = $("#HorasServicioEditar").val();
    var HorasLegalesEditar = $("#HorasLegalesEditar").val();
    var HorasIMPUESTOSEditar = $("#HorasIMPUESTOSEditar").val();
    var HorasifrsEditar = $("#HorasifrsEditar").val();


    var data = {

        HorasTiEditar : HorasTiEditar,
        TotalHorasEditar: TotalHorasEditar,
        HorasServicioEditar: HorasServicioEditar,
        HorasLegalesEditar: HorasLegalesEditar,
        HorasIMPUESTOSEditar: HorasIMPUESTOSEditar,
        HorasifrsEditar: HorasifrsEditar,
        idfactura:idFacturaModificarAux


    }

    $.ajax({
        type: "POST",
        url: '/Home/ModificarTiempo',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(data),
        dataType: "json",
        success: function (result) {


        }, error: function (response) {
            location.reload();
        }
    });

  

}


function RechazarFacturaFinal() {


    var mensaje = $("#commentRechazarAreaTxt").val();
 

    $.ajax({
        type: "POST",
        url: '/Home/AprobacionRechazarFactura',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify({ idFactura: idFacturaAux, mensaje: mensaje, cargo: cargoAux }),
        dataType: "json",
        success: function (result) {

            location.reload();
        }, error: function (response) {
            
        }
    });



}

function ControlFacturacion(idFactura , cliente , servicios ) {
    var clienteId = $("#clienteId");
    clienteId.text(cliente);

    auxFacturaControl = idFactura;

    obtenerListadoControlFacturacion(auxFacturaControl);


    var servicio = $("#servicio");
    servicio.text(servicios);
 
    var modalContabilidad = $("#modalContabilidad");
    modalContabilidad.modal("show");



}

function obtenerListadoControlFacturacion(auxFacturaControl) {

    var data = {

        idFactura: auxFacturaControl
      


    }

    $.ajax({
        type: "POST",
        url: '/Home/ListadoControlFacturacion',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(data),
        dataType: "json",
        success: function (result) {

            console.log(result.length);

            var temp = "";

         
            for (var i = 0; i < result.length; i++) {
                temp += "<tr>";
                temp += "<td>" + result[i].periodo + "</td>";
                temp += "<td>" + result[i].NumeroFactura + "</td>";
                temp += "<td>" + result[i].obesrvaciones + "</td>";
                temp += "<td>" + result[i].ValorFacturado + "</td>";
                temp += "</tr>";


            }

            console.log(temp);

            var RegistroControlFacturacion = $("#RegistroControlFacturacion");
            RegistroControlFacturacion.empty();
            RegistroControlFacturacion.append(temp);


        }, error: function (response) {
            alert("Error");
        }
    });
    



}


