﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldTech.Domain.OrdemServico.Repository
{
    public interface IOrdemRepository : CrossCutting.Repository.IRepository<Ordem>
    {
        Task<Ordem> ObterPorId(Guid id);
    }
}
