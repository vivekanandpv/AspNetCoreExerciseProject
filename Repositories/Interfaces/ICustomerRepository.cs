﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreExerciseProject.Models;

namespace AspNetCoreExerciseProject.Repositories.Interfaces
{
    public interface ICustomerRepository: ICrudRepository<Customer>
    {
    }
}
