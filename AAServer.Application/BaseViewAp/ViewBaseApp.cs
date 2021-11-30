using System;
using System.Reflection;

namespace AAServer.Application.BaseViewAp
{
    public abstract class ViewBaseApp<T> where T : class
    {
        public static T NewSelect(object obj)
        {
            var typeObj = obj.GetType();
            var typeNewClass = typeof(T);
            var newClass = (T)Activator.CreateInstance(typeNewClass);

            PropertyInfo[] propertisNewClass = typeNewClass.GetProperties();
            PropertyInfo[] propertiesObj = typeObj.GetProperties();

            foreach (var propertyNewClass in propertisNewClass)
            {
                foreach (var propertyObj in propertiesObj)
                {
                    if (propertyNewClass.Name == propertyObj.Name)
                    {

                        PropertyInfo property = typeObj.GetProperty(propertyObj.Name);
                        var propertyValue = property.GetValue(obj, null);

                        PropertyInfo propertySet = typeNewClass.GetProperty(propertyNewClass.Name);
                        propertySet.SetValue(newClass, propertyValue, null);
                    }
                }
            }

            return newClass;
        }
    }
}
