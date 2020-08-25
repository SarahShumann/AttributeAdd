import { TestBed } from '@angular/core/testing';

import { AttSerService } from './att-ser.service';

describe('AttSerService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: AttSerService = TestBed.get(AttSerService);
    expect(service).toBeTruthy();
  });
});
