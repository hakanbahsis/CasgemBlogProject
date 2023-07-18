using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.NoteRepository.Validation
{
    public class NoteValidator:AbstractValidator<Note>
    {
        public NoteValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez!");
        }
    }
}
