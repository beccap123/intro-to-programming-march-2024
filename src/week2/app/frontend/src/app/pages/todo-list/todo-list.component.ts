import { Component } from '@angular/core';
import { TodoEntryComponent } from './components/todo-entry/todo-entry.component';
import { TodoItemListComponent } from './components/todo-item-list/todo-item-list.component';
import { TodoListItem } from './models';

@Component({
  selector: 'app-todo-list',
  standalone: true,
  template: `
    <section>
      <h2 class="text-2xl font-bold">Your Todo List</h2>
    </section>
    <div>
      <app-todo-entry (itemAdded)="addItem($event)" />
    </div>
    <div>
      <app-todo-item-list [list]="todoList" />
    </div>
  `,
  styles: ``,
  imports: [TodoEntryComponent, TodoItemListComponent],
})
export class TodoListComponent {
  addItem(item: { description: string }) {
    const itemToAdd: TodoListItem = {
      id: crypto.randomUUID(),
      description: item.description,
      completed: false,
    };
    this.todoList = [itemToAdd, ...this.todoList];
  }

  todoList: TodoListItem[] = [
    { id: '3', description: 'Learn Signals', completed: false },
    { id: '4', description: 'Learn Redux', completed: true },
  ];
}
