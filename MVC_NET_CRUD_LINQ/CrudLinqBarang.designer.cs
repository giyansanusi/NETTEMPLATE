﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_NET_CRUD_LINQ
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TemplateDB")]
	public partial class CrudLinqBarangDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBARANG(BARANG instance);
    partial void UpdateBARANG(BARANG instance);
    partial void DeleteBARANG(BARANG instance);
    partial void InsertNOTA(NOTA instance);
    partial void UpdateNOTA(NOTA instance);
    partial void DeleteNOTA(NOTA instance);
    partial void InsertTRANSAKSI(TRANSAKSI instance);
    partial void UpdateTRANSAKSI(TRANSAKSI instance);
    partial void DeleteTRANSAKSI(TRANSAKSI instance);
    #endregion
		
		public CrudLinqBarangDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TemplateDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CrudLinqBarangDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CrudLinqBarangDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CrudLinqBarangDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CrudLinqBarangDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BARANG> BARANGs
		{
			get
			{
				return this.GetTable<BARANG>();
			}
		}
		
		public System.Data.Linq.Table<NOTA> NOTAs
		{
			get
			{
				return this.GetTable<NOTA>();
			}
		}
		
		public System.Data.Linq.Table<TRANSAKSI> TRANSAKSIs
		{
			get
			{
				return this.GetTable<TRANSAKSI>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BARANG")]
	public partial class BARANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDBARANG;
		
		private string _NAMABARANG;
		
		private double _HARGABARANG;
		
		private string _DESKRIPSI;
		
		private EntitySet<TRANSAKSI> _TRANSAKSIs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDBARANGChanging(int value);
    partial void OnIDBARANGChanged();
    partial void OnNAMABARANGChanging(string value);
    partial void OnNAMABARANGChanged();
    partial void OnHARGABARANGChanging(double value);
    partial void OnHARGABARANGChanged();
    partial void OnDESKRIPSIChanging(string value);
    partial void OnDESKRIPSIChanged();
    #endregion
		
		public BARANG()
		{
			this._TRANSAKSIs = new EntitySet<TRANSAKSI>(new Action<TRANSAKSI>(this.attach_TRANSAKSIs), new Action<TRANSAKSI>(this.detach_TRANSAKSIs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBARANG", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int IDBARANG
		{
			get
			{
				return this._IDBARANG;
			}
			set
			{
				if ((this._IDBARANG != value))
				{
					this.OnIDBARANGChanging(value);
					this.SendPropertyChanging();
					this._IDBARANG = value;
					this.SendPropertyChanged("IDBARANG");
					this.OnIDBARANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NAMABARANG", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string NAMABARANG
		{
			get
			{
				return this._NAMABARANG;
			}
			set
			{
				if ((this._NAMABARANG != value))
				{
					this.OnNAMABARANGChanging(value);
					this.SendPropertyChanging();
					this._NAMABARANG = value;
					this.SendPropertyChanged("NAMABARANG");
					this.OnNAMABARANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HARGABARANG", DbType="Float NOT NULL")]
		public double HARGABARANG
		{
			get
			{
				return this._HARGABARANG;
			}
			set
			{
				if ((this._HARGABARANG != value))
				{
					this.OnHARGABARANGChanging(value);
					this.SendPropertyChanging();
					this._HARGABARANG = value;
					this.SendPropertyChanged("HARGABARANG");
					this.OnHARGABARANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DESKRIPSI", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string DESKRIPSI
		{
			get
			{
				return this._DESKRIPSI;
			}
			set
			{
				if ((this._DESKRIPSI != value))
				{
					this.OnDESKRIPSIChanging(value);
					this.SendPropertyChanging();
					this._DESKRIPSI = value;
					this.SendPropertyChanged("DESKRIPSI");
					this.OnDESKRIPSIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BARANG_TRANSAKSI", Storage="_TRANSAKSIs", ThisKey="IDBARANG", OtherKey="IDBARANG")]
		public EntitySet<TRANSAKSI> TRANSAKSIs
		{
			get
			{
				return this._TRANSAKSIs;
			}
			set
			{
				this._TRANSAKSIs.Assign(value);
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
		
		private void attach_TRANSAKSIs(TRANSAKSI entity)
		{
			this.SendPropertyChanging();
			entity.BARANG = this;
		}
		
		private void detach_TRANSAKSIs(TRANSAKSI entity)
		{
			this.SendPropertyChanging();
			entity.BARANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NOTA")]
	public partial class NOTA : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDNOTA;
		
		private System.Nullable<System.DateTime> _TANGGALBELI;
		
		private string _KETERANGAN;
		
		private string _IDTRANSAKSI;
		
		private EntityRef<TRANSAKSI> _TRANSAKSI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDNOTAChanging(string value);
    partial void OnIDNOTAChanged();
    partial void OnTANGGALBELIChanging(System.Nullable<System.DateTime> value);
    partial void OnTANGGALBELIChanged();
    partial void OnKETERANGANChanging(string value);
    partial void OnKETERANGANChanged();
    partial void OnIDTRANSAKSIChanging(string value);
    partial void OnIDTRANSAKSIChanged();
    #endregion
		
		public NOTA()
		{
			this._TRANSAKSI = default(EntityRef<TRANSAKSI>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDNOTA", DbType="Char(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDNOTA
		{
			get
			{
				return this._IDNOTA;
			}
			set
			{
				if ((this._IDNOTA != value))
				{
					this.OnIDNOTAChanging(value);
					this.SendPropertyChanging();
					this._IDNOTA = value;
					this.SendPropertyChanged("IDNOTA");
					this.OnIDNOTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TANGGALBELI", DbType="DateTime")]
		public System.Nullable<System.DateTime> TANGGALBELI
		{
			get
			{
				return this._TANGGALBELI;
			}
			set
			{
				if ((this._TANGGALBELI != value))
				{
					this.OnTANGGALBELIChanging(value);
					this.SendPropertyChanging();
					this._TANGGALBELI = value;
					this.SendPropertyChanged("TANGGALBELI");
					this.OnTANGGALBELIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KETERANGAN", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string KETERANGAN
		{
			get
			{
				return this._KETERANGAN;
			}
			set
			{
				if ((this._KETERANGAN != value))
				{
					this.OnKETERANGANChanging(value);
					this.SendPropertyChanging();
					this._KETERANGAN = value;
					this.SendPropertyChanged("KETERANGAN");
					this.OnKETERANGANChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDTRANSAKSI", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string IDTRANSAKSI
		{
			get
			{
				return this._IDTRANSAKSI;
			}
			set
			{
				if ((this._IDTRANSAKSI != value))
				{
					if (this._TRANSAKSI.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDTRANSAKSIChanging(value);
					this.SendPropertyChanging();
					this._IDTRANSAKSI = value;
					this.SendPropertyChanged("IDTRANSAKSI");
					this.OnIDTRANSAKSIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TRANSAKSI_NOTA", Storage="_TRANSAKSI", ThisKey="IDTRANSAKSI", OtherKey="IDTRANSAKSI", IsForeignKey=true)]
		public TRANSAKSI TRANSAKSI
		{
			get
			{
				return this._TRANSAKSI.Entity;
			}
			set
			{
				TRANSAKSI previousValue = this._TRANSAKSI.Entity;
				if (((previousValue != value) 
							|| (this._TRANSAKSI.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TRANSAKSI.Entity = null;
						previousValue.NOTAs.Remove(this);
					}
					this._TRANSAKSI.Entity = value;
					if ((value != null))
					{
						value.NOTAs.Add(this);
						this._IDTRANSAKSI = value.IDTRANSAKSI;
					}
					else
					{
						this._IDTRANSAKSI = default(string);
					}
					this.SendPropertyChanged("TRANSAKSI");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TRANSAKSI")]
	public partial class TRANSAKSI : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _IDTRANSAKSI;
		
		private int _JUMLAHBELI;
		
		private double _HARGABELI;
		
		private double _HARGAJUAL;
		
		private int _IDBARANG;
		
		private EntitySet<NOTA> _NOTAs;
		
		private EntityRef<BARANG> _BARANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDTRANSAKSIChanging(string value);
    partial void OnIDTRANSAKSIChanged();
    partial void OnJUMLAHBELIChanging(int value);
    partial void OnJUMLAHBELIChanged();
    partial void OnHARGABELIChanging(double value);
    partial void OnHARGABELIChanged();
    partial void OnHARGAJUALChanging(double value);
    partial void OnHARGAJUALChanged();
    partial void OnIDBARANGChanging(int value);
    partial void OnIDBARANGChanged();
    #endregion
		
		public TRANSAKSI()
		{
			this._NOTAs = new EntitySet<NOTA>(new Action<NOTA>(this.attach_NOTAs), new Action<NOTA>(this.detach_NOTAs));
			this._BARANG = default(EntityRef<BARANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDTRANSAKSI", DbType="NChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string IDTRANSAKSI
		{
			get
			{
				return this._IDTRANSAKSI;
			}
			set
			{
				if ((this._IDTRANSAKSI != value))
				{
					this.OnIDTRANSAKSIChanging(value);
					this.SendPropertyChanging();
					this._IDTRANSAKSI = value;
					this.SendPropertyChanged("IDTRANSAKSI");
					this.OnIDTRANSAKSIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JUMLAHBELI", DbType="Int NOT NULL")]
		public int JUMLAHBELI
		{
			get
			{
				return this._JUMLAHBELI;
			}
			set
			{
				if ((this._JUMLAHBELI != value))
				{
					this.OnJUMLAHBELIChanging(value);
					this.SendPropertyChanging();
					this._JUMLAHBELI = value;
					this.SendPropertyChanged("JUMLAHBELI");
					this.OnJUMLAHBELIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HARGABELI", DbType="Float NOT NULL")]
		public double HARGABELI
		{
			get
			{
				return this._HARGABELI;
			}
			set
			{
				if ((this._HARGABELI != value))
				{
					this.OnHARGABELIChanging(value);
					this.SendPropertyChanging();
					this._HARGABELI = value;
					this.SendPropertyChanged("HARGABELI");
					this.OnHARGABELIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HARGAJUAL", DbType="Float NOT NULL")]
		public double HARGAJUAL
		{
			get
			{
				return this._HARGAJUAL;
			}
			set
			{
				if ((this._HARGAJUAL != value))
				{
					this.OnHARGAJUALChanging(value);
					this.SendPropertyChanging();
					this._HARGAJUAL = value;
					this.SendPropertyChanged("HARGAJUAL");
					this.OnHARGAJUALChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDBARANG", DbType="Int NOT NULL")]
		public int IDBARANG
		{
			get
			{
				return this._IDBARANG;
			}
			set
			{
				if ((this._IDBARANG != value))
				{
					if (this._BARANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDBARANGChanging(value);
					this.SendPropertyChanging();
					this._IDBARANG = value;
					this.SendPropertyChanged("IDBARANG");
					this.OnIDBARANGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TRANSAKSI_NOTA", Storage="_NOTAs", ThisKey="IDTRANSAKSI", OtherKey="IDTRANSAKSI")]
		public EntitySet<NOTA> NOTAs
		{
			get
			{
				return this._NOTAs;
			}
			set
			{
				this._NOTAs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="BARANG_TRANSAKSI", Storage="_BARANG", ThisKey="IDBARANG", OtherKey="IDBARANG", IsForeignKey=true)]
		public BARANG BARANG
		{
			get
			{
				return this._BARANG.Entity;
			}
			set
			{
				BARANG previousValue = this._BARANG.Entity;
				if (((previousValue != value) 
							|| (this._BARANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._BARANG.Entity = null;
						previousValue.TRANSAKSIs.Remove(this);
					}
					this._BARANG.Entity = value;
					if ((value != null))
					{
						value.TRANSAKSIs.Add(this);
						this._IDBARANG = value.IDBARANG;
					}
					else
					{
						this._IDBARANG = default(int);
					}
					this.SendPropertyChanged("BARANG");
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
		
		private void attach_NOTAs(NOTA entity)
		{
			this.SendPropertyChanging();
			entity.TRANSAKSI = this;
		}
		
		private void detach_NOTAs(NOTA entity)
		{
			this.SendPropertyChanging();
			entity.TRANSAKSI = null;
		}
	}
}
#pragma warning restore 1591
