﻿ns('Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion');

Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Controller = function (opts) {
    var base = this;
    base.Ini = function () {
        base.Control.Modelo = Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Models.FormularioCargaAdjuntoContratoResolucion;
        base.Control.BtnAceptarFile().on("click", base.Event.BtnAceptarFileClick);
        base.Control.BtnCerrarCargaArchivoAdjunto().on("click", base.Event.BtnCancelarClick);
        base.Control.ExtensionFile = "pdf";
        base.Function.CrearGrid();

        new Pe.GMD.UI.Web.Components.Calendar({
            inputFrom: base.Control.TxtFechaResolucion()
        });

        base.Event.BtnBuscarClick();

        base.Control.TxtFechaResolucion().datepicker({ dateFormat: 'dd/mm/yy' });

        base.Control.FileArchivoCargar().on("change", function (e) {

        base.Event.FileArchivoEvidenciaChange(e)
        });

        setTimeout(function () {
            base.Control.DialogFormularioCarga.setPosition(['center', 'center']);
        }, 200)

    };
    base.Control = {
        Controles: null,
        DialogFormularioCarga: null,
        Mensaje: new Pe.GMD.UI.Web.Components.Message(),
        FileArchivoCargar: function () { return $('#MyFile'); },
        BtnAceptarFile: function () { return $('#btnAceptarCargaArchivoAdjunto'); },
        TxtUploadFile: function () { return $('#uploadFile'); },
        BtnCerrarCargaArchivoAdjunto: function () { return $('#btnCerrarCargaArchivoAdjunto'); },
        TxtFechaResolucion: function () { return $('#txtFechaResolucion'); },
        GrdResultado: null,
        BtnTargetShow: null,
        ValidateExt: 'pdf',
        ExtensionFile: 'pdf',
        Modelo: null
    };
    base.Show = function (data) {
        base.Control.DialogFormularioCarga = new Pe.GMD.UI.Web.Components.Dialog({
            title: data.request.Descripcion,
            width: '60%',
            close: function () {
                base.Control.DialogFormularioCarga.destroy();
            }
        });

        base.Control.DialogFormularioCarga.getAjaxContent({
            action: Pe.Stracon.SGC.Presentacion.Contractual.Contrato.Actions.FormularioCargaAdjuntoResolucion,
            data: {
                request: data.request,
                controles: data.controles
            },
            onSuccess: function () {
                base.Ini();
            }
        });
    };
    base.Event = {
        BtnBuscarClick: function () {
            'use strict'
            var filtro = {
                CodigoContrato: base.Control.Modelo.Contrato.CodigoContrato
            }
            base.Control.GrdResultado.Load(filtro);
        },
        BtnCancelarClick: function () {
            base.Control.DialogFormularioCarga.close();
        },
        BtnGridDeleteClick: function (row, data) {
            'use strict'
            base.Control.Mensaje.Confirmation({
                title: Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Resources.TituloEliminar,
                message: Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Resources.ConfirmacionEliminacionRegistro,
                onAccept: function () {
                    base.Ajax.AjaxEliminarDocumentoAdjunto.data = {
                        CodigoContratoDocumentoAdjuntoResolucion: data.CodigoContratoDocumentoAdjuntoResolucion,
                    };
                    base.Ajax.AjaxEliminarDocumentoAdjunto.submit();
                }
            });
        },
        BtnGridDescargarClick: function (row, data) {
            'use strict'

            var vrParam = {
                CodigoContratoDocumentoAdjuntoResolucion: data.CodigoContratoDocumentoAdjuntoResolucion,
                NombreArchivo: data.NombreArchivo,
                CodigoArchivo: data.CodigoArchivo,
                RutaArchivoSharePoint: data.RutaArchivoSharePoint,
            };

            Pe.GMD.UI.Web.Components.Util.RedirectPost(Pe.Stracon.SGC.Presentacion.Contractual.Contrato.Actions.DescargarArchivoAdjuntoResolucion, vrParam);
        },
        BtnTargetShowClick: function () {
            base.MostrarModalCargarArchivo();
        },
        BtnAceptarFileClick: function () {

            if (base.Control.TxtUploadFile().val() == "" || base.Control.TxtUploadFile().val() == null) {
                base.Control.Mensaje.Warning({ title: base.Control.LblTitleModal, message: Pe.Stracon.SGC.Presentacion.Base.MensajeGenerico.MsjValidaEligeArchivo });
                return;
            }

            if (base.Control.TxtFechaResolucion().val() == "" || base.Control.TxtFechaResolucion().val() == null) {
                base.Control.Mensaje.Warning({ title: base.Control.LblTitleModal, message: Pe.Stracon.SGC.Presentacion.Base.MensajeGenerico.DebeSeleccionarFechaResolucion });
                return;
            }

            var validacion = base.Control.TxtUploadFile().val().indexOf(',');

            if (validacion >= 0) {
                base.Control.Mensaje.Warning({ title: base.Control.LblTitleModal, message: 'El nombre del Archivo a Adjuntar no debe contener comas ' });
                return;
            }

            var Frmdata = new FormData();
            var seccionesRutaArchivo = base.Control.TxtUploadFile().val().split("\\");
            var nombreArchivo = seccionesRutaArchivo[seccionesRutaArchivo.length - 1];

            Frmdata.append("CodigoContrato", base.Control.Modelo.Contrato.CodigoContrato);
            Frmdata.append("NombreArchivo", nombreArchivo);
            Frmdata.append("ArchivoAdjunto", base.Control.FileArchivoCargar()[0].files[0]);
            Frmdata.append("FechaResolucionString", base.Control.TxtFechaResolucion().val());
            Frmdata.append("ValidacionResolucion", base.Control.Modelo.Contrato.ValidacionResolucion);
            Frmdata.append("FechaFinVigenciaString", base.Control.Modelo.Contrato.FechaFinVigenciaString);

            base.Ajax.AjaxGrabarDocumentoAdjunto.data = Frmdata;
            base.Ajax.AjaxGrabarDocumentoAdjunto.submit();
        },
        FileArchivoEvidenciaChange: function (data) {
            if (base.Control.ValidateExt) {
                if (base.Control.ExtensionFile != null) {
                    if (Pe.GMD.UI.Web.Components.Util.Right(data.currentTarget.files[0].name, 3).toLowerCase() != base.Control.ExtensionFile.toLowerCase()) {
                        base.Control.Mensaje.Warning({ title: base.Control.LblTitleModal, message: Pe.Stracon.SGC.Presentacion.Base.MensajeGenerico.MsjValidaExtensionArchivo + " (" + base.Control.ExtensionFile + ")" });
                        base.Control.TxtUploadFile().val("");
                        return;
                    }
                }
            }
            base.Control.TxtUploadFile().val(data.currentTarget.files[0].name);
        },
        AjaxGrabarDocumentoAdjuntoSuccess: function (data) {
            'use strict'
            switch (data.Result) {
                case "2":
                    base.Control.Mensaje.Warning({ message: Pe.Stracon.SGC.Presentacion.Recursos.Validacion.ValidarRegistroAdjunto });
                    base.Control.DialogFormularioCarga.close();
                    break;
                default:
                    base.Control.Mensaje.Information({ message: Pe.Stracon.SGC.Presentacion.Recursos.Validacion.EtiquetaConfirmacion });
                    base.Event.BtnBuscarClick();
                    base.Control.TxtUploadFile().val('');
                    break;
            }
        },
        AjaxEliminarDocumentoAdjuntoSuccess: function (data) {
            'use strict'
            switch (data.Result) {
                case "2":
                    base.Control.Mensaje.Warning({ message: Pe.Stracon.SGC.Presentacion.Recursos.Validacion.ValidarEliminacionAdjunto });
                    break;
                default:
                    base.Control.Mensaje.Information({ message: Pe.Stracon.SGC.Presentacion.Recursos.Validacion.EtiquetaConfirmacion });
                    base.Event.BtnBuscarClick();
                    break;
            }
        },
        BtnGridDeleteAdjuntoValidate: function (data, type, full) {
            if (base.Control.Modelo.ControlPermisos.ControlTotal) {
                if (full.UsuarioCreacion.toLowerCase() == base.Control.Modelo.UsuarioSession.toLowerCase() && (base.Control.Modelo.Contrato.CodigoEstadoContrato == Pe.Stracon.SGC.Presentacion.Contractual.Contrato.Enumerados.EstadoContrato.Edicion) || (base.Control.Modelo.Contrato.CodigoEstadoContrato == Pe.Stracon.SGC.Presentacion.Contractual.Contrato.Enumerados.EstadoContrato.Aprobacion)) {
                    return true;
                }
                else {
                    return false;
                }
            } else {
                return false;
            }
        },
    };
    base.Ajax = {
        AjaxGrabarDocumentoAdjunto: new Pe.GMD.UI.Web.Components.Ajax({
            action: Pe.Stracon.SGC.Presentacion.Contractual.Contrato.Actions.RegistrarArchivoAdjuntoResolucion,
            hasFile: true,
            autoSubmit: false,
            contentType: false,
            processData: false,
            onSuccess: base.Event.AjaxGrabarDocumentoAdjuntoSuccess
        }),
        AjaxEliminarDocumentoAdjunto: new Pe.GMD.UI.Web.Components.Ajax({
            action: Pe.Stracon.SGC.Presentacion.Contractual.Contrato.Actions.EliminarArchivoAdjunto,
            autoSubmit: false,
            onSuccess: base.Event.AjaxEliminarDocumentoAdjuntoSuccess
        })
    };
    base.Function = {
        CrearGrid: function () {
            var columns = new Array();
            columns.push({
                data: 'NombreArchivo',
                title: Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Resources.GridNombreArchivo,
                width: "50%"
            });
            columns.push({
                data: 'UsuarioCreacion',
                title: Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Resources.GridUsuarioResponsable,
                width: "40%"
            });
            columns.push({
                "data": "", "title": Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Resources.GridAcciones,
                "class": "controls",
                width: "10%",
                actionButtons: [
                    { type: Pe.GMD.UI.Web.Components.GridAction.DescargarAdjunto, event: { on: 'click', callBack: base.Event.BtnGridDescargarClick } }//,
                    //{ type: Pe.GMD.UI.Web.Components.GridAction.Delete, validateRender: base.Event.BtnGridDeleteAdjuntoValidate, event: { on: 'click', callBack: base.Event.BtnGridDeleteClick } }
                ]
            });

            base.Control.GrdResultado = new Pe.GMD.UI.Web.Components.Grid({
                renderTo: 'divGrdResultAdjuntos',
                columns: columns,
                hasSelectionRows: false,
                proxy: {
                    url: Pe.Stracon.SGC.Presentacion.Contractual.ArchivoAdjuntoContratoResolucion.Actions.BuscarArchivoAdjuntoResolucion,
                    source: 'Result'
                }
            });
        }
    };
}