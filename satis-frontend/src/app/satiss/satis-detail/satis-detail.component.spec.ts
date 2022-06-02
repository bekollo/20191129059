import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SatisDetailComponent } from './satis-detail.component';

describe('SatisDetailComponent', () => {
  let component: SatisDetailComponent;
  let fixture: ComponentFixture<SatisDetailComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SatisDetailComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SatisDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
