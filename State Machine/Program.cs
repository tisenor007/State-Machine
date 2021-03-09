using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    class Program
    {

        enum WeaponType
        {
            none,
            pistol, //0
            shotgun, //1
            spreader, //2
            laser, //3
            rocketlauncher,//4
            BFG //5
        }

        static WeaponType weapon1;
        static WeaponType weapon2;

        static void Main(string[] args)
        {
            Console.WriteLine("State Machine");
            Console.WriteLine(" - Switch Statements");
            Console.WriteLine(" - Emus (Enumerators)");
            Console.WriteLine();

            //0 = pistol
            //1 = shotgun
            //2 = spreader
            //3 = laser
            //4 = BFG

            //init:
            //int weapon = 0;//pistol

            WeaponType weapon = WeaponType.pistol;

            //simulated gameplay:

            //switch weapon
            //weapon = 2;
            //weapon = WeaponType.spreader;
            ChangeWeapon(WeaponType.rocketlauncher);
            FireWeapon();
            //switch weapon
            //weapon = 4; //BFG
            //weapon = WeaponType.BFG;

            Console.ReadKey(true);
        }
        static void ChangeWeapon(WeaponType newWeapon)
        {
            weapon1 = newWeapon;
        }
        static void FireWeapon()
        {
            switch (weapon1)
            {
                case WeaponType.none:
                    Console.WriteLine("Nothing fired......");
                    break;
                case WeaponType.pistol:
                    Console.WriteLine("Pistol fired.......");
                    break;
                case WeaponType.shotgun:
                    Console.WriteLine("Shotgun Fired......");
                    break;
                case WeaponType.laser:
                    Console.WriteLine("laser Fired......");
                    break;
                case WeaponType.spreader:
                    Console.WriteLine("spreader Fired......");
                    break;
                case WeaponType.rocketlauncher:
                    Console.WriteLine("rocketlauncher Fired......");
                    break;
                case WeaponType.BFG:
                    Console.WriteLine("BFG Fired.......");
                    break;


            }
                

            //if (weapon1 == WeaponType.pistol && weapon2 == WeaponType.pistol)
            //{
                //Console.WriteLine("Pistol Fired....");
            //}

           //if (weapon1 == WeaponType.shotgun)
            //{
                //Console.WriteLine("Shotgun Fired......");
            //}
            //if (weapon1 == WeaponType.spreader)
            //{
                //Console.WriteLine("spreader Fired......");
            //}
            //if (weapon1 == WeaponType.laser)
            //{
                //Console.WriteLine("laser Fired......");
            //}
            //if (weapon1 == WeaponType.rocketlauncher)
            //{
                //Console.WriteLine("rocketlauncher Fired......");
            //}
            //if (weapon1 == WeaponType.BFG)
            //{
                //Console.WriteLine("BFG Fired......");
            //}
        }
    }
}
