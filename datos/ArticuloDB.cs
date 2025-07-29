using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using modelo;


namespace datos
{
    public class ArticuloDB
    {
        #region Listar Articulo, Categoria y Marca
        public List<Articulo> ListarArticulo()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetearConsulta("Select Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio from ARTICULOS A, MARCAS M, CATEGORIAS C Where M.Id = A.IdMarca and C.Id = A.IdCategoria");
                accesoDatos.EjecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];

                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                        aux.Url_imagen = (string)accesoDatos.Lector["ImagenUrl"];

                    aux.Categoria = new Categoria { Descripcion = (string)accesoDatos.Lector["Categoria"] };
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)accesoDatos.Lector["Marca"];

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
                    accesoDatos.Lector.Close();
            }
        }

        public List<Categoria> ListarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Descripcion from CATEGORIAS");
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
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
                accesoDatos.CerrarConexion();
            }
        }

        public List<Marca> ListarMarca()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Select Id, Descripcion from MARCAS");
                accesoDatos.EjecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)accesoDatos.Lector["Id"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
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
                accesoDatos.CerrarConexion();
            }
        }
#endregion

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                accesoDatos.SetearParametro("@Codigo", nuevo.Codigo);
                accesoDatos.SetearParametro("@Nombre", nuevo.Nombre);
                accesoDatos.SetearParametro("@Descripcion", nuevo.Descripcion);
                accesoDatos.SetearParametro("@IdMarca", nuevo.Marca.Id);
                accesoDatos.SetearParametro("@IdCategoria", nuevo.Categoria.Id);
                accesoDatos.SetearParametro("@ImagenUrl", nuevo.Url_imagen);
                accesoDatos.SetearParametro("@Precio", nuevo.Precio);
                accesoDatos.EjecutarAccion();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally 
            {
                accesoDatos.CerrarConexion();
            }

        }

        public void Modificar(Articulo nuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                accesoDatos.SetearParametro("@Codigo", nuevo.Codigo);
                accesoDatos.SetearParametro("@Nombre", nuevo.Nombre);
                accesoDatos.SetearParametro("@Descripcion", nuevo.Descripcion);
                accesoDatos.SetearParametro("@IdMarca", nuevo.Marca.Id);
                accesoDatos.SetearParametro("@IdCategoria", nuevo.Categoria.Id);
                accesoDatos.SetearParametro("@ImagenUrl", nuevo.Url_imagen);
                accesoDatos.SetearParametro("@Precio", nuevo.Precio);
                accesoDatos.SetearParametro("@Id", nuevo.Id);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally 
            {
                accesoDatos.CerrarConexion();
            }
        }
        public void EliminarArticulo(int id)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.SetearConsulta("Delete from ARTICULOS where Id = @Id");
                accesoDatos.SetearParametro("@Id", id);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
        }










    }
}
