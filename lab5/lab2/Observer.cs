using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace lab2
{
    public interface IObserver
    {
        // Получает обновление от издателя
        void Update(TextBox text, ISubject subject);
    }

    public interface ISubject
    {
        // Присоединяет наблюдателя к издателю.
        void Attach(TextBox text, IObserver observer);

        // Отсоединяет наблюдателя от издателя.
        void Detach(TextBox text, IObserver observer);

        // Уведомляет всех наблюдателей о событии.
        void Notify(TextBox text);
    }

    // Издатель владеет некоторым важным состоянием и оповещает наблюдателей о
    // его изменениях.
    public class Subject : ISubject
    {
        // Для удобства в этой переменной хранится состояние Издателя,
        // необходимое всем подписчикам.
        public int State { get; set; } = -0;

        // Список подписчиков.
        private List<IObserver> _observers = new List<IObserver>();

        // Методы управления подпиской.
        public void Attach(TextBox text ,IObserver observer)
        {
            text.Text += "\r\nИздатель: Добавлен подписчик.";
            this._observers.Add(observer);
        }

        public void Detach(TextBox text, IObserver observer)
        {
            this._observers.Remove(observer);
            text.Text += "\r\nИздатель: Подписчик отписался.";
        }

        // Запуск обновления в каждом подписчике.
        public void Notify(TextBox text)
        {
            text.Text += "\r\nИздатель: Уведомление подписчиков";

            foreach (var observer in _observers)
            {
                observer.Update(text, this);
            }
        }

        // Обычно логика подписки – только часть того, что делает Издатель.
        // Издатели часто содержат некоторую важную бизнес-логику, которая
        // запускает метод уведомления всякий раз, когда должно произойти что-то
        // важное (или после этого).
        public void SomeBusinessLogic(TextBox text)
        {
            text.Text += "\r\nИздатель: Я делаю что-то важное.";
            this.State = new Random().Next(0, 10);

            Thread.Sleep(15);

            text.Text += ("\r\nИздатель: Моё состояние изменено на: " + this.State);
            this.Notify(text);
        }
    }

    // Конкретные Наблюдатели реагируют на обновления, выпущенные Издателем, к
    // которому они прикреплены.
    class ConcreteObserverA : IObserver
    {
        public void Update(TextBox text, ISubject subject)
        {
            if ((subject as Subject).State >= 5)
            {
                text.Text += "\r\nОбъектА: Реакция на событие.";
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(TextBox text, ISubject subject)
        {
            text.Text += "\r\nОбъектБ: Реакция на событие.";
        }
    }
}
