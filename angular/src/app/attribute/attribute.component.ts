import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormArray, Validators, FormGroup } from '@angular/forms';
import { AttSerService } from '../shared/att-ser.service';

@Component({
  selector: 'app-attribute',
  templateUrl: './attribute.component.html',
  styleUrls: []
})
export class AttributeComponent implements OnInit {
  attributeForms : FormArray = this.fb.array([]);
 // attributeValueForms : FormArray = this.fb.array([]);
  attributeList =[];

  constructor(private fb : FormBuilder, private attributeService: AttSerService) { }

  ngOnInit() {
    // this.attributeService.getAttributeList()
      // .subscribe(
      //   res => this.attributeList = res as []
      // );
    this.addAttributeForm();

  }

  addAttributeForm(){
    this.attributeForms.push(this.fb.group({
     //  attribute_code : [''],
     // attribute_value_code : [''],
       description : ['', Validators.required],
       attribute_type : [''],
       entity_type : [''],
       regular_expression :[''],
       sort_order : ['', Validators.required],
       is_active : ['']
  
      }));
  }

  

  recordSubmit(fg:FormGroup){
    this.attributeService.postAttributeList(fg.value)
    .subscribe(
    (res:any) =>{

    }
    )
  
}

}
