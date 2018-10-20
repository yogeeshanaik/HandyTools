using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

public static class Extensions
{
    public static void Invoke(this Control Control, Action Action)
    {
        Control.Invoke(Action);
    }

    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
        {
            action(item);
        }
    }
}

public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }
}

public static class ObjectExtension

{
    public static object CloneObject(this object objSource)

    {
        //Get the type of source object and create a new instance of that type

        Type typeSource = objSource.GetType();

        object objTarget = Activator.CreateInstance(typeSource);

        //Get all the properties of source object type

        PropertyInfo[] propertyInfo = typeSource.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        //Assign all source property to taget object 's properties

        foreach (PropertyInfo property in propertyInfo)

        {
            //Check whether property can be written to

            if (property.CanWrite)

            {
                //check whether property type is value type, enum or string type

                if (property.PropertyType.IsValueType || property.PropertyType.IsEnum || property.PropertyType.Equals(typeof(System.String)))

                {
                    property.SetValue(objTarget, property.GetValue(objSource, null), null);
                }

                //else property type is object/complex types, so need to recursively call this method until the end of the tree is reached
                else

                {
                    object objPropertyValue = property.GetValue(objSource, null);

                    if (objPropertyValue == null)

                    {
                        property.SetValue(objTarget, null, null);
                    }
                    else

                    {
                        property.SetValue(objTarget, objPropertyValue.CloneObject(), null);
                    }
                }
            }
        }

        return objTarget;
    }
}