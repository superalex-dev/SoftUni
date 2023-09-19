﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Store
{
    public interface ILaptop : IProduct
    {
        IReadOnlyCollection<IHardware> HardwareParts { get; }

        void AddHardware(IHardware hardware);
    }
}
