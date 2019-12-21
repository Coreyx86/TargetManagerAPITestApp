using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GhostShtuff.Modules
{
    public class RPC
    {

        public int Call(uint func_address, params object[] parameters)
        {
            int paramsLen = parameters.Length;

            int i = 0;
            uint numOfIntegersInMemory = 0;
            uint numOfStringsInMemory = 0;
            uint numOfFloatsInMemory = 0;
            uint FloatArrayInMemoryLength = 0;

            //Loop through each parameter in call
            while (i < paramsLen)
            {
                //If the parameter is an int, write our value to our free space
                if (parameters[i] is int)
                {
                    //Write our int to our free space.
                    Manager.Instance.PS3.Extension.WriteInt32(0x10020000 + (numOfIntegersInMemory * 4), (int)parameters[i]);
                    numOfIntegersInMemory++;
                }
                else if (parameters[i] is uint)
                {
                    //Write our uint to our free space.
                    Manager.Instance.PS3.Extension.WriteUInt32(0x10020000 + (numOfIntegersInMemory * 4), (uint)parameters[i]);
                    numOfIntegersInMemory++;
                }
                else
                {
                    uint pointer = 0;

                    if (parameters[i] is string)
                    {
                        //Set pointer to the address of the string;
                        pointer = 0x10022000 + (numOfStringsInMemory * 0x400);

                        //Write the string in memory
                        Manager.Instance.PS3.Extension.WriteString(pointer, Convert.ToString(parameters[i]));

                        //Store the pointer in memory
                        Manager.Instance.PS3.Extension.WriteUInt32(0x10020000 + (numOfIntegersInMemory * 4), pointer);

                        numOfIntegersInMemory++; //Increment ints because of our pointer
                        numOfStringsInMemory++; //Increment num of strings in memory
                    }
                    else if (parameters[i] is float)
                    {
                        //Write the float in memory
                        Manager.Instance.PS3.Extension.WriteFloat(0x10020024 + (numOfFloatsInMemory * 4), (float)parameters[i]);
                        numOfFloatsInMemory++;
                    }
                    else if (parameters[i] is float[])
                    {
                        float[] input = (float[])parameters[i];

                        pointer = 0x10021000 + (FloatArrayInMemoryLength * 4);

                        Manager.Instance.PS3.Extension.WriteFloats(pointer, input);

                        Manager.Instance.PS3.Extension.WriteUInt32(0x10020000 + (numOfIntegersInMemory * 4), pointer);

                        numOfIntegersInMemory++;

                        FloatArrayInMemoryLength += (uint)input.Length;
                    }
                }
                i++;
            }

            //Write the address of the method we are calling
            Manager.Instance.PS3.Extension.WriteUInt32(0x1002004C, func_address);

            //Sleep the thread to allow time for the method to perform its actions.
            Thread.Sleep(20);

            //Return our results which are stored at the following address as specified in our PAYLOAD
            return Manager.Instance.PS3.Extension.ReadInt32(0x10020050);
        }

        public RPC()
        {
            //Check to see if we have already wrote our payload in memory
            if (!Manager.Instance.PS3.Extension.ReadBool(0x10022500))
            {
                //Redirect the flow of our target function so we can write the PAYLOAD to memory
                Manager.Instance.PS3.SetMemory(Addresses.rpc_function_address, new byte[] { 0x4E, 0x80, 0x00, 0x20 });

                Thread.Sleep(20);

                //This is the hex encoded PPC instruction set for the RPC function to be overwriting our target
                byte[] PAYLOAD = new byte[]
                {
                    0x7C, 0x08, 0x02, 0xA6,
                    0xF8, 0x01, 0x00, 0x80,
                    0x3C, 0x60, 0x10, 0x02,
                    0x81, 0x83, 0x00, 0x4C,
                    0x2C, 0x0C, 0x00, 0x00,
                    0x41, 0x82, 0x00, 0x64,
                    0x80, 0x83, 0x00, 0x04,
                    0x80, 0xA3, 0x00, 0x08,
                    0x80, 0xC3, 0x00, 0x0C,
                    0x80, 0xE3, 0x00, 0x10,
                    0x81, 0x03, 0x00, 0x14,
                    0x81, 0x23, 0x00, 0x18,
                    0x81, 0x43, 0x00, 0x1C,
                    0x81, 0x63, 0x00, 0x20,
                    0xC0, 0x23, 0x00, 0x24,
                    0xc0, 0x43, 0x00, 0x28,
                    0xC0, 0x63, 0x00, 0x2C,
                    0xC0, 0x83, 0x00, 0x30,
                    0xC0, 0xA3, 0x00, 0x34,
                    0xc0, 0xC3, 0x00, 0x38,
                    0xC0, 0xE3, 0x00, 0x3C,
                    0xC1, 0x03, 0x00, 0x40,
                    0xC1, 0x23, 0x00, 0x48,
                    0x80, 0x63, 0x00, 0x00,
                    0x7D, 0x89, 0x03, 0xA6,
                    0x4E, 0x80, 0x04, 0x21,
                    0x3C, 0x80, 0x10, 0x02,
                    0x38, 0xA0, 0x00, 0x00,
                    0x90, 0xA4, 0x00, 0x4C,
                    0x90, 0x64, 0x00, 0x50,
                    0xE8,  0x01, 0x00, 0x80,
                    0x7C, 0x08, 0x03, 0xA6,
                    0x38, 0x21, 0x00, 0x70,
                    0x4E, 0x80, 0x00, 0x20
                };

                //Write our payload in memory
                Manager.Instance.PS3.SetMemory(Addresses.rpc_function_address + 4, PAYLOAD);

                //Free some memory to hold our parameters, return values, etc.
                Manager.Instance.PS3.SetMemory(0x10020000, new byte[0x2854]);

                //Reinstate original flow of the target function to enable our payload. 
                Manager.Instance.PS3.SetMemory(Addresses.rpc_function_address, new byte[] { 0xF8, 0x21, 0xFF, 0x91 });

                Manager.Instance.PS3.Extension.WriteBool(0x10022500, true);
            }
        }
    }
}
