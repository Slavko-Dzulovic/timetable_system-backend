using System;

namespace SSA2020_Back_Hypnotized_Chicken.Data
{
    interface ITimestampable
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}