﻿using System.ComponentModel.DataAnnotations;

namespace API_web.Abstract
{
    public abstract class Auditable
    {
        public DateTime? Create_Date { get; set; }

        [MaxLength(256)]
        public string? Create_By { get; set; }
        public DateTime? Update_Date { get; set; }
        [MaxLength(256)]
        public string? Update_By { get; set; }
    }
}
