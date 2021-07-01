Реверс-инжинеринг базы
```
Scaffold-DbContext "Data Source=;Initial Catalog=;User ID=;Password=" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
```
Все переходы делать через роут `MudNavLink` или 
```
      <NavLink class="nav-link" href="" Match="NavLinkMatch.All">
        <span class="oi oi-home" aria-hidden="true"></span> Главная
      </NavLink>
```
Hot Reload : `dotnet watch run debug`