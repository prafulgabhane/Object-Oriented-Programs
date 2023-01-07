using System;
namespace Object_Oriented_Programs
{
	public class ReadData
	{
        public InventoryDetails Read(string path)
            {
                using (StreamReader file = new StreamReader(path))
                {

                    try
                    {
                        string json = file.ReadToEnd();
                        return JsonConvert.DeserializeObject<InventoryDetails>(json);

                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
            }
        }
    }