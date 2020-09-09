import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
    providedIn: 'root'
})

export class CartoesService {

    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json'
        })
    }
    getData() {
        return this.http.get(this.baseUrl + 'api/cartoes');
    }
    postData(formData: any) {
        return this.http.post(this.baseUrl + 'api/cartoes', formData);
    }
    putData(id: number, formData: any) {
        return this.http.put(this.baseUrl + 'api/cartoes/' + id, formData);
    }

    deleteData(id: number) {
        return this.http.delete(this.baseUrl + 'api/cartoes/' + id);
    }
}