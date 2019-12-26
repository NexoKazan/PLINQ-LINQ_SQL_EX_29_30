﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LINQ
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="linq")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertIncome(Income instance);
    partial void UpdateIncome(Income instance);
    partial void DeleteIncome(Income instance);
    partial void InsertIncome_o(Income_o instance);
    partial void UpdateIncome_o(Income_o instance);
    partial void DeleteIncome_o(Income_o instance);
    partial void InsertOutcome(Outcome instance);
    partial void UpdateOutcome(Outcome instance);
    partial void DeleteOutcome(Outcome instance);
    partial void InsertOutcome_o(Outcome_o instance);
    partial void UpdateOutcome_o(Outcome_o instance);
    partial void DeleteOutcome_o(Outcome_o instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::LINQ.Properties.Settings.Default.linqConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Income> Income
		{
			get
			{
				return this.GetTable<Income>();
			}
		}
		
		public System.Data.Linq.Table<Income_o> Income_o
		{
			get
			{
				return this.GetTable<Income_o>();
			}
		}
		
		public System.Data.Linq.Table<Outcome> Outcome
		{
			get
			{
				return this.GetTable<Outcome>();
			}
		}
		
		public System.Data.Linq.Table<Outcome_o> Outcome_o
		{
			get
			{
				return this.GetTable<Outcome_o>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Income")]
	public partial class Income : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _code;
		
		private byte _point;
		
		private System.DateTime _date;
		
		private decimal _inc;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodeChanging(int value);
    partial void OncodeChanged();
    partial void OnpointChanging(byte value);
    partial void OnpointChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnincChanging(decimal value);
    partial void OnincChanged();
    #endregion
		
		public Income()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((this._code != value))
				{
					this.OncodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("code");
					this.OncodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point", DbType="TinyInt NOT NULL")]
		public byte point
		{
			get
			{
				return this._point;
			}
			set
			{
				if ((this._point != value))
				{
					this.OnpointChanging(value);
					this.SendPropertyChanging();
					this._point = value;
					this.SendPropertyChanged("point");
					this.OnpointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inc", DbType="Decimal(12,2) NOT NULL")]
		public decimal inc
		{
			get
			{
				return this._inc;
			}
			set
			{
				if ((this._inc != value))
				{
					this.OnincChanging(value);
					this.SendPropertyChanging();
					this._inc = value;
					this.SendPropertyChanged("inc");
					this.OnincChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Income_o")]
	public partial class Income_o : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _point;
		
		private System.DateTime _date;
		
		private decimal _inc;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpointChanging(byte value);
    partial void OnpointChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnincChanging(decimal value);
    partial void OnincChanged();
    #endregion
		
		public Income_o()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte point
		{
			get
			{
				return this._point;
			}
			set
			{
				if ((this._point != value))
				{
					this.OnpointChanging(value);
					this.SendPropertyChanging();
					this._point = value;
					this.SendPropertyChanged("point");
					this.OnpointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_inc", DbType="Decimal(12,2) NOT NULL")]
		public decimal inc
		{
			get
			{
				return this._inc;
			}
			set
			{
				if ((this._inc != value))
				{
					this.OnincChanging(value);
					this.SendPropertyChanging();
					this._inc = value;
					this.SendPropertyChanged("inc");
					this.OnincChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Outcome")]
	public partial class Outcome : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _code;
		
		private byte _point;
		
		private System.DateTime _date;
		
		private decimal _out;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodeChanging(int value);
    partial void OncodeChanged();
    partial void OnpointChanging(byte value);
    partial void OnpointChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnoutChanging(decimal value);
    partial void OnoutChanged();
    #endregion
		
		public Outcome()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_code", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int code
		{
			get
			{
				return this._code;
			}
			set
			{
				if ((this._code != value))
				{
					this.OncodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("code");
					this.OncodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point", DbType="TinyInt NOT NULL")]
		public byte point
		{
			get
			{
				return this._point;
			}
			set
			{
				if ((this._point != value))
				{
					this.OnpointChanging(value);
					this.SendPropertyChanging();
					this._point = value;
					this.SendPropertyChanged("point");
					this.OnpointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL")]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="out", Storage="_out", DbType="Decimal(12,2) NOT NULL")]
		public decimal @out
		{
			get
			{
				return this._out;
			}
			set
			{
				if ((this._out != value))
				{
					this.OnoutChanging(value);
					this.SendPropertyChanging();
					this._out = value;
					this.SendPropertyChanged("@out");
					this.OnoutChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Outcome_o")]
	public partial class Outcome_o : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private byte _point;
		
		private System.DateTime _date;
		
		private decimal _out;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpointChanging(byte value);
    partial void OnpointChanged();
    partial void OndateChanging(System.DateTime value);
    partial void OndateChanged();
    partial void OnoutChanging(decimal value);
    partial void OnoutChanged();
    #endregion
		
		public Outcome_o()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point", DbType="TinyInt NOT NULL", IsPrimaryKey=true)]
		public byte point
		{
			get
			{
				return this._point;
			}
			set
			{
				if ((this._point != value))
				{
					this.OnpointChanging(value);
					this.SendPropertyChanging();
					this._point = value;
					this.SendPropertyChanged("point");
					this.OnpointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date", DbType="DateTime NOT NULL", IsPrimaryKey=true)]
		public System.DateTime date
		{
			get
			{
				return this._date;
			}
			set
			{
				if ((this._date != value))
				{
					this.OndateChanging(value);
					this.SendPropertyChanging();
					this._date = value;
					this.SendPropertyChanged("date");
					this.OndateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="out", Storage="_out", DbType="Decimal(12,2) NOT NULL")]
		public decimal @out
		{
			get
			{
				return this._out;
			}
			set
			{
				if ((this._out != value))
				{
					this.OnoutChanging(value);
					this.SendPropertyChanging();
					this._out = value;
					this.SendPropertyChanged("@out");
					this.OnoutChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
