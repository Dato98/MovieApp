using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Contracts
{
    public interface IUOW : IDisposable
    {
        IMovieRepository Movie { get; }
        IPersonRepository Person { get; }
        void Commit();
    }
}
