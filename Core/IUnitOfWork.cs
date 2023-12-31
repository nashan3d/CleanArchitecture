﻿using Core.Repositries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }

        Task<int> Complete(CancellationToken cancellationToken);
    }
}
