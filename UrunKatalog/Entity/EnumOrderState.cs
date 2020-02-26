﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UrunKatalog.Entity
{
    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekliyor...")]
        Waiting,
        [Display(Name = "İşlem Tamamlandı...")]
        Completed
    }
}