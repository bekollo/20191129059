import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SatisService } from 'src/app/services/satis.service';
import { CategoryService } from 'src/app/services/category.service';

@Component({
  selector: 'app-create-satis',
  templateUrl: './create-satis.component.html',
  styleUrls: ['./create-satis.component.scss']
})
export class CreateSatisComponent implements OnInit {

  categories$ = this.categoryService.categories$;

  postForm = new FormGroup({
    title: new FormControl('', [Validators.required]),
    description: new FormControl('', [Validators.required]),
    categoryId: new FormControl(-1, [Validators.required])
  })

  constructor(
    private categoryService: CategoryService,
    private satisService: SatisService,
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  createPost() {
    if (this.postForm.valid) {
      const request = {
        ...this.postForm.value
      }

      this.satisService.createPost(request)
        .toPromise()
        .then(result => {
          console.log(result);
        })
        .catch(err => {
          console.error(err);
        })
        .finally(() => {
          // this.postForm.reset();
          this.router.navigateByUrl('/satiss');
        })

    } else {
      alert('Formu eksiksiz doldurunuz.')
    }
  }

}
