using System;

namespace Samples
{
public static class DateTimeExtensions
{
//Returns the last date of a month
public static DateTime LastDay(this DateTime dateTime)
{
	int year = dateTime.Year;
	int month = dateTime.Month;
	int lastDay = DateTime.DaysInMonth(year,month);
	return new DateTime(year,month,lastDay);
}
//Returns true if the this Date is later than the parameter
//otherwise it returns false
public static bool After(this DateTime firstDateTime,
		DateTime secondDateTime)
{
	int result = DateTime.Compare(firstDateTime,secondDateTime);
	if(result > 0)
		return true;
	return false;
}
}
}
