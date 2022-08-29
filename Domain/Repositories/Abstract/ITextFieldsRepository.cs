//ИНТЕРФЕЙС ДЛЯ ДОМЕННОГО ОБЬЕКТА
using AnimeLib.Domain.Entities;
using System;
using System.Linq;

namespace AnimeLib.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByIdCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
