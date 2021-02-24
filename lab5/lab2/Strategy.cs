using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace lab2
{
    // Контекст определяет интерфейс, представляющий интерес для клиентов.
    class Context
    {
        // Контекст хранит ссылку на один из объектов Стратегии. Контекст не
        // знает конкретного класса стратегии. Он должен работать со всеми
        // стратегиями через интерфейс Стратегии.
        private IStrategy _strategy;

        public Context()
        { }

        // Обычно Контекст принимает стратегию через конструктор, а также
        // предоставляет сеттер для её изменения во время выполнения.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Обычно Контекст позволяет заменить объект Стратегии во время
        // выполнения.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Вместо того, чтобы самостоятельно реализовывать множественные версии
        // алгоритма, Контекст делегирует некоторую работу объекту Стратегии.
        public void DoSomeBusinessLogic(TextBox text)
        {
            text.Text += ("Сортировка данных согласно выбранной клиентом стратегии\r\n");
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            text.Text += $"{resultStr}\r\n";
        }
    }

    // Интерфейс Стратегии объявляет операции, общие для всех поддерживаемых
    // версий некоторого алгоритма.
    //
    // Контекст использует этот интерфейс для вызова алгоритма, определённого
    // Конкретными Стратегиями.
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }

    // Конкретные Стратегии реализуют алгоритм, следуя базовому интерфейсу
    // Стратегии. Этот интерфейс делает их взаимозаменяемыми в Контексте.
    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }

}
