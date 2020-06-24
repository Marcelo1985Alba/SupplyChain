using SupplyChain.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCP.Server.DataAccess
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<CalendarioFestivos> CalendarioFestivos { get; set; }
        public virtual DbSet<CategoriaOperario> CategoriasOperario { get; set; }
        public virtual DbSet<Celda> Celdas { get; set; }
        public virtual DbSet<Compañia> Cias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        //public virtual DbSet<Costofab> Costofab { get; set; }
        public virtual DbSet<Deposito> Depositos { get; set; }
        //public virtual DbSet<DwStockCorregido> DwStockCorregido { get; set; }
        //public virtual DbSet<Entidades> Entidades { get; set; }
        //public virtual DbSet<EstadosCargaMaquinas> EstadosCargaMaquinas { get; set; }
        //public virtual DbSet<Form2> Form2 { get; set; }
        //public virtual DbSet<Indic> Indic { get; set; }
        //public virtual DbSet<Lineas> Lineas { get; set; }
        //public virtual DbSet<NetCargaUsuariosCeldas> NetCargaUsuariosCeldas { get; set; }
        //public virtual DbSet<NetTempAbastecimiento> NetTempAbastecimiento { get; set; }
        //public virtual DbSet<NetTempPedidos> NetTempPedidos { get; set; }
        //public virtual DbSet<PTempEstructuraProd> PTempEstructuraProd { get; set; }
        //public virtual DbSet<PTempEstructuraProduccion> PTempEstructuraProduccion { get; set; }
        //public virtual DbSet<Paises> Paises { get; set; }
        //public virtual DbSet<Paradas> Paradas { get; set; }
        //public virtual DbSet<Pedcli> Pedcli { get; set; }
        public virtual DbSet<Stock> Pedidos { get; set; }
        //public virtual DbSet<PresAnual> PresAnual { get; set; }
        //public virtual DbSet<ProTarea> ProTarea { get; set; }
        //public virtual DbSet<Procun> Procun { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        //public virtual DbSet<Prodin> Prodin { get; set; }
        public virtual DbSet<Programa> Programas { get; set; }
        //public virtual DbSet<Protab> Protab { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        //public virtual DbSet<ResumenStock> ResumenStock { get; set; }
        //public virtual DbSet<Solution> Solution { get; set; }
        //public virtual DbSet<TipoCelda> TipoCelda { get; set; }
        //public virtual DbSet<TipoMat> TipoMat { get; set; }
        //public virtual DbSet<TiposNoConf> TiposNoConf { get; set; }
        public virtual DbSet<Unidad> Unidades { get; set; }
        //public virtual DbSet<Usuarios> Usuarios { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        //public virtual DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<SupplyChain.Shared.Models.ResumenStock> ResumenStock { get; set; }
        
        
    }
}
