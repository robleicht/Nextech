import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HackerNewsService {
  apiURL = 'https://localhost:44359/';
  constructor(private http: HttpClient) {

   }
   getNewStories()
   {
     return this.http.get(`${this.apiURL}hackernews`);
   }
   getArticle(id: number) {
      return this.http.get(`${this.apiURL}hackernews/${id}`);
   }
}
