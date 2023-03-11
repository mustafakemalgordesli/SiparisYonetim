﻿using Application.Interfaces.Repository;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository;

public class SiparisRepository : GenericRepository<Siparis>, ISiparisRepository
{
	public SiparisRepository(ApplicationDbContext dbContext): base(dbContext)
	{

	}
}
