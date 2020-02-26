import { Component } from '@angular/core';
import { HackerNewsService } from 'src/app/services/hacker-news.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent {
  originalStories: Story[];
  filteredStories: Story[];
  constructor(public hackerNewsService: HackerNewsService) {
    this.hackerNewsService.getNewStories().subscribe((x: Story[]) => {
      this.filteredStories = x;
      this.originalStories = x;
    });
  }
  public searchHackerNews(event: any) {
    const searchString = event.target.value;
    if (searchString) {
      this.filteredStories = [];
      this.originalStories.forEach(x => {
        if (x.title.toLocaleLowerCase().includes(searchString) || x.author.toLocaleLowerCase().includes(searchString)) {
          this.filteredStories.push(x);
        }
      });
    } else {
      this.filteredStories = Object.assign([], this.originalStories);
    }
  }
  public getHackerNewsArticle(event: any) {

  }
}
