import { SatisDetailComponent } from './satiss/satis-detail/satis-detail.component';
import { SatissComponent } from './satiss/satiss.component';
import { SignupComponent } from './signup/signup.component';
import { SigninComponent } from './signin/signin.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateSatisComponent } from './admin/create-satis/create-satis.component';
import { CreateCategoryComponent } from './admin/create-category/create-category.component';
import { AuthGuard } from './guards/auth.guard';

const routes: Routes = [
  { path: '', redirectTo: 'signin', pathMatch: 'full' },
  { path: 'signin', component: SigninComponent },
  { path: 'signup', component: SignupComponent },
  { path: 'satiss', component: SatissComponent, canActivate: [AuthGuard] },
  { path: 'satis-detail', component: SatisDetailComponent, canActivate: [AuthGuard] },
  { path: 'create-post', component: CreateSatisComponent, canActivate: [AuthGuard] },
  { path: 'create-category', component: CreateCategoryComponent, canActivate: [AuthGuard] },
  { path: '**', redirectTo: 'satiss' }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule { }
