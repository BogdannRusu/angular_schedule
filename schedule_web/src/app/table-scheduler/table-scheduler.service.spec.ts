import { TestBed } from '@angular/core/testing';

describe('TableSchedulerService', () => {
  let service: TableSchedulerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TableSchedulerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
