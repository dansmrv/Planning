using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Planning.Dtos.Process;


namespace Planning.Mappers
{
    public static class ProcessMappers
    {
         public static ProcessDto ToProcessDto(this Planning.Models.Process processModel)
        {
            return new ProcessDto
            {
                Id = processModel.Id,
                Name = processModel.Name
            }; 
        }

        public static Planning.Models.Process ToProcessFromCreateDTO(this CreateProcessRequestDto processDto)
        {
            return new Planning.Models.Process
            {
                Id = processDto.Id,
                Name = processDto.Name
            };
        }
    }
}