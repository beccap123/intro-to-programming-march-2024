import { Component, Input } from '@angular/core';
import { TodoListItem } from '../../models';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-todo-item-list',
  standalone: true,
  imports: [NgClass],
  template: `
    <ul>
      @for(item of list; track item.id) {
      <li class="card bg-base-300 shadow-xl mb-4">
        <div class="card-body">
          <span [ngClass]="{ 'line-through': item.completed }">{{
            item.description
          }}</span>
          <div class="card-actions justify-end">
            @if(item.completed === false) {
            <button (click)="markComplete(item)" class="btn btn-sm btn-primary">
              X
            </button>
            } @else {
            <button
              (click)="markIncomplete(item)"
              class="btn btn-sm btn-accent"
            >
              +
            </button>
            }
          </div>
        </div>
      </li>
      }
    </ul>
  `,
  styles: `
 
  `,
})
export class TodoItemListComponent {

  @Input({ required: true }) list: TodoListItem[] = [];

  markComplete(item: TodoListItem) {
    item.completed = true;
  }
  markIncomplete(item: TodoListItem) {
    item.completed = false;
  }
}
