namespace InventarioFront.Servicios
{
    public interface IServiciosTipo
    {
        Task<HttpResponseWrapper<T>> GetTipos<T>(string url);
        Task<HttpResponseWrapper<object>> PostTipo<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostTipo<T, TActionResponse>(string url, T model);
    }
}
