using _2011103413_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011103413_PER.Repositories
{
    //Debe heredar de IDisposable para que el Garbage Collector
    // pueda liberar memoria que ya no utilice.
    public interface IUnityOfWork : IDisposable
    {
        // cada una de las propiedades debe ser de solo lectura

        IAsientoRepository Asiento { get;  }
        IAutomovilRepository Automovil { get; }
        IBusRepository Bus { get; }
        ICarroRepository Carro { get; }
        ICinturonRepository Cinturon { get; }
        IEnsambladoraRepository Ensambladora { get; }
        ILlantaRepository Llanta { get; }
        IParabrisasRepository Parabrisas { get; }
        IPropietarioRepository Propietario { get; }
        IVolanteRepository Volante { get; }

        //Metodo que guardara los cambios en la base de datos.
        int SaveChanges();

    }
}
