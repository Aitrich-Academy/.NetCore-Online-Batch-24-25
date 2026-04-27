import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-root',
   standalone: true,
  imports: [CommonModule,FormsModule],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  isLoggedIn = false;
  username = "Chinnu";

  toggleLogin() {
    this.isLoggedIn = !this.isLoggedIn;
  }

  //2.Product
    inStock = true;

    //3 shopping cart
    cart = [
  { name: "Shirt", price: 500 },
  { name: "Shoes", price: 1000 },
  { name: "Watch", price: 2000 }
];

removeItem(index: number) {
  this.cart.splice(index, 1);
}


  // 4️ SEARCH FILTER
  searchText = "";
  items = ["Apple", "Banana", "Orange", "Mango"];

  // 5️ USER REGISTRATION PREVIEW
  name = "";
  email = "";

  // 6️ DARK MODE
  isDark = false;

  // 7️ NOTIFICATION BADGE
  notificationCount = 3;

  // 8️ DYNAMIC BUTTON DISABLE
  inputName = "";
  inputEmail = "";

  // 9️ TASK MANAGER
  newTask = "";
  tasks: any[] = [];

  addTask() {
    this.tasks.push({ name: this.newTask, done: false });
    this.newTask = "";
  }

  toggleTask(task: any) {
    task.done = !task.done;
  }

  // 10 PROFILE CARD HIGHLIGHT
  users = ["Anu", "Ravi", "Meena"];
  selectedUser = "";

  selectUser(user: string) {
    this.selectedUser = user;
  }

}