using System;
using Skyline.DataMiner.Analytics.GenericInterface;

[GQIMetaData(Name = "DateTime Format")]
public class MyCustomOperator : IGQIRowOperator, IGQIInputArguments
{
	private GQIColumnDropdownArgument _dateColumnArg = new GQIColumnDropdownArgument("Date column") { IsRequired = true, Types = new GQIColumnType[] { GQIColumnType.DateTime } };
	private GQIStringArgument _formatArg = new GQIStringArgument("Format") { IsRequired = true, DefaultValue = "dd/MM/yyyy hh:MM:ss" };

	private string _format;
	private GQIColumn _dateColumn;

	public GQIArgument[] GetInputArguments()
	{
		return new GQIArgument[] { _dateColumnArg, _formatArg };
	}

	public OnArgumentsProcessedOutputArgs OnArgumentsProcessed(OnArgumentsProcessedInputArgs args)
	{
		_dateColumn = args.GetArgumentValue(_dateColumnArg);
		_format = args.GetArgumentValue(_formatArg);

		return new OnArgumentsProcessedOutputArgs();
	}

	public void HandleRow(GQIEditableRow row)
	{
		try
		{
			DateTime dt = row.GetValue<DateTime>(_dateColumn);
			row.SetDisplayValue(_dateColumn, dt.ToLocalTime().ToString(_format));
		}
		catch (Exception)
		{
			// Catch empty cells
		}
	}
}