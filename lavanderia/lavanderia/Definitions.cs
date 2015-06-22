using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lavanderia
{
    public class Definitions
    {
        public enum FormType
        {
            Terminal = 0,
            Operator = 1,
            Customer = 2,
            Families = 3,
        }


        public const String TERMINALS = "lvweb001.out";
        public const String TERMINAL_FAMILIES = "lvweb002.out";
        public const String OPERATORS = "lvweb003.out";
        public const String CLIENTS = "lvweb004.out";
        public const String CHECK_DATA = "lvweb005.out";
        public const String PRINT_VOUCHER = "lvweb006.out";
    }
}
