using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth phoneBooth = new PhoneBooth();

            UsePhone(tardis);
            UsePhone(phoneBooth);
        }
        static void UsePhone(object obj)
        {
            PhoneInterface phoneInterface = (PhoneInterface)obj;
            phoneInterface.MakeCall();
            phoneInterface.HangUp();

            if(obj is Tardis)
            {
                Tardis tardisObj = (Tardis)obj;
                tardisObj.TimeTravel();
            }

            if (obj is PhoneBooth)
            {
                PhoneBooth phoneBoothObj = (PhoneBooth)obj;
                phoneBoothObj.OpenDoor();
            }
        }
    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public abstract void Connect();

        public abstract void Disconnect();
    }

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    public class PushButtonPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }
        public void MakeCall()
        {

        }
        public void HangUp()
        {

        }
        public override void Connect()
        {

        }
        public override void Disconnect()
        {

        }
    }

    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;
        private byte whichDrWho;
        private string femaleSideKick;

        public double exteriorSurfaceArea;
        public double interiorVolume;

        public byte WhichDrWho
        {
            get { return whichDrWho; }
        }
        public string FemaleSideKick
        {
            get { return femaleSideKick; }
        }

        public void TimeTravel()
        {

        }

        public static bool operator ==(Tardis a, Tardis b)
        {
            return a.WhichDrWho == b.WhichDrWho;
        }
        public static bool operator !=(Tardis a, Tardis b)
        {
            return a.WhichDrWho != b.WhichDrWho;
        }
        public static bool operator <(Tardis a, Tardis b)
        {
            if (a.WhichDrWho == 10) return false;
            if (b.WhichDrWho == 10) return true;
            return a.WhichDrWho < b.WhichDrWho;
        }
        public static bool operator >(Tardis a, Tardis b)
        {
            if (a.WhichDrWho == 10) return true;
            if (b.WhichDrWho == 10) return false;
            return a.WhichDrWho > b.WhichDrWho;
        }
        public static bool operator <=(Tardis a, Tardis b)
        {
            if (a.WhichDrWho == 10 && b.WhichDrWho != 10) return false;
            if (b.WhichDrWho == 10) return true;
            return a.WhichDrWho <= b.WhichDrWho;
        }
        public static bool operator >=(Tardis a, Tardis b)
        {
            if (a.WhichDrWho == 10) return true;
            if (b.WhichDrWho == 10 && a.whichDrWho != 10) return false;
            return a.WhichDrWho >= b.WhichDrWho;
        }
    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;

        public double costPerCall;
        public bool phoneBook;

        public void OpenDoor()
        {

        }
        public void CloseDoor()
        {

        }
    }
}
