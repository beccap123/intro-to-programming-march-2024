import { Routes } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { TodoListComponent } from './pages/todo-list/todo-list.component';
import { CounterComponent } from './pages/counter/counter.component';

export const routes: Routes = [
  {
    path: 'dashboard',
    component: DashboardComponent,
  },
  {
    path: 'todo-list',
    component: TodoListComponent,
  },
  {
    path: 'counter',
    component: CounterComponent,
  },
  {
    path: '**',
    redirectTo: '/dashboard',
  },
];
