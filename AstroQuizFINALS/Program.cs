using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;


namespace FinalProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("AstroQuiz\n");
            Console.WriteLine("Created by : Jayvee Enobay\n");
            Console.WriteLine("----------------------------\n");
            //Quiz Start//
            Console.WriteLine();
            Console.WriteLine("Instruction:");
            Thread.Sleep(1000);
            Console.WriteLine("There will be 15 question in every categories");
            Thread.Sleep(1000);
            Console.WriteLine("There will be a timer of 20 seconds Easy mode and 1 minute for Normal mode and Hard mode. If you fail to answer it on time it will move to the next question and no points be conduct");
            Thread.Sleep(1000);
            Console.WriteLine("GOODLUCK!!\n");
            Thread.Sleep(1000);

            while (true)//loop//
            {
                Console.WriteLine("Would you like to Play?\n Press (1) if Yes, and (2) if No");
                Console.Write("Play :");
                int play = Convert.ToInt32(Console.ReadLine());
                if (play == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please Enter mode (Enter (1) for Easy, (2) for Normal and (3) for Hard mode");
                    Console.Write("Mode :");
                    int mode = Convert.ToInt32(Console.ReadLine());
                    if (mode == 1)
                    {
                        Stopwatch timer = new Stopwatch();//set timer//
                        {
                            var totalScore = 0;
                            Console.WriteLine();
                            Console.WriteLine("Easy Mode");
                            Console.WriteLine("1.What is the largest planet in our Solar System?");
                            Console.Write("Answer :");
                            timer.Start();
                            var entry = Console.ReadLine();
                            long time = timer.ElapsedMilliseconds;
                            if (entry.ToLower() == "jupiter" && time < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry.ToLower() != "jupiter" && time < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is jupiter");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("2.What is the closest planet to Earth?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry1 = Console.ReadLine();
                            long time1 = timer.ElapsedMilliseconds;
                            if (entry1.ToLower() == "mars" && time1 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry1.ToLower() != "mars" && time1 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is mars");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("3.Name of our galaxy?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry2 = Console.ReadLine();
                            long time2 = timer.ElapsedMilliseconds;
                            if (entry2.ToLower() == "milkyway" && time2 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry2.ToLower() != "milkyway" && time2 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is milkyway");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("4.The unit of measuring distance between the stars is known as?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry3 = Console.ReadLine();
                            long time3 = timer.ElapsedMilliseconds;
                            if (entry3.ToLower() == "lightyear" && time3 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry3.ToLower() != "lightyear" && time3 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is lightyear");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("5.The orbits of planet around the sun, or of satellites aroung the earth can be?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry4 = Console.ReadLine();
                            long time4 = timer.ElapsedMilliseconds;
                            if (entry4.ToLower() == "circular and elliptic" && time4 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry4.ToLower() != "circular and elliptic" && time4 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is circular and elliptic");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("6.On which of the planets of the solar system does the sun rise in the west and set in the east?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry5 = Console.ReadLine();
                            long time5 = timer.ElapsedMilliseconds;
                            if (entry5.ToLower() == "venus" && time5 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry5.ToLower() != "venus" && time5 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is venus");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("7. What planet takes the same number of days for rotation and revolution?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry6 = Console.ReadLine();
                            long time6 = timer.ElapsedMilliseconds;
                            if (entry6.ToLower() == "mercury" && time6 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry6.ToLower() != "mercury" && time6 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is mercury");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("8. What planet has the longest period of rotation?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry7 = Console.ReadLine();
                            long time7 = timer.ElapsedMilliseconds;
                            if (entry7.ToLower() == "venus" && time7 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry7.ToLower() != "venus" && time7 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is venus");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("9. It is called the North star?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry8 = Console.ReadLine();
                            long time8 = timer.ElapsedMilliseconds;
                            if (entry8.ToLower() == "polaris" && time8 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry8.ToLower() != "polaris" && time8 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is polaris");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("10. It is the bright heavenly body with a long luminous tail?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry9 = Console.ReadLine();
                            long time9 = timer.ElapsedMilliseconds;
                            if (entry9.ToLower() == "comet" && time9 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry9.ToLower() != "comet" && time9 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is comet");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("11. It is the study of everything in the universe beyond Earth's atmosphere?");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry10 = Console.ReadLine();
                            long time10 = timer.ElapsedMilliseconds;
                            if (entry10.ToLower() == "astronomy" && time10 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry10.ToLower() != "astronomy" && time10 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is astronomy");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("12. It is the red supergiant star and one of the largest stars visible to the naked eye.");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry11 = Console.ReadLine();
                            long time11 = timer.ElapsedMilliseconds;
                            if (entry11.ToLower() == "betelgeuse" && time11 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry11.ToLower() != "betelgeuse" && time11 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is betelgeuse");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("13. It is the gravitationally bound system of the sun and the object that orbit it.");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry12 = Console.ReadLine();
                            long time12 = timer.ElapsedMilliseconds;
                            if (entry12.ToLower() == "solar system" && time12 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry12.ToLower() != "solar system" && time12 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is solar system");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("14. It is the Earth's only natural satellite and the fifth largest satellite in the solar system.");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry13 = Console.ReadLine();
                            long time13 = timer.ElapsedMilliseconds;
                            if (entry13.ToLower() == "moon" && time13 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry13.ToLower() != "moon" && time13 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is moon");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);

                            Console.WriteLine();
                            Console.WriteLine("15. It is an independent agency of the US federal government responsible for the civil space program.");
                            Console.Write("Answer :");
                            timer.Restart();
                            var entry14 = Console.ReadLine();
                            long time14 = timer.ElapsedMilliseconds;
                            if (entry14.ToUpper() == "NASA" && time14 < 20000)
                            {
                                totalScore += 1;
                                Console.WriteLine("Correct Answer");
                                timer.Stop();
                            }
                            else if (entry14.ToUpper() != "NASA" && time14 < 20000)
                            {
                                Console.WriteLine("Wrong, the answer is NASA");
                                timer.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore);
                            Console.WriteLine();
                            if (totalScore >= 13)
                            {
                                Console.WriteLine("Congratulations You Passed!");
                            }
                            else
                            {
                                Console.WriteLine("Sorry You Failed!");
                            }
                            Console.ReadLine();
                        }
                    }
                    else if (mode == 2)
                    {
                        Stopwatch timer1 = new Stopwatch();
                        {
                            var totalScore1 = 0;
                            Console.WriteLine();
                            Console.WriteLine("Normal Mode\n");
                            Console.WriteLine("1. What planet looks reddish in the night sky?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans = Console.ReadLine();
                            long time = timer1.ElapsedMilliseconds;
                            if (ans.ToLower() == "mars" && time < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans.ToLower() != "mars" && time < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is mars");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("2. A ______ that is closest large galaxy to our milkyway galaxy?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans1 = Console.ReadLine();
                            long time1 = timer1.ElapsedMilliseconds;
                            if (ans1.ToLower() == "andromeda" && time1 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans1.ToLower() != "andromeda" && time1 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is andromeda");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("3. It is the most important source of energy for life on Earth?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans2 = Console.ReadLine();
                            long time2 = timer1.ElapsedMilliseconds;
                            if (ans2.ToLower() == "sun" && time2 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans2.ToLower() != "sun" && time2 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is sun");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("4. Distance between the Earth and the Sun?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans3 = Console.ReadLine();
                            long time3 = timer1.ElapsedMilliseconds;
                            if (ans3.ToLower() == "149 million kms" && time3 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans3.ToLower() != "149 million kms" && time3 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is 149 million kms");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("5. How many years does pluto take in revolving round Sun?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans4 = Console.ReadLine();
                            long time4 = timer1.ElapsedMilliseconds;
                            if (ans4.ToLower() == "248 years" && time4 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans4.ToLower() != "248 years" && time4 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is 248 years");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("6. The planet having the largest number of satellites in the solar system is?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans5 = Console.ReadLine();
                            long time5 = timer1.ElapsedMilliseconds;
                            if (ans5.ToLower() == "saturn" && time5 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans5.ToLower() != "saturn" && time5 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is saturn");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("7.The force by which planet or other body draws objects toward its center?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans6 = Console.ReadLine();
                            long time6 = timer1.ElapsedMilliseconds;
                            if (ans6.ToLower() == "gravity" && time6 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans6.ToLower() != "gravity" && time6 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is gravity");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("8. A _______ is a region of spacetime where gravity is so strong that nothing, including light could escape?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans7 = Console.ReadLine();
                            long time7 = timer1.ElapsedMilliseconds;
                            if (ans7.ToLower() == "black hole" && time7 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans7.ToLower() != "black hole" && time7 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is black hole");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("9. what was the first space mission to put people on the moon?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans8 = Console.ReadLine();
                            long time8 = timer1.ElapsedMilliseconds;
                            if (ans8.ToLower() == "apollo 11" && time8 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans8.ToLower() != "apollo 11" && time8 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is apollo 11");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("10. A planet outside the solar system?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans9 = Console.ReadLine();
                            long time9 = timer1.ElapsedMilliseconds;
                            if (ans9.ToLower() == "exoplanet" && time9 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans9.ToLower() != "exoplanet" && time9 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is exoplanet");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);
                            
                            Console.WriteLine();
                            Console.WriteLine("11. What year did soviet cosmonaut Valentina Tereshkova become the first woman travel to space?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans10 = Console.ReadLine();
                            long time10 = timer1.ElapsedMilliseconds;
                            if (ans10.ToLower() == "1963" && time10 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans10.ToLower() != "1963" && time10 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is 1963");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("12. The atmosphere in mars is mostly composed of?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans11 = Console.ReadLine();
                            long time11 = timer1.ElapsedMilliseconds;
                            if (ans11.ToLower() == "carbon dioxide" && time11 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans11.ToLower() != "carbon dioxide" && time11 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is carbon dioxide");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("13. What year is Halley's Comet expected to return to the solar system?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans12 = Console.ReadLine();
                            long time12 = timer1.ElapsedMilliseconds;
                            if (ans12.ToLower() == "2061" && time12 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans12.ToLower() != "2061" && time12 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is 2061");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("14. When was pluto removed from the list of planets?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans13 = Console.ReadLine();
                            long time13 = timer1.ElapsedMilliseconds;
                            if (ans9.ToLower() == "2006" && time13 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans13.ToLower() != "2006" && time13 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is 2006");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);

                            Console.WriteLine();
                            Console.WriteLine("15. What was discovered in the year 1998 using Type Ia supernovae?");
                            Console.Write("Answer :");
                            timer1.Start();
                            var ans14 = Console.ReadLine();
                            long time14 = timer1.ElapsedMilliseconds;
                            if (ans14.ToLower() == "exoplanet" && time14 < 60000)
                            {
                                totalScore1 += 1;
                                Console.WriteLine("Correct Answer");
                                timer1.Stop();
                            }
                            else if (ans14.ToLower() != "exoplanet" && time14 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is exoplanet");
                                timer1.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer1.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore1);
                            Console.WriteLine();
                            if (totalScore1 >= 13)
                            {
                                Console.WriteLine("Congratulations You Passed!");
                            }
                            else
                            {
                                Console.WriteLine("Sorry You Failed!");
                            }
                            Console.ReadLine();
                        }
                    }else if (mode == 3)
                    {
                        Stopwatch timer2 = new Stopwatch();
                        {
                            var totalScore2 = 0;
                            Console.WriteLine();
                            Console.WriteLine("Hard Mode\n");
                            Thread.Sleep(1000);
                            Console.WriteLine("Rumbled Words\n");
                            Thread.Sleep(1000);
                            Console.WriteLine("This mode only have 15 question and each question have 1 minute to answer.There will be no counted score if you failed to answer it on time");
                            Thread.Sleep(1000);
                            Console.WriteLine("CAPITAL LETTERS ONLY!!");
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("1. One of the largest constellation and remains one of the 88 modern constellation");
                            Console.WriteLine();
                            Console.WriteLine("ATUURSECN");
                            Console.Write("Answer :");
                            timer2.Start();
                            var conste = Console.ReadLine();
                            long time = timer2.ElapsedMilliseconds;
                            if (conste.ToUpper() == "CENTAURUS" && time < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste.ToUpper() != "CENTAURUS" && time < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is CENTAURUS");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("2. One of the recognizable constellation of the northern summer and autumn.");
                            Console.WriteLine();
                            Console.WriteLine("GSUNYC");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste1 = Console.ReadLine();
                            long time1 = timer2.ElapsedMilliseconds;
                            if (conste1.ToUpper() == "CYGNUS" && time1 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste1.ToUpper() != "CYGNUS" && time1 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is CYGNUS");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("3. A prominent constellation located on the celestial equator and visible throughout the world.");
                            Console.WriteLine();
                            Console.WriteLine("NIOOR");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste2 = Console.ReadLine();
                            long time2 = timer2.ElapsedMilliseconds;
                            if (conste2.ToUpper() == "ORION" && time2 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste2.ToUpper() != "ORION" && time2 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is ORION");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("4. A constellation in the northern sky named after the vain queen cassiopeia.");
                            Console.WriteLine();
                            Console.WriteLine("EPIISACASO");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste3 = Console.ReadLine();
                            long time3 = timer2.ElapsedMilliseconds;
                            if (conste3.ToUpper() == "CASSIOPEIA" && time3 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste3.ToUpper() != "CASSIOPEIA" && time3 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is CASSIOPEIA");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);
                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("5. A constellation in northern sky, whose associated mythology likely dates back into prehistory.");
                            Console.WriteLine();
                            Console.WriteLine("SAUR OARMJ");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste4 = Console.ReadLine();
                            long time4 = timer2.ElapsedMilliseconds;
                            if (conste4.ToUpper() == "URSA MAJOR" && time4 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste4.ToUpper() != "URSA MAJOR" && time4 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is URSA MAJOR");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("6. A large and prominent constellation in the northern hemisphere's winter sky.");
                            Console.WriteLine();
                            Console.WriteLine("USRATU");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste5 = Console.ReadLine();
                            long time5 = timer2.ElapsedMilliseconds;
                            if (conste5.ToUpper() == "TAURUS" && time5 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste5.ToUpper() != "TAURUS" && time5 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is TAURUS");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("7. A distant pair of fishes connected by one cord each.");
                            Console.WriteLine();
                            Console.WriteLine("SIPCSE");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste6 = Console.ReadLine();
                            long time6 = timer2.ElapsedMilliseconds;
                            if (conste6.ToUpper() == "PISCES" && time6 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste6.ToUpper() != "PISCES" && time6 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is PISCES");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("8. A constellation between Cancer the crab to the west and Virgo the maiden to the east.");
                            Console.WriteLine();
                            Console.WriteLine("EOL");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste7 = Console.ReadLine();
                            long time7 = timer2.ElapsedMilliseconds;
                            if (conste7.ToUpper() == "LEO" && time7 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste7.ToUpper() != "LEO" && time7 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is LEO");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("9. One of the twelve constellation of the zodiac and located in northern hemesphere its latin name is crab");
                            Console.WriteLine();
                            Console.WriteLine("NRACEC");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste8 = Console.ReadLine();
                            long time8 = timer2.ElapsedMilliseconds;
                            if (conste8.ToUpper() == "CANCER" && time8 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste8.ToUpper() != "CANCER" && time8 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is CANCER");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("10. It is the second largest constellation in the sky and the largest constellation in the zodiac.");
                            Console.WriteLine();
                            Console.WriteLine("RGOIV");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste9 = Console.ReadLine();
                            long time9 = timer2.ElapsedMilliseconds;
                            if (conste9.ToUpper() == "VIRGO" && time9 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste9.ToUpper() != "VIRGO" && time9 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is VIRGO");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("11. It is located between Pisces to the west and Taurus to the East. Its latin name is ram.");
                            Console.WriteLine();
                            Console.WriteLine("EIRAS");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste10 = Console.ReadLine();
                            long time10 = timer2.ElapsedMilliseconds;
                            if (conste10.ToUpper() == "ARIES" && time10 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste10.ToUpper() != "ARIES" && time10 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is ARIES");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("12. It represent the famed greek dog laelaps.");
                            Console.WriteLine();
                            Console.WriteLine("ANSIC ORJAM");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste11 = Console.ReadLine();
                            long time11 = timer2.ElapsedMilliseconds;
                            if (conste11.ToUpper() == "CANIS MAJOR" && time11 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste11.ToUpper() != "CANIS MAJOR" && time11 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is CANIS MAJOR");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("13. It represent the twins Castor and Pollux, giving the constellation a rough U shape.");
                            Console.WriteLine();
                            Console.WriteLine("IINGME");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste12 = Console.ReadLine();
                            long time12 = timer2.ElapsedMilliseconds;
                            if (conste12.ToUpper() == "GEMINI" && time12 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste12.ToUpper() != "GEMINI" && time12 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is GEMINI");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("14. It sort of forms a lopsided square with a tail to its brightest star, Vega, which is one of the brightest star in the sky.");
                            Console.WriteLine();
                            Console.WriteLine("RYAL");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste13 = Console.ReadLine();
                            long time13 = timer2.ElapsedMilliseconds;
                            if (conste13.ToUpper() == "LYRA" && time13 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste13.ToUpper() != "LYRA" && time13 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is LYRA");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);

                            Console.WriteLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("15. It is easy to find in the night sky. Antares the brightest star in the constellation the heart of scorpion.");
                            Console.WriteLine();
                            Console.WriteLine("PUISORSC");
                            Console.Write("Answer :");
                            timer2.Restart();
                            var conste14 = Console.ReadLine();
                            long time14 = timer2.ElapsedMilliseconds;
                            if (conste14.ToUpper() == "SCORPIUS" && time14 < 60000)
                            {
                                totalScore2 += 1;
                                Console.WriteLine("Correct Answer");
                                timer2.Stop();
                            }
                            else if (conste14.ToUpper() != "SCORPIUS" && time14 < 60000)
                            {
                                Console.WriteLine("Wrong, the answer is SCORPIUS");
                                timer2.Stop();
                            }
                            else
                            {
                                Console.WriteLine("You run out of time.");
                                timer2.Stop();
                            }
                            Console.WriteLine("Score :" + totalScore2);
                            Console.WriteLine();
                            if (totalScore2 >= 13)
                            {
                                Console.WriteLine("Congratulations You Passed!");
                            }
                            else
                            {
                                Console.WriteLine("Sorry You Failed!");
                            }
                        }
                    }
                }if (play == 2)
                {
                    Console.WriteLine("THANK YOU FOR NOT PLAYING!!");
                    break;
                }

            }
        }
    }
}

