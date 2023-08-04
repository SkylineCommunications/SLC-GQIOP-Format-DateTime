# SLC-GQIOP-Format DateTime
A GQI Operator to Format a datetime column to a custom format.

## Configuration

The operator needs a datetime column and a format as inputs. [See the Standard date and time format strings reference page on learn.microsoft.com](https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings) The default format is "dd/MM/yyyy hh:MM:ss".

> [!NOTE]
> The returned display value will have the timezone offset of the server. This is different than the default displayvalue of a datetime, where the timezone of the client is used.

![Operator](/Documentation/Operator.png)