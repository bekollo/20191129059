import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { GetSatissResponseModel } from '../models/satis.model';
import { SatisService } from '../services/satis.service';

@Component({
  selector: 'app-satiss',
  templateUrl: './satiss.component.html',
  styleUrls: ['./satiss.component.scss'],
})
export class SatissComponent implements OnInit {
  satiss$: Observable<GetSatissResponseModel>;

  constructor(
    private satisService: SatisService
  ) { }

  ngOnInit(): void {
    this.satiss$ = this.satisService.satiss$;
  }
}
