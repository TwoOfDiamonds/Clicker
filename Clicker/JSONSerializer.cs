﻿using Newtonsoft.Json;
using System.IO;

namespace Clicker
{
    class JSONSerializer
    {
        public static void SerializeScenario(Scenario scenario)
        {
            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"scenario_1.json"))
            {
                //JsonSerializer serializer = new JsonSerializer();
                //serializer.Serialize(file, scenario);

                string json = JsonConvert.SerializeObject(scenario, Formatting.Indented, new ActionsJsonConverter());
                file.Write(json);
            }
        }

    }
}