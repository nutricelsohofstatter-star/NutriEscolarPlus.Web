using Microsoft.AspNetCore.Components;
namespace NutriEscolarPlus.Web.Components.Account;
internal sealed class IdentityRedirectManager(NavigationManager navigationManager){public void RedirectTo(string? uri){uri ??="";navigationManager.NavigateTo(uri);} public void RedirectToWithStatus(string uri,string message,HttpContext context)=>navigationManager.NavigateTo(uri); public void RedirectToCurrentPage()=>navigationManager.NavigateTo(navigationManager.Uri); public void RedirectToCurrentPageWithStatus(string message,HttpContext context)=>navigationManager.NavigateTo(navigationManager.Uri);}
