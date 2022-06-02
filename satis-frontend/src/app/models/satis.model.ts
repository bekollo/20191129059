import { Base } from "./base.model";

export interface Satis extends Base {
  title: string;
  description: string;
  viewCount: number;
  categoryId: number;
}

export type GetSatissResponseModel = Satis[];

export interface SatisRequestModel {
  title: string;
  description: string;
  viewCount: number;
  categoryId: number;
}