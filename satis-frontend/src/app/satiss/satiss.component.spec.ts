import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SatissComponent } from './satiss.component';

describe('SatissComponent', () => {
  let component: SatissComponent;
  let fixture: ComponentFixture<SatissComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SatissComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SatissComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
