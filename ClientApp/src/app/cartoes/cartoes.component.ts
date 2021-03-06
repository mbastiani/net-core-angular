import { Component } from '@angular/core';
import { CartoesService } from '../_services/cartoes.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-cartoes-component',
  templateUrl: './cartoes.component.html'
})

export class CartoesComponent {
  title = 'Cartoes';

  constructor(private CartoesService: CartoesService) { }

  data: any;
  CartaoForm: FormGroup;
  submitted = false;
  EventValue: any = "Save";

  ngOnInit(): void {
    this.getdata();
    this.CartaoForm = new FormGroup({
      Id: new FormControl(null),
      NomeTitular: new FormControl("", [Validators.required]),
      NumeroCartao: new FormControl("", [Validators.required]),
      DataExpiracao: new FormControl("", [Validators.required]),
      CVV: new FormControl("", [Validators.required]),
    })
  }

  getdata() {
    this.CartoesService.getData().subscribe((data: any[]) => {
      this.data = data;
    })
  }

  deleteData(id: number) {
    this.CartoesService.deleteData(id).subscribe(() => {
      this.getdata();
    })
  }

  Save() {
    this.submitted = true;
    if (this.CartaoForm.invalid) {
      return;
    }
    this.CartoesService.postData(this.CartaoForm.value).subscribe((data: any[]) => {
      this.data = data;
      this.resetFrom();
    })
  }
  Update() {
    this.submitted = true;
    if (this.CartaoForm.invalid) {
      return;
    }
    this.CartoesService.putData(this.CartaoForm.value.Id, this.CartaoForm.value).subscribe((data: any[]) => {
      this.data = data;
      this.resetFrom();
    })
  }

  EditData(Data: any) {
    this.CartaoForm.controls["Id"].setValue(Data.id);
    this.CartaoForm.controls["NomeTitular"].setValue(Data.nomeTitular);
    this.CartaoForm.controls["NumeroCartao"].setValue(Data.numeroCartao);
    this.CartaoForm.controls["DataExpiracao"].setValue(Data.dataExpiracao);
    this.CartaoForm.controls["CVV"].setValue(Data.cvv);
    this.EventValue = "Update";
  }
  resetFrom() {
    this.getdata();
    this.CartaoForm.reset();
    this.EventValue = "Save";
    this.submitted = false;
  }
}