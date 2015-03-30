﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetCoders.LINQtoSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProducoesArtisticas")]
	public partial class ProducoesArtisticasDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttbFilmes(tbFilmes instance);
    partial void UpdatetbFilmes(tbFilmes instance);
    partial void DeletetbFilmes(tbFilmes instance);
    partial void InserttbAtores(tbAtores instance);
    partial void UpdatetbAtores(tbAtores instance);
    partial void DeletetbAtores(tbAtores instance);
    #endregion
		
		public ProducoesArtisticasDataContext() : 
				base(global::NetCoders.LINQtoSQL.Properties.Settings.Default.ProducoesArtisticasConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProducoesArtisticasDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProducoesArtisticasDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProducoesArtisticasDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProducoesArtisticasDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbFilmes> tbFilmes
		{
			get
			{
				return this.GetTable<tbFilmes>();
			}
		}
		
		public System.Data.Linq.Table<tbAtores> tbAtores
		{
			get
			{
				return this.GetTable<tbAtores>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbFilmes")]
	public partial class tbFilmes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FilmeID;
		
		private string _Nome;
		
		private System.DateTime _Ano;
		
		private System.Nullable<decimal> _Preço;
		
		private string _Genero;
		
		private EntitySet<tbAtores> _tbAtores;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFilmeIDChanging(int value);
    partial void OnFilmeIDChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnAnoChanging(System.DateTime value);
    partial void OnAnoChanged();
    partial void OnPreçoChanging(System.Nullable<decimal> value);
    partial void OnPreçoChanged();
    partial void OnGeneroChanging(string value);
    partial void OnGeneroChanged();
    #endregion
		
		public tbFilmes()
		{
			this._tbAtores = new EntitySet<tbAtores>(new Action<tbAtores>(this.attach_tbAtores), new Action<tbAtores>(this.detach_tbAtores));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmeID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FilmeID
		{
			get
			{
				return this._FilmeID;
			}
			set
			{
				if ((this._FilmeID != value))
				{
					this.OnFilmeIDChanging(value);
					this.SendPropertyChanging();
					this._FilmeID = value;
					this.SendPropertyChanged("FilmeID");
					this.OnFilmeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ano", DbType="DateTime NOT NULL")]
		public System.DateTime Ano
		{
			get
			{
				return this._Ano;
			}
			set
			{
				if ((this._Ano != value))
				{
					this.OnAnoChanging(value);
					this.SendPropertyChanging();
					this._Ano = value;
					this.SendPropertyChanged("Ano");
					this.OnAnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Preço", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> Preço
		{
			get
			{
				return this._Preço;
			}
			set
			{
				if ((this._Preço != value))
				{
					this.OnPreçoChanging(value);
					this.SendPropertyChanging();
					this._Preço = value;
					this.SendPropertyChanged("Preço");
					this.OnPreçoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(15)")]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this.OnGeneroChanging(value);
					this.SendPropertyChanging();
					this._Genero = value;
					this.SendPropertyChanged("Genero");
					this.OnGeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbFilmes_tbAtore", Storage="_tbAtores", ThisKey="FilmeID", OtherKey="FilmeID")]
		public EntitySet<tbAtores> tbAtores
		{
			get
			{
				return this._tbAtores;
			}
			set
			{
				this._tbAtores.Assign(value);
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
		
		private void attach_tbAtores(tbAtores entity)
		{
			this.SendPropertyChanging();
			entity.tbFilmes = this;
		}
		
		private void detach_tbAtores(tbAtores entity)
		{
			this.SendPropertyChanging();
			entity.tbFilmes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbAtores")]
	public partial class tbAtores : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AtorID;
		
		private int _FilmeID;
		
		private string _Nome;
		
		private EntityRef<tbFilmes> _tbFilmes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAtorIDChanging(int value);
    partial void OnAtorIDChanged();
    partial void OnFilmeIDChanging(int value);
    partial void OnFilmeIDChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    #endregion
		
		public tbAtores()
		{
			this._tbFilmes = default(EntityRef<tbFilmes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AtorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AtorID
		{
			get
			{
				return this._AtorID;
			}
			set
			{
				if ((this._AtorID != value))
				{
					this.OnAtorIDChanging(value);
					this.SendPropertyChanging();
					this._AtorID = value;
					this.SendPropertyChanged("AtorID");
					this.OnAtorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmeID", DbType="Int NOT NULL")]
		public int FilmeID
		{
			get
			{
				return this._FilmeID;
			}
			set
			{
				if ((this._FilmeID != value))
				{
					if (this._tbFilmes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFilmeIDChanging(value);
					this.SendPropertyChanging();
					this._FilmeID = value;
					this.SendPropertyChanged("FilmeID");
					this.OnFilmeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbFilmes_tbAtore", Storage="_tbFilmes", ThisKey="FilmeID", OtherKey="FilmeID", IsForeignKey=true)]
		public tbFilmes tbFilmes
		{
			get
			{
				return this._tbFilmes.Entity;
			}
			set
			{
				tbFilmes previousValue = this._tbFilmes.Entity;
				if (((previousValue != value) 
							|| (this._tbFilmes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbFilmes.Entity = null;
						previousValue.tbAtores.Remove(this);
					}
					this._tbFilmes.Entity = value;
					if ((value != null))
					{
						value.tbAtores.Add(this);
						this._FilmeID = value.FilmeID;
					}
					else
					{
						this._FilmeID = default(int);
					}
					this.SendPropertyChanged("tbFilmes");
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
