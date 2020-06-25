using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using SupplyChain.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace PCP.Client.Shared.OperaStock
{
    public class ModalExigeSerieLoteDespachoBase: ComponentBase
    {
        /// <summary>
        /// Datos del tipo Stock para matchear con el modelo a validar
        /// </summary>
        [Parameter] public Stock ItemStock { get; set; } = new Stock();
        /// <summary>
        /// Mostar o esconder Modal
        /// </summary>
        [Parameter] public bool PopupVisible {get; set;} = false;
        [Parameter] public bool ExigeDespacho { get; set; } = false;
        [Parameter] public bool ExigeSerie { get; set; } = false;
        [Parameter] public bool ExigeLote { get; set; } = false;

        /* public class FormEditContext
        {
            public FormEditContext(Producto producto)
            {
               
            }
            string CodigoProducto { get; set; }
            public bool IsNewRow { get; set; }
            public string Despacho { get; set; } = "";
            public string Serie { get; set; } = "";
            public string Lote { get; set; } = "";
            public Action StateHasChanged { get; set; }
        } */

        protected Stock Modelo = new Stock();
        protected string ModeloSerialize = "";
        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            Modelo = ItemStock;
            if (firstRender)
            {
                Console.WriteLine("1er renderizado");
                Modelo = ItemStock;
                await InvokeAsync(StateHasChanged);
            }
            
        }

        protected async Task SerializarModelo()
        {
            ModeloSerialize = JsonSerializer.Serialize(Modelo);
            await InvokeAsync(StateHasChanged);
        }

        protected void HandleValidSubmit()
        {
            PopupVisible = false;
            Console.WriteLine("OnValidSubmit");
        }
        protected void HandleInvalidSubmit()
        {
            Console.WriteLine("OnInvalidSubmit");
        }
    }
}
