﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AQBooking.FileStream.Core.Models.FileResponse
{
    public class FileUploadResponse
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
    }
}