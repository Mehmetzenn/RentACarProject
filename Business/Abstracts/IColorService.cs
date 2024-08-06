using Core.Utilities.Results;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IColorService
    {
        IResult Update(Color color);
        IResult Add(Color color);
        IResult Delete(Color color);
        IDataResult<List<Color>> GetAll();

        IDataResult<Color> GetByColorId(int colorId);

    }
}
