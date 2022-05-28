import { HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CookieService } from 'ngx-cookie-service';

@Injectable()
export class cookieHelper {
  constructor(private cookie: CookieService) {}

  public setCookie(username: string) {
    this.cookie.set('X-UserName', username);
  }

  public getCookie() {
    return this.cookie.get('X-UserName');
  }

  public closeToken() {
    this.cookie.delete('X-UserName');
  }
}
