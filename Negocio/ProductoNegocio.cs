using System;
using System.Collections.Generic;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT P.ID, P.Descripcion, P.CantidadTotal, P.PrecioCompra, P.PrecioVenta, P.Imagen, M.Nombre AS Marca, T.Nombre AS Tipo FROM PRODUCTOS AS P LEFT JOIN MARCAS M ON P.IDMarca = M.ID LEFT JOIN TIPOS T ON P.IDTipo = T.ID");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto
                    {
                        ID = (string)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        CantidadTotal = (int)datos.Lector["CantidadTotal"],
                        PrecioCompra = (decimal)datos.Lector["PrecioCompra"],
                        PrecioVenta = (decimal)datos.Lector["PrecioVenta"],
                        Imagen = datos.Lector["Imagen"] != DBNull.Value ? (string)datos.Lector["Imagen"] : "", // Asignación de la imagen
                        Marca = new Marca
                        {
                            Nombre = datos.Lector["Marca"] != DBNull.Value ? (string)datos.Lector["Marca"] : ""
                        },
                        Tipo = new Tipo
                        {
                            Nombre = datos.Lector["Tipo"] != DBNull.Value ? (string)datos.Lector["Tipo"] : ""
                        }
                    };
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarProducto(Producto nuevo)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {
                acceso.setearConsulta("INSERT INTO Productos (ID, Descripcion, CantidadTotal, PrecioCompra, PrecioVenta, Imagen, IDMarca, IDTipo) VALUES (@ID, @Descripcion, @CantidadTotal, @PrecioCompra, @PrecioVenta, @Imagen, @IDMarca, @IDTipo)");

                acceso.setearParametro("@ID", nuevo.ID);
                acceso.setearParametro("@Descripcion", nuevo.Descripcion);
                acceso.setearParametro("@CantidadTotal", nuevo.CantidadTotal);
                acceso.setearParametro("@PrecioCompra", nuevo.PrecioCompra);
                acceso.setearParametro("@PrecioVenta", nuevo.PrecioVenta);
                acceso.setearParametro("@Imagen", nuevo.Imagen); // Parámetro para la imagen
                acceso.setearParametro("@IDMarca", nuevo.Marca.ID);
                acceso.setearParametro("@IDTipo", nuevo.Tipo.ID);

                acceso.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion();
            }
        }

        public void modificar(Producto modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Productos SET Descripcion = @Descripcion, CantidadTotal = @CantidadTotal, PrecioCompra = @PrecioCompra, PrecioVenta = @PrecioVenta, Imagen = @Imagen WHERE ID = @ID");

                datos.setearParametro("@ID", modificar.ID);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                datos.setearParametro("@CantidadTotal", modificar.CantidadTotal);
                datos.setearParametro("@PrecioCompra", modificar.PrecioCompra);
                datos.setearParametro("@PrecioVenta", modificar.PrecioVenta);
                datos.setearParametro("@Imagen", modificar.Imagen); // Parámetro para la imagen

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        // Los métodos eliminarProducto, modificarTipoProducto y modificarMarcaProducto no requieren modificaciones ya que no interactúan con el campo Imagen.
    }
}
