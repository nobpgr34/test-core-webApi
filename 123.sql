
select  clients.id, clients.Name, clients.Amount- b.SB  as AmountB
from clients
inner join (select ClientId, sum(Amount) as SB from Trnsactions group by ClientId) b on clients.Id = b.ClientId;
  