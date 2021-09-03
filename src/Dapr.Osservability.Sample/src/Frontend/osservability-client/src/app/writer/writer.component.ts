import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';
import { environment } from 'src/environments/environment';
import { FruitVegetables, FruitVegetableType } from '../reader/reader.model';

@Component({
  selector: 'app-writer',
  templateUrl: './writer.component.html',
  styleUrls: ['./writer.component.scss']
})
export class WriterComponent implements OnInit {
  public FruitVegetable: FruitVegetables = new FruitVegetables();
  frmFruitVegetable!: FormGroup;
  date!: NgbDateStruct;
  states = [
    {name: 'Fruit', value: 0},
    {name: 'Vegetable', value: 1}
  ];

  constructor(private client: HttpClient, private _fb: FormBuilder,) { }

  ngOnInit(): void {
    this.frmFruitVegetable = this._fb.group({  
      temperature: 0,
      name: ['', Validators.required],
      description: ['', Validators.required],
      quantity: [1, Validators.min(1)],
      type: FruitVegetableType.Fruit  
    });  
  }

  onSubmit(){
    console.log(this.frmFruitVegetable.value);
    console.log(this.date);

    this.client.post(environment.baseUrl + '/a/FruitVegetables', this.frmFruitVegetable.value)
    .subscribe(t => console.log(t));
  }

}
