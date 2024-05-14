// данная структура хранения данных очень не удобная и не соответствует нормальным формам бд 
// хранить данные в таком виде не стоит для удобства работы c базой данных и удобство развития приложения

//  грустная наивная версия:
    var query1 = from record in records 
                    where record.OprId="DEOVAL" 
                        && AttrId = 1 
                        && record.AttrValue = "123";
    var query2 = from record in records 
                    where query1.contains(record.RecId) 
                        && AttrId = 4 
                        && DateTime.Compare(DateTime(AttrValue), new DateTime("02.01.2022")) >= 0;

    var result_date = from record in records where query2.contains(record.RecId) && AttrId = 4;
    var result_value = from record in records where query1.contains(record.RecId) && AttrId = 1;

// параметризированная версия в один запрос, дело делает, но не читабельно
public List<type> query(string num, DateTime date)
{
    return  from record in records
                where record.OpdId == "DEOVAL" && record.AttrId == 1 && record.AttrValue == num
            join record2 in records on record.RecId equals record2.RecId
                where record2.AttrId == 4 && DateTime.Compare(DateTime.Parse(record2.AttrValue), date) >= 0
            select new { Date = record2.AttrValue, Value = record.AttrValue };
}

DateTime startDate = new DateTime(2022, 1, 2);
string pipeNumber = "123";
query(pipeNumber, startDate);


// добавим классов и более хорошие типы данных
public enum operation_type {
    DEOVAL,
    INSPECT
}

// это мог бы быть класс описание для того же entity framework
// после чего поиск записи становиться проще, как и редактура записей
// как в последующее расширение базы данных
public class record{
    public int id {get;}
    public operation_type operation_type {get; set;}
    public int? pipe_number {get; set;}
    public float? ovality {get; set;} 
    public string? NTD {get; set;}
    public DateTime? date {get; set;}
}

public List<record> ovality_history(int number, DateTime date = new DateTime(0,0,0))
{
    return from record in records 
                where record.operation_type == operation_type.DEOVAL
                    && record.pipe_number == number
                    && DateTime.Compare(DateTime.Parse(record2.AttrValue),date) >= 0;
}

DateTime startDate = new DateTime(2022, 1, 2);
string pipeNumber = "123";

var history = ovality_history(pipeNumber, startDate);

history.ForEach( x => Console.WriteLine($"Дата операции: {x.date} , Овальность: {x.ovality}"));


// прошу учесть что это писалось как тестовый файл из головы без проверок, так что тут могут быть небольшие опечатки и не точности
// которые могут поменать этому коду работать
