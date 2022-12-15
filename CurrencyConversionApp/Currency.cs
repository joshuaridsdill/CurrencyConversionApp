using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CurrencyConversionApp
{
    public enum CurrencyType : ushort
    {
        GBP,
        USD,
        AUS,
        EUR
    }

    public struct Currency
    {
        public CurrencyType Type;
        public double Price;

        public Currency(CurrencyType type, double price)
        {
            this.Type = type;
            this.Price = price;
        }

        public Currency toGBP()
        {
            Currency currency = new Currency(this.Type, this.Price);

            switch (currency.Type)
            {
                case CurrencyType.USD:
                    currency.Price *= 0.81;
                    break;
                case CurrencyType.AUS:
                    currency.Price *= 0.55;
                    break;
                case CurrencyType.EUR:
                    currency.Price *= 0.86;
                    break;
                default:
                    break;
            }

            return currency;
        }

        public Currency toUSD()
        {
            Currency currency = new Currency(Type, Price);

            switch (currency.Type)
            {
                case CurrencyType.GBP:
                    currency.Price *= 1.24;
                    break;
                case CurrencyType.AUS:
                    currency.Price *= 0.68;
                    break;
                case CurrencyType.EUR:
                    currency.Price *= 1.06;
                    break;
                default:
                    break;
            }

            return currency;
        }

        public Currency toAUS()
        {
            Currency currency = new Currency(Type, Price);

            switch (currency.Type)
            {
                case CurrencyType.GBP:
                    currency.Price *= 1.81;
                    break;
                case CurrencyType.USD:
                    currency.Price *= 1.46;
                    break;
                case CurrencyType.EUR:
                    currency.Price *= 1.56;
                    break;
                default:
                    break;
            }

            return currency;
        }

        public Currency toEUR()
        {
            Currency currency = new Currency(Type, Price);

            switch (currency.Type)
            {
                case CurrencyType.GBP:
                    currency.Price *= 1.16;
                    break;
                case CurrencyType.USD:
                    currency.Price *= 0.94;
                    break;
                case CurrencyType.AUS:
                    currency.Price *= 1.46;
                    break;
                default:
                    break;
            }

            return currency;
        }
    }
}