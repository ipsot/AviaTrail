using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSales
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight cur_flight;//текущий рейс
            int choose;//выбор действия
            
                List<Flight> flights = new List<Flight>();
                cur_flight.CounrtyOfDeparture = "Россия"; cur_flight.CounrtyOfArrival = "USA"; cur_flight.TimeOfDeparture = DateTime.Parse("2020-02-20 10:34:00.000"); cur_flight.TimeOfArrival = DateTime.Parse("2020-02-20 20:40:00.000"); cur_flight.TicketPrice = 500; flights.Add(cur_flight);
                cur_flight.CounrtyOfDeparture = "Канада"; cur_flight.CounrtyOfArrival = "USA"; cur_flight.TimeOfDeparture = DateTime.Parse("2020-02-12 10:03:00.000"); cur_flight.TimeOfArrival = DateTime.Parse("2020-02-12 11:20:00.000"); cur_flight.TicketPrice = 200; flights.Add(cur_flight);
            
            while (true)
            {
                for (int i = 0; i < flights.Count; i++)
                {
                    Console.WriteLine($"Страна вылета:{flights[i].CounrtyOfDeparture} |" + $"Страна прибытия:{flights[i].CounrtyOfArrival} |" + $"Время вылета:{flights[i].TimeOfDeparture} |" + $"Время прибытия:{flights[i].TimeOfArrival} |" + $"Цена билета:{flights[i].TicketPrice} |");
                }
                //foreach (Flight f in flights)
                //{
                //    Console.WriteLine($"Страна вылета:{f.CounrtyOfDeparture} |" + $"Страна прибытия:{f.CounrtyOfArrival} |" + $"Время вылета:{f.TimeOfDeparture} |" + $"Время прибытия:{f.TimeOfArrival} |" + $"Цена билета:{f.TicketPrice} |");
                //}

                Console.WriteLine("Выбирите действие:\n 1-добавить\n 2-удалить \n 3-редактировать выбранный элемент\n 0-выход");
                choose = Convert.ToInt32(Console.ReadLine());//выбор действия

                switch (choose)
                {
                    case 0: return;//выход из программы
                    case 1://добавление
                        Console.WriteLine("Введите страну вылета");
                        cur_flight.CounrtyOfDeparture = Console.ReadLine();
                        Console.WriteLine("Введите страну прибытия");
                        cur_flight.CounrtyOfArrival = Console.ReadLine();
                        Console.WriteLine("Введите время вылета");
                        cur_flight.TimeOfDeparture = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Введите время прибытия");
                        cur_flight.TimeOfArrival = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Введите цену билета");
                        cur_flight.TicketPrice = Convert.ToInt32(Console.ReadLine());
                        flights.Add(cur_flight);
                        break;
                    case 2://удаление
                        Console.WriteLine("введите номер рейса");
                        int id = Convert.ToInt32(Console.ReadLine());
                        flights.RemoveAt(id);
                        break;
                    case 3:
                        ChangeThisFlight(flights);
                        break;

                }

                Console.ReadKey();
            }
        }


        static void ChangeThisFlight(List<Flight> flights)//вначале удаляем старый и на его место добавляем новый
        {
            int n;
            Console.WriteLine("Введите номер изменяемого рейса");
            n = Convert.ToInt32(Console.ReadLine());
            Flight insertFlight;
            flights.RemoveAt(n);// удаление старого рейса по данному id

            Console.WriteLine("Введите страну вылета");
            insertFlight.CounrtyOfDeparture = Console.ReadLine();
            Console.WriteLine("Введите страну прибытия");
            insertFlight.CounrtyOfArrival = Console.ReadLine();
            Console.WriteLine("Введите время вылета");
            insertFlight.TimeOfDeparture = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите время прибытия");
            insertFlight.TimeOfArrival = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену билета");
            insertFlight.TicketPrice = Convert.ToInt32(Console.ReadLine());
            flights.Insert(n, insertFlight);
        }

        struct Flight
        {
            public string CounrtyOfDeparture;//страна вылета
            public string CounrtyOfArrival;//прибытие в какую страну
            public DateTime TimeOfDeparture;//время вылета
            public DateTime TimeOfArrival;//время прибытия
            public int TicketPrice;//цена билета

        }

    }

}




