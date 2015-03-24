using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.Collections.Specialized;
using System.Collections.Generic;

namespace testDynamicProperty
{
    interface ICustomClass
    {
        PropertyList PublicProperties
        {
            get;
            set;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Class1 c = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            c.PublicProperties.Add(new myProperty("bEmpty", "Generali"));
            c.PublicProperties.Add(new myProperty("cColor", "Generali"));
            c.PublicProperties.Add(new myProperty("test3", "Prova"));

            propertyGrid1.SelectedObject = c;
        }
    }

    #region Property
    public class PropertyList : NameObjectCollectionBase
    {
        List<string> lstName = new List<string>();
        public PropertyList()
        {
        }
        ~PropertyList()
        {
            foreach (String strItem in lstName)
            {
                Remove(strItem);
            }
        }
        public void Add(Object value)
        {
            //The key for the object is taken from the object to insert
            this.BaseAdd(((myProperty)value).Name, value);
        }

        public void Remove(String key)
        {
            this.BaseRemove(key);
        }

        public void Remove(int index)
        {
            this.BaseRemoveAt(index);
        }

        public void Clear()
        {
            this.BaseClear();
        }

        public myProperty this[String key]
        {
            get
            {
                return (myProperty)(this.BaseGet(key));
            }
            set
            {
                this.BaseSet(key, value);
            }
        }

        public myProperty this[int indice]
        {
            get
            {
                return (myProperty)(this.BaseGet(indice));
            }
            set
            {
                this.BaseSet(indice, value);
            }
        }

    }
    public class myProperty
    {
        string name = string.Empty;
        string category = string.Empty;

        public myProperty()
        {
        }

        public myProperty(string pname, string pcat)
        {
            name = pname;
            category = pcat;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
    }

    public class Class1 : ICustomClass
    {

        int Test;
        int Test2;
        int Test3;

        bool _bEmpty = false;
        Color _cColor = Color.Blue;

        PropertyList publicproperties = new PropertyList();


        //[DisplayName("1"), Browsable(true), CategoryAttribute("2"), DescriptionAttribute("Empty"),
        //        TypeConverter(typeof(CEmptyOrNot))]
        public bool bEmpty { get { return _bEmpty; } set { _bEmpty = value; } }
        public Color cColor { get { return _cColor; } set { _cColor = value; } }
        //class CEmptyOrNot : BooleanConverter
        //{
        //    public override object ConvertTo(ITypeDescriptorContext context,
        //        System.Globalization.CultureInfo culture,
        //        object value,
        //        Type destinationType)
        //    {
        //        return (bool)value ? "Empty" : "Fill";
        //        //return base.ConvertTo(context, culture, value, destinationType);
        //    }
        //    public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        //    {
        //        return ((string)value == "Empty");
        //        //return base.ConvertFrom(context, culture, value);
        //    }
        //}

        public int test
        {

            get
            {
                return Test;
            }
            set
            {
                Test = value;
            }
        }

        public int test2
        {
            get
            {
                return Test2;
            }
            set
            {
                Test2 = value;
            }
        }

        public int test3
        {
            get
            {
                return Test3;
            }
            set
            {
                Test3 = value;
            }
        }


        //ICustomClass implementation
        public PropertyList PublicProperties
        {
            get
            {
                return publicproperties;
            }
            set
            {
                publicproperties = value;
            }
        }
    }
    #endregion Property
}
