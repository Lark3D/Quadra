using QuadraCore.Models;
using QuadraResources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace QuadraCore.Helpers
{
    public static class ElementParameters
    {
        private const string _xmlFile = @"Data\ElementParameters.xml";
        private const string _resource = @"QuadraCore.Content.ElementParameters.xml";

        private static Dictionary<string, Dictionary<string, ParameterDescription>> _parameters = null;

        public static Dictionary<string, ParameterDescription> GetParameterDescriptions(string code)
        {
            if (_parameters == null) Load();
            if (!_parameters.ContainsKey(code)) return null;
            return _parameters[code];
        }

        private static void Load()
        {
            try
            {
                if (!File.Exists(_xmlFile)) RecoverFile();

                var result = new Dictionary<string, Dictionary<string, ParameterDescription>>();

                var parameters = XDocument.Load(_xmlFile).Element("Parameters");
                foreach (var element in parameters.Elements("Element"))
                {
                    var elp = new Dictionary<string, ParameterDescription>();
                    string code = (string)element.Attribute("Code");

                    foreach (var parameter in element.Elements("Parameter"))
                    {
                        var pd = new ParameterDescription();
                        pd.Name = (string)parameter.Attribute("Name");
                        switch ((string)parameter.Element("Type"))
                        {
                            case "string": pd.Type = typeof(string); break;
                            case "double": pd.Type = typeof(double); break;
                            case "int": pd.Type = typeof(int); break;
                            case "bool": pd.Type = typeof(bool); break;
                            default: pd.Type = typeof(object); break;
                        }
                        pd.Text = (string)parameter.Element("Text");
                        pd.Description = (string)parameter.Element("Description");
                        pd.DefaultValue = StringToObject(pd.Type, parameter.Element("DefaultValue").Value);
                        pd.MaxValue = (double?)parameter.Element("MaxValue");
                        pd.MinValue = (double?)parameter.Element("MinValue");
                        pd.MaxLength = (int?)parameter.Element("MaxLength");
                        XElement xe = parameter.Element("PossibleValues");
                        if (xe != null)
                        {
                            pd.PossibleValues = new List<object>();
                            foreach (var v in xe.Elements("Value"))
                                pd.PossibleValues.Add(StringToObject(pd.Type, v.Value));
                        }

                        if (!string.IsNullOrEmpty(pd.Name)) elp[pd.Name] = pd;
                    }

                    if (!string.IsNullOrEmpty(code)) result[code] = elp;
                }

                _parameters = result;
            }
            catch (Exception e)
            {
                string msg = string.Format(Messages.ErrorLoadingElementParameters, _xmlFile);
                Log.Error(msg, e);
                throw e;
            }
        }

        private static object StringToObject(Type type, string str)
        {
            if (type == typeof(string)) return str;
            else if (type == typeof(double)) return double.Parse(str, CultureInfo.InvariantCulture);
            else if (type == typeof(int)) return int.Parse(str, CultureInfo.InvariantCulture);
            else if (type == typeof(bool)) return bool.Parse(str);
            else return str;
        }

        private static void RecoverFile()
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                using (Stream stream = assembly.GetManifestResourceStream(_resource))
                    using (FileStream fs = File.OpenWrite(_xmlFile))
                        stream.CopyTo(fs);
            }
            catch (Exception e)
            {
                string msg = string.Format(Messages.UnableToCreateFile, _xmlFile);
                Log.Error(msg, e);
                throw e;
            }
        }
    }
}
