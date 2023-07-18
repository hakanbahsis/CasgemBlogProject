using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.CommentRepository.Validation
{
    public class CommentValidator:AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.Text).NotEmpty().WithMessage("Yorum boş geçilemez!");
        }
    }
}
