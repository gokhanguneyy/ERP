import { Injectable } from '@angular/core';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root'
})
export class SwalService {

  constructor() { }

  callToast(title: string, icon: SweetAlertIcon = "success") {
    Swal.fire({
      position: 'bottom-right',
      icon: icon,
      title: title,
      text: "",
      toast: true,
      showConfirmButton: false,
      timer: 3000
    });
  }

  callSwal(title: string, text: string, callBack:()=> void, confirmButtonText: string = "Sil", icon: SweetAlertIcon = "question") {
    Swal.fire({
      title: title,
      text: text,
      showConfirmButton: true,
      showCancelButton: true,
      icon: icon,
      confirmButtonText: confirmButtonText,
      cancelButtonText: 'Vazgeç'
    }).then(res=> {
      if(res.isConfirmed){
        callBack();
      }
    })
  }
}

export type SweetAlertIcon = 'success' | 'error' | 'warning' | 'info' | 'question';
