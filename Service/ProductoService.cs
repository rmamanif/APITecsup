using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class ProductoService
    {
        public List<Producto> Get()
        {
            using (var context = new ExampleContext())
            {
                return context.Product.Where(x => x.EstaActivo == true).ToList();
            }
        }
        public Producto GetById(int id)
        {
            using (var context = new ExampleContext())
            {
                return context.Product.Find(id);
            }
        }


        public void Insert(Producto producto)
        {
            using (var context = new ExampleContext())
            {

                producto.EstaActivo = true;
                producto.FechaCreacion = DateTime.Today;
                producto.IGV = producto.PrecioVenta * 0.18;
                context.Product.Add(producto);
                context.SaveChanges();
            }
        }

        public void Edit(Producto producto)
        {
            using (var context = new ExampleContext())
            {
                var init_prod = GetById(producto.ID);
                init_prod.Nombre = producto.Nombre;
                init_prod.Descripcion = producto.Descripcion;
                init_prod.PrecioVenta = producto.PrecioVenta;
                init_prod.EstaActivo = producto.EstaActivo;
                init_prod.IGV = producto.PrecioVenta *0.18;
                init_prod.FechaVencimiento = producto.FechaVencimiento;
                context.SaveChanges();
            }
        }

        public void Delete(Producto producto)
        {
            using (var context = new ExampleContext())
            {
                var init_prod = GetById(producto.ID);
                init_prod.EstaActivo = false;
                context.SaveChanges();
            }
        }
    }
}
