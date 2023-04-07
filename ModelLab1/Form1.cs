using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ModelLab1
{
    public partial class Form1 : Form
    {
        private const int NumberOfSampleElements = 20; // количество элементов одной выборки
        private double[] X = new double[NumberOfSampleElements]; // элементы выборки
        private Random rnd = new Random();
        
        private const int NumberOfSamples = 10000; // количество выборок
        private double[] CLT_Y = new double[NumberOfSamples]; // результаты преобразования выборок по формулам
        private double[] Y = new double[NumberOfSamples]; // результаты преобразования выборок по формулам
        private const double m = 0.5; // матожидание
        private const double sredneeKvadratichnoeOtclonenie = 1;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            methods();
        }

        void GenerateY()
        {
            for (int i = 0; i < NumberOfSamples; i++)
            {
                generateXSample();
            double sumOfXElements = 0;
            for (int j = 0; j < NumberOfSampleElements; j++)
            {
                sumOfXElements += Math.Abs(2 * X[j] - 1);
            }
                
                Y[i] = Math.Sqrt(3 / (NumberOfSampleElements * sredneeKvadratichnoeOtclonenie * sumOfXElements)) + m;
            }
        }

        void GenerateCLT_Y()
        {
            for (int i = 0; i < NumberOfSamples; i++)
            {
                generateXSample();
                double sumOfXElements = 0;
                for (int j = 0; j < NumberOfSampleElements; j++)
                {   
                    sumOfXElements += X[j];
                }

                CLT_Y[i] = (sumOfXElements - m * NumberOfSampleElements) / (sredneeKvadratichnoeOtclonenie * Math.Sqrt(NumberOfSampleElements));
            }
        }

        void methods()
        {
            GenerateY();
            Array.Sort(Y);
            GenerateCLT_Y();
            Array.Sort(CLT_Y);
            
            CreateGistogramms(CLT_Y, secondChart, distributionSecond, 0);
            CreateGistogramms(Y, firstChart, distributionFirst, 0);
            counter = 2;
            CreateGistogramms(CLT_Y, density, distribution, 0);
            CreateGistogramms(Y, density, distribution, 1);
            

            }

        void CreateGistogramms(double[] YNow, Chart chart, Chart chart1, int t)
        {
            double minValue, maxValue, intervalLength, viborochnayaSrednaya = 0, sredneeKvadratOtkl = 0;
            int countOfIntervals;
            countOfIntervals = (int)Math.Floor(1 + 3.322 * Math.Log10(NumberOfSamples));

            // нахождение длины интервала
            minValue = YNow[0];
            maxValue = YNow[NumberOfSamples - 1];
            intervalLength = (maxValue - minValue) / countOfIntervals;

            double[] ProbabilitiesOfHittingTheInerval = new double[countOfIntervals];
            int[] CounterOfNumbersOnInterval = new int[countOfIntervals];
            double[] MiddlesOfTheIntervals = new double[countOfIntervals];
            double[] N = new double[countOfIntervals]; // массив теоретических частот на основе функции плотности нормального распределения

            for (int i = 0; i < countOfIntervals; i++)
            {
                CounterOfNumbersOnInterval[i] = 0;
            }

            // нахождение середин интервалов
            for (int i = 0; i < countOfIntervals; i++)
            {
                double leftBorderOfInterval = minValue + (i * intervalLength);
                double rightBorderOfInterval = minValue + ((i + 1) * intervalLength);
                MiddlesOfTheIntervals[i] = (leftBorderOfInterval + rightBorderOfInterval) / 2;
            }

            // подсчет значений попавших на интервалы
            for (int i = 0; i < NumberOfSamples; i++)
            {
                double leftBorderOfInterval = minValue;
                int j = 0;
                while (true)
                {
                    if (YNow[i] >= leftBorderOfInterval && YNow[i] < leftBorderOfInterval + intervalLength)
                    {
                        CounterOfNumbersOnInterval[j]++;
                        break;
                    }

                    // случай попадания варианта на крайнюю правую границу
                    if (j == countOfIntervals - 1 && YNow[i] >= leftBorderOfInterval + intervalLength)
                    {
                        CounterOfNumbersOnInterval[j]++;
                        break;
                    }

                    j++;
                    if (j == countOfIntervals)
                        break;
                    leftBorderOfInterval += intervalLength;
                }
            }

            // построение графика плотности
            for (int i = 0; i < countOfIntervals; i++)
            {
                ProbabilitiesOfHittingTheInerval[i] = (double)CounterOfNumbersOnInterval[i] / NumberOfSamples;
                chart.Series[t].Points.AddXY(Math.Round(MiddlesOfTheIntervals[i], 4), Math.Round(ProbabilitiesOfHittingTheInerval[i], 4));
            }

            // построение графика распределения
            double summs = 0;
            for (int i = 0; i < countOfIntervals; i++)
            {
                ProbabilitiesOfHittingTheInerval[i] = (double)CounterOfNumbersOnInterval[i] / NumberOfSamples;
                summs += ProbabilitiesOfHittingTheInerval[i];
                chart1.Series[t].Points.AddXY(Math.Round(MiddlesOfTheIntervals[i], 4), Math.Round(summs, 4));
            }




            // подсчёт выборочной средней и среднего квадратичексого отклонения
            double summForViborochnoiSredney = 0, summForSredneeKvOtkl = 0;
            for (int i = 0; i < countOfIntervals; i++)
            {
                summForViborochnoiSredney += MiddlesOfTheIntervals[i] * CounterOfNumbersOnInterval[i];
                summForSredneeKvOtkl += Math.Pow(MiddlesOfTheIntervals[i], 2) * CounterOfNumbersOnInterval[i];
            }
            viborochnayaSrednaya = summForViborochnoiSredney / NumberOfSamples;
            sredneeKvadratOtkl = Math.Sqrt(summForSredneeKvOtkl / NumberOfSamples - Math.Pow(viborochnayaSrednaya, 2));


            // нахождение теоритических частот, стандартизирование значений(середин интервалов)
            for (int i = 0; i < countOfIntervals; i++)
            {
                double Zi = (MiddlesOfTheIntervals[i] - viborochnayaSrednaya) / sredneeKvadratOtkl;
                double FZi = (1 / Math.Sqrt(2 * Math.PI)) * Math.Exp(-0.5 * Zi * Zi);
                N[i] = intervalLength * NumberOfSamples * FZi / sredneeKvadratOtkl;
            }

            // нахождение хи квадрат наблюдаемого для уровня значимости 0,05 и заданного кол-ва степеней свободы
            double X2Nabludaemoe = 0;
            int colvoStepenSvobod = countOfIntervals - 2 - 2 - 1;
            for (int i = 1; i < countOfIntervals - 1; i++)
            {
                double NtekusheeEmpirirch = 0, NtekusheeTeoretich = 0;
                if (i == 1)
                {
                    NtekusheeEmpirirch = CounterOfNumbersOnInterval[i] + CounterOfNumbersOnInterval[i - 1];
                    NtekusheeTeoretich = N[i] + N[i - 1];
                } else if (i == countOfIntervals - 1)
                {
                    NtekusheeEmpirirch = CounterOfNumbersOnInterval[i] + CounterOfNumbersOnInterval[i + 1];
                    NtekusheeTeoretich = N[i] + N[i + 1];
                }
                else
                {
                    NtekusheeEmpirirch = CounterOfNumbersOnInterval[i];
                    NtekusheeTeoretich = N[i];
                }
                X2Nabludaemoe += Math.Pow(NtekusheeEmpirirch - NtekusheeTeoretich, 2) / NtekusheeTeoretich;
            }

            if ( counter < 2)
                label1.Text += $"Хи квадрат:{X2Nabludaemoe} Количество степеней свободы:{colvoStepenSvobod}\n";
        }

        
        void generateXSample()
        {
            // Создаём набор чисел с равномерным законом распределения на интервале (0,1)
            for (int i = 0; i < NumberOfSampleElements; i++)
            {
                X[i] = rnd.NextDouble();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstChart.Series[0].Points.Clear();
            secondChart.Series[0].Points.Clear();
            distributionFirst.Series[0].Points.Clear();
            distributionSecond.Series[0].Points.Clear();

            density.Series[0].Points.Clear();
            density.Series[1].Points.Clear();
            distribution.Series[0].Points.Clear();
            distribution.Series[1].Points.Clear();
            methods();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            firstChart.Series[0].Points.Clear();
            secondChart.Series[0].Points.Clear();
            distributionFirst.Series[0].Points.Clear();
            distributionSecond.Series[0].Points.Clear();

            density.Series[0].Points.Clear();
            density.Series[1].Points.Clear();
            distribution.Series[0].Points.Clear();
            distribution.Series[1].Points.Clear();
            methods();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            firstChart.Series[0].Points.Clear();
            secondChart.Series[0].Points.Clear();
            distributionFirst.Series[0].Points.Clear();
            distributionSecond.Series[0].Points.Clear();

            density.Series[0].Points.Clear();
            density.Series[1].Points.Clear();
            distribution.Series[0].Points.Clear();
            distribution.Series[1].Points.Clear();
            methods();
        }

    }
}
