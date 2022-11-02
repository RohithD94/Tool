using APIGenerator.TemplateGenerationFiles.JsonTemplateFiles;
using System;

namespace APIGenerator.TemplateGenerationClassFiles
{
    public class JsonGeneration
    {
        public static void CreateJsonFilesThroughDatabase(string localConnectionString, string outputPath, string databaseType,
            string tableName, string libraryName, string schemaName)
        {
            if (databaseType.ToLower() == "sql")
            {
                JsonCreator jsonGeneration = new JsonCreator
                {
                    TableName = tableName,
                    SchemaName = schemaName,
                    ConnectionString = localConnectionString,
                    OutputPath = outputPath + "JsonFiles"
                };
                jsonGeneration.TransformText();
            }

            if (databaseType.ToLower() == "as400")
            {
                As400JsonGeneration as400JsonGeneration = new As400JsonGeneration
                {
                    LibraryName = libraryName,
                    TableName = tableName,
                    ConnectionString = localConnectionString,
                    OutputPath = outputPath + "JsonFiles"
                };
                as400JsonGeneration.TransformText();
            }

            Console.WriteLine(tableName + " Json generation is completed");
        }
    }
}
