﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ClassListModel", "FK_Students_Classes", "Classes", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MVCmini.Models.Class), "Students", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVCmini.Models.Student), true)]
[assembly: EdmRelationshipAttribute("ClassListModel", "FK_Presences_Presences", "Students", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(MVCmini.Models.Student), "Presences", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MVCmini.Models.Presence), true)]

#endregion

namespace MVCmini.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ClassListEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ClassListEntities object using the connection string found in the 'ClassListEntities' section of the application configuration file.
        /// </summary>
        public ClassListEntities() : base("name=ClassListEntities", "ClassListEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ClassListEntities object.
        /// </summary>
        public ClassListEntities(string connectionString) : base(connectionString, "ClassListEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ClassListEntities object.
        /// </summary>
        public ClassListEntities(EntityConnection connection) : base(connection, "ClassListEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Class> Classes
        {
            get
            {
                if ((_Classes == null))
                {
                    _Classes = base.CreateObjectSet<Class>("Classes");
                }
                return _Classes;
            }
        }
        private ObjectSet<Class> _Classes;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Presence> Presences
        {
            get
            {
                if ((_Presences == null))
                {
                    _Presences = base.CreateObjectSet<Presence>("Presences");
                }
                return _Presences;
            }
        }
        private ObjectSet<Presence> _Presences;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Classes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToClasses(Class @class)
        {
            base.AddObject("Classes", @class);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Presences EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPresences(Presence presence)
        {
            base.AddObject("Presences", presence);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Students EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ClassListModel", Name="Class")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Class : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Class object.
        /// </summary>
        /// <param name="classID">Initial value of the ClassID property.</param>
        /// <param name="className">Initial value of the ClassName property.</param>
        public static Class CreateClass(global::System.Int32 classID, global::System.String className)
        {
            Class @class = new Class();
            @class.ClassID = classID;
            @class.ClassName = className;
            return @class;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassID
        {
            get
            {
                return _ClassID;
            }
            set
            {
                if (_ClassID != value)
                {
                    OnClassIDChanging(value);
                    ReportPropertyChanging("ClassID");
                    _ClassID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ClassID");
                    OnClassIDChanged();
                }
            }
        }
        private global::System.Int32 _ClassID;
        partial void OnClassIDChanging(global::System.Int32 value);
        partial void OnClassIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ClassName
        {
            get
            {
                return _ClassName;
            }
            set
            {
                OnClassNameChanging(value);
                ReportPropertyChanging("ClassName");
                _ClassName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ClassName");
                OnClassNameChanged();
            }
        }
        private global::System.String _ClassName;
        partial void OnClassNameChanging(global::System.String value);
        partial void OnClassNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ClassDescription
        {
            get
            {
                return _ClassDescription;
            }
            set
            {
                OnClassDescriptionChanging(value);
                ReportPropertyChanging("ClassDescription");
                _ClassDescription = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ClassDescription");
                OnClassDescriptionChanged();
            }
        }
        private global::System.String _ClassDescription;
        partial void OnClassDescriptionChanging(global::System.String value);
        partial void OnClassDescriptionChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClassListModel", "FK_Students_Classes", "Students")]
        public EntityCollection<Student> Students
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Student>("ClassListModel.FK_Students_Classes", "Students");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Student>("ClassListModel.FK_Students_Classes", "Students", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ClassListModel", Name="Presence")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Presence : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Presence object.
        /// </summary>
        /// <param name="presenceID">Initial value of the PresenceID property.</param>
        /// <param name="studentID">Initial value of the StudentID property.</param>
        /// <param name="date">Initial value of the Date property.</param>
        /// <param name="value">Initial value of the Value property.</param>
        public static Presence CreatePresence(global::System.Int32 presenceID, global::System.Int32 studentID, global::System.DateTime date, global::System.Int32 value)
        {
            Presence presence = new Presence();
            presence.PresenceID = presenceID;
            presence.StudentID = studentID;
            presence.Date = date;
            presence.Value = value;
            return presence;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PresenceID
        {
            get
            {
                return _PresenceID;
            }
            set
            {
                if (_PresenceID != value)
                {
                    OnPresenceIDChanging(value);
                    ReportPropertyChanging("PresenceID");
                    _PresenceID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("PresenceID");
                    OnPresenceIDChanged();
                }
            }
        }
        private global::System.Int32 _PresenceID;
        partial void OnPresenceIDChanging(global::System.Int32 value);
        partial void OnPresenceIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                OnStudentIDChanging(value);
                ReportPropertyChanging("StudentID");
                _StudentID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StudentID");
                OnStudentIDChanged();
            }
        }
        private global::System.Int32 _StudentID;
        partial void OnStudentIDChanging(global::System.Int32 value);
        partial void OnStudentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Value
        {
            get
            {
                return _Value;
            }
            set
            {
                OnValueChanging(value);
                ReportPropertyChanging("Value");
                _Value = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Value");
                OnValueChanged();
            }
        }
        private global::System.Int32 _Value;
        partial void OnValueChanging(global::System.Int32 value);
        partial void OnValueChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClassListModel", "FK_Presences_Presences", "Students")]
        public Student Student
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Student>("ClassListModel.FK_Presences_Presences", "Students").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Student>("ClassListModel.FK_Presences_Presences", "Students").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Student> StudentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Student>("ClassListModel.FK_Presences_Presences", "Students");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Student>("ClassListModel.FK_Presences_Presences", "Students", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ClassListModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="studentID">Initial value of the StudentID property.</param>
        /// <param name="classID">Initial value of the ClassID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="surname">Initial value of the Surname property.</param>
        public static Student CreateStudent(global::System.Int32 studentID, global::System.Int32 classID, global::System.String name, global::System.String surname)
        {
            Student student = new Student();
            student.StudentID = studentID;
            student.ClassID = classID;
            student.Name = name;
            student.Surname = surname;
            return student;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                if (_StudentID != value)
                {
                    OnStudentIDChanging(value);
                    ReportPropertyChanging("StudentID");
                    _StudentID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("StudentID");
                    OnStudentIDChanged();
                }
            }
        }
        private global::System.Int32 _StudentID;
        partial void OnStudentIDChanging(global::System.Int32 value);
        partial void OnStudentIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassID
        {
            get
            {
                return _ClassID;
            }
            set
            {
                OnClassIDChanging(value);
                ReportPropertyChanging("ClassID");
                _ClassID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ClassID");
                OnClassIDChanged();
            }
        }
        private global::System.Int32 _ClassID;
        partial void OnClassIDChanging(global::System.Int32 value);
        partial void OnClassIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                OnSurnameChanging(value);
                ReportPropertyChanging("Surname");
                _Surname = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Surname");
                OnSurnameChanged();
            }
        }
        private global::System.String _Surname;
        partial void OnSurnameChanging(global::System.String value);
        partial void OnSurnameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> mark
        {
            get
            {
                return _mark;
            }
            set
            {
                OnmarkChanging(value);
                ReportPropertyChanging("mark");
                _mark = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("mark");
                OnmarkChanged();
            }
        }
        private Nullable<global::System.Int32> _mark;
        partial void OnmarkChanging(Nullable<global::System.Int32> value);
        partial void OnmarkChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClassListModel", "FK_Students_Classes", "Classes")]
        public Class Class
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("ClassListModel.FK_Students_Classes", "Classes").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("ClassListModel.FK_Students_Classes", "Classes").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Class> ClassReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Class>("ClassListModel.FK_Students_Classes", "Classes");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Class>("ClassListModel.FK_Students_Classes", "Classes", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ClassListModel", "FK_Presences_Presences", "Presences")]
        public EntityCollection<Presence> Presences
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Presence>("ClassListModel.FK_Presences_Presences", "Presences");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Presence>("ClassListModel.FK_Presences_Presences", "Presences", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
