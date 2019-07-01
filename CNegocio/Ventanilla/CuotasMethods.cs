﻿using CDatos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class CuotasMethods
    {
        private CuotasPrestamosManager cuotasPrestamosManager;

        public CuotasMethods() => cuotasPrestamosManager = new CuotasPrestamosManager();

        public List<object> ObtenerPrestamos(string avalue) => cuotasPrestamosManager.CuotasPrestamosSelect(avalue);
        
        public List<object> CuotasSelect(int avalue) => cuotasPrestamosManager.CuotasSelect(avalue);

        public int CuotasInsert(int CuotaID, string Usuario) => cuotasPrestamosManager.CuotasInsert(CuotaID, Usuario);

    }
}
