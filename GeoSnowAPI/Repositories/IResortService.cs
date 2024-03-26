using GeoSnowAPI.Entities;


namespace GeoSnowAPI.Repositories
{
    public interface IResortService
    {
        Task<List<Resort>> GetAllResorts();
        Task<Resort> GetResortDetails(int resortID);
        Task<List<Resort>> SearchResortsByRadius(decimal latitude, decimal longitude, int? radius);
        Task<List<Resort>> SearchResortsByRadiusSingleDate(decimal latitude, decimal longitude, DateTime myDate, int? radius);
        Task<List<Resort>> ResortSearchByRadiusDateRange(decimal latitude, decimal longitude, DateTime startDate, DateTime endDate, int? radius);

    }
}
