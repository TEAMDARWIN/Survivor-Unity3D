using System;

namespace PackageObject
{
	public class Characteristic
	{
        public Characteristic()
        { }
        public Characteristic(int maxCharacteristic)
        {
            this.characteristic = maxCharacteristic;
            this.maxCharacteristic = maxCharacteristic;
        }
        public int characteristic
		{
			get;
			set;
		}

        public int maxCharacteristic
		{
			get;
			set;
		}
        
		public void Update(int value)
		{
            characteristic += value;

            if (characteristic > maxCharacteristic)
                characteristic = maxCharacteristic;
		}

	}
}

