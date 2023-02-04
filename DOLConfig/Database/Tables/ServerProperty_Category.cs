﻿using DOL.Database.Attributes;

namespace DOL.Database
{
	[DataTable(TableName = "serverproperty_category")]
	public class ServerPropertyCategory: DataObject
	{
		[DataElement(AllowDbNull = false)]
		public string BaseCategory { get; set;} = null;

		[DataElement(AllowDbNull = true)]
		public string ParentCategory { get; set;} = null;
		
		[DataElement(AllowDbNull = false)]
		public string DisplayName { get; set;} = null;
	}
}
