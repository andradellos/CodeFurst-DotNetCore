﻿using EasyPush.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPush.Domain.Entities
{
    public class User : EntityGenerics
    {       
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
