import { TestBed } from '@angular/core/testing';

import { HackerNewsService } from './hacker-news.service';

describe('HackerNewsServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: HackerNewsService = TestBed.get(HackerNewsService);
    expect(service).toBeTruthy();
  });
});
