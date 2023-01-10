insert into TicketHistory(PersonId,RouteId)
values(2,1),
(2,2),
(2,1)

SET IDENTITY_INSERT Routes ON;
insert into Routes(RouteId)
values(1),(2)


select count(R.RouteId) as 'numar calatorii', R.RouteId 
from Person as P
inner join TicketHistory as T on P.PersonId = T.PersonId
inner join Routes as R on T.RouteId = R.RouteId
group by R.RouteId


