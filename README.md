# Format-DateTime

## About

This package contains a GQI custom operator that reformats the values in a datetime column to a custom format.

## Configuration

The operator has to be provided with a datetime column and a format.

Default format: `dd/MM/yyyy hh:MM:ss`

For more information on possible datetime formats, see [Standard date and time format strings](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings).

![Operator](/Documentation/Operator.png)

> [!NOTE]
> Although, by default, datetime values are displayed in local time (i.e., the time of the client), datetime values returned by this custom operator will be displayed in DataMiner time (i.e., the time of the DataMiner server to which you are connected).
