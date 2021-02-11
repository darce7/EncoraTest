import { Property } from '../../../../ViewModels/property'
import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { formatNumber } from '@angular/common';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {

  public properties: Property[];
  public editField: string;
  public _http: HttpClient;
  public _baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Property[]>(baseUrl + 'property').subscribe(result => {
      this.properties = result;
    }, error => console.error(error));

    this._http = http;
    this._baseUrl = baseUrl;
  }

  formatNumber(num) {
    return formatNumber(Number(num), 'en-US', '1.2-2');
  }

  getGrossYield(propertyId: number) {
    const property = this.properties.find(x => x.id == propertyId);
    const grossYield = !!property.financial ? property.financial.monthlyRent * 12 / property.financial.listPrice * 100 : 0;

    return grossYield;
  }

  updateList(propertyId: number, entityName: string, propertyName: string, event: any) {
    const editField = event.target.textContent;
    const propertyToUpdate = this.properties.find(x => x.id == propertyId);
    const propertyIndexToUpdate = this.properties.indexOf(propertyToUpdate);

    if (entityName == undefined || entityName == '') {

      propertyToUpdate[propertyName] = editField;

    } else {

      propertyToUpdate[entityName][propertyName] = editField;

    }

    this.properties.splice(propertyIndexToUpdate, 1, propertyToUpdate);
  }

  changeValue(event: any) {
    this.editField = event.target.textContent;
  }

  save(property: Property) {
    const httpOptions = {
      headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }
    this._http.post(this._baseUrl + 'property', JSON.stringify(property), httpOptions).subscribe();
  }

}
