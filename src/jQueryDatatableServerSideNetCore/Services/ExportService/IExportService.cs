﻿using jQueryDatatableServerSideNetCore.Models.DatabaseModels;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace jQueryDatatableServerSideNetCore.Services.ExportService
{
    public interface IExportService
    {
        Task<byte[]> ExportToExcel(List<TestRegister> registers);

        byte[] ExportToCsv(List<TestRegister> registers);

        byte[] ExportToHtml(List<TestRegister> registers);

        byte[] ExportToJson(List<TestRegister> registers);

        byte[] ExportToXml(List<TestRegister> registers);

        byte[] ExportToYaml(List<TestRegister> registers);
    }
}
