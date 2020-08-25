import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AttSerService {

  constructor(private http: HttpClient) { }

  // getAttributeList(){
  //   return this.http.get(environment.apiBaseUrl + '/attributes');
  // }

  postAttributeList(formData){
    return this.http.post(environment.apiBaseUrl + '/attributes',
    
    formData);
  }

  // postAttributeValueList(formData){
  //   return this.http.post(environment.apiBaseUrl + '/attribute_value', formData);
  // }
  

  

}
