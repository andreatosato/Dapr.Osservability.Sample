import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { FruitVegetables } from './reader.model';

@Component({
  selector: 'app-reader',
  templateUrl: './reader.component.html',
  styleUrls: ['./reader.component.scss']
})
export class ReaderComponent implements OnInit {

  public FruitVegetables: FruitVegetables[] = [];
  constructor(private client: HttpClient) { }

  ngOnInit(): void {
    this.refreshData();
  }

  refreshData(){
    this.client.get<FruitVegetables[]>(environment.baseUrl + '/a/FruitVegetables')
    .subscribe((data: FruitVegetables[]) => {
      return this.FruitVegetables = data;
    });
  }

}
