
namespace FutterautomatenDatenbank.Models
{
    public interface IFutterautomatenEFCoreRepository
    {
        void AddFutterautomat(Futterautomat futterautomat);
        void DeleteFutterautomat(int id);
        List<Futterautomat> GetFutterautomatByAquarium(string name);
        List<Futterautomat> GetFutterautomaten();
        void UpdateFutterautomat(int id, Futterautomat futterautomat);
    }
}