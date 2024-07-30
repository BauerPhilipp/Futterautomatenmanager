
namespace FutterautomatenDatenbank.Models
{
    public interface IFutterautomatenEFCoreRepository
    {
        void AddFutterautomat(Futterautomat futterautomat);
        List<Futterautomat> GetFutterautomatByAquarium(string name);
        List<Futterautomat> GetFutterautomaten();
        Futterautomat GetFutterautomat(int id);
        void UpdateFutterautomat(int id, Futterautomat futterautomat);
        void DeleteFutterautomat(int id);
    }
}