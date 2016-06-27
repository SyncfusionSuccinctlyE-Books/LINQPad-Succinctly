<Query Kind="Expression">
  <Connection>
    <ID>4dbf890a-9be0-431c-a6d4-4bb20c1ba604</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>sa</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAApIpboxkMi0KXQm107ZYAoQAAAAACAAAAAAAQZgAAAAEAACAAAADdjRylNWoymuJ4gbmgPQgfMFr1PooNmcD3wfZviEVW3QAAAAAOgAAAAAIAACAAAADE6tComfTnfJ/vn8LgxcYRUyRtOIOmztt8luz6FzRMohAAAAAa5ENguOQMGdGZdrnVXQi0QAAAALj09Vdcv09hYQIHq/niC9ydeO4NMEUvl8BpUNFKq4hYdG7sRBPTIOFe2a7M55OueQV5T916HCR6MaMom1sOSIA=</Password>
    <Database>uspostalcodes</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

Places.Where(row => row.County_id == 1926)
