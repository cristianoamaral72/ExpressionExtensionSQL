﻿using System;

namespace ExpressionExtensionSQL.Tests.Entities {
    public class Merchant {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsEnabled { get; set; }
    }
}
