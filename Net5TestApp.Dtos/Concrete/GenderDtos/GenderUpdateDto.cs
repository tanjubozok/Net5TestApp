﻿using Net5TestApp.Dtos.Abstract;

namespace Net5TestApp.Dtos.Concrete.GenderDtos
{
    public class GenderUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
