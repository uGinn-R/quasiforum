using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using quasiforum.Models;

namespace quasiforum
{
    public static class Locale
    {
        public static Dictionary<string, string> RU = new Dictionary<string, string>()
        {
            {"Home","Главная"},
            {"Topics","Топики"},
            {"Topic posts:","Посты топика:"},
            {"Profile","Мой кабинет"},
            {"Hello","Привет"},
            {"Logout","Выйти"},
            {"Register","Регистрация"},
            {"Login","Войти"},
            {"Name","Имя"},
            {"Created","Создано"},
            {"Create","Создать"},
            {"Description","Описание"},
            {"Details","Подробности"},
            {"Posts Count","Кол-во постов"},
            {"Actions","Действия"},
            {"View","Просмотр"},
            {"Edit","Редактировать"},
            {"Delete","Удалить"},
            {"Add post","Добавить пост"},
            {"NO","Нет"},
            {"YES","Да"},
            {"Apply","Применить"},
            {"Confirm delete","Удалить?"},
            {"Create new topic","Создать топик"},
            {"My Topics","Мои топики"},
            {"LIGHT","Светлая"},
            {"DARK","Тёмная"},
            {"Theme:","Тема:"},
            {"Language:","Язык:"},
            {"Loading","Загрузка"},
            {"Topics:","Все топики:"},
            {"Personalize:","Персонализация:"},
            {"Show more","Развернуть"},
            {"Show less","Свернуть"},
            {"Newest Topics","Последние топики"},
            {"Last added items","Последние айтемы"},
            {"Select image (drag and drop supported):","Выберите изображение (или перетащите сюда)"},
            {"Posted","Опубликовано" },
            { "Message","Сообщение"},
            { "Registered","Зарегистрирован"},
            { "Topic starter","Создатель"}
        };
        public static Dictionary<string, string> EN = new Dictionary<string, string>();

        public static Dictionary<string, string> Translations = Reverse();
        public static Dictionary<string, string> Reverse()
        {
            Dictionary<string, string> reversed = new Dictionary<string, string>();
            foreach (var item in RU)
            {
                reversed.Add(item.Key, item.Key);
            }
            EN = reversed;
            return EN;
        }
        public static Dictionary<string, string> SetLocale(this AppUser user)
        {
            //Reverse();
            if (user.Language == true)
            {
                Translations = RU;
            }
            else Translations = Reverse();
            return Translations;
        }

    }
}
