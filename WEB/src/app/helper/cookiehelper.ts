import { Injectable } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';

@Injectable()
export class cookieHelper {
  constructor(private _cookie: CookieService) {}

  public setCookie(username: string) {
    this._cookie.set('X-UserName', username);
  }

  public getCookie() {
    return this._cookie.get('X-UserName');
  }

  public closeToken() {
    this._cookie.delete('X-UserName');
  }
}
