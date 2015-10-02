using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask_2.Entities
{
    /// <summary>
    /// Данные о поле человека
    /// </summary>
    public enum PersonSex : int
    {
        unknown = 0,
        мужской,
        женский,
    }

    /// <summary>
    /// Класс хранящий информацию о человеке: личные данные,
    /// а также информацию о занятости и уровне достатка
    /// </summary>
    public class PersonData
    {
        /// <summary>
        /// Редактирование поля "Фамилия"
        /// </summary>
        public string lastName
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "Имя"
        /// </summary>
        public string firstName
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "Отчество"
        /// </summary>
        public string secondName
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "Пол"
        /// </summary>
        public PersonSex Sex
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "Дата рождения"
        /// </summary>
        public string BirthDate
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "Страна рождения"
        /// </summary>
        public string BirthCountry
        {
            set;
            get;
        }
        /// <summary>
        /// Редактирование поля "Город рождения"
        /// </summary>
        public string BirthTown
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "Занятость"
        /// </summary>
        public string Busy
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "доход"
        /// </summary>
        public string MonthlyIncome
        {
            get;
            set;
        }
        /// <summary>
        /// Редактирование поля "Удовлетворенность"
        /// </summary>
        public int Contentment
        {
            get;
            set;
        }
        /// <summary>
        /// Возвращает текстовую строку содержаю, полную 
        /// информацию о человеке
        /// </summary>
        public string GetFullInfo
        {
            get
            {
                return "Фамилия: " + this.lastName + 
                    Environment.NewLine +
                    "Имя " + this.firstName + 
                    Environment.NewLine +
                    "Отчество: " + secondName + 
                    Environment.NewLine +
                    "Пол: " + Sex + 
                    Environment.NewLine +
                    "Дата рождения: " + BirthDate + 
                    Environment.NewLine +
                    "Место рождения: " + BirthCountry + ", " + BirthTown +
                    Environment.NewLine + 
                    "Занятость: " + this.Busy +
                    Environment.NewLine + 
                    "Месячный доход: " + this.MonthlyIncome +
                    Environment.NewLine + 
                    "Удовлетворенность товаром: " + this.Contentment;
            }
        }
    }
}
