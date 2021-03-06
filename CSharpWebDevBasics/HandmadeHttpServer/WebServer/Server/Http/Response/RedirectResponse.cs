﻿using WebServer.Server.Enums;

namespace WebServer.Server.Http.Response
{
    public class RedirectResponse : HttpResponse
    {
        public RedirectResponse(string redirectUrl)
        {
            this.StatusCode = HttpStatusCode.Found;

            this.Headers.Add(new HttpHeader("Location", redirectUrl));
        }
    }
}
