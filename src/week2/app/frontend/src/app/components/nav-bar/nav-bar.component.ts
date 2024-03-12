import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive } from '@angular/router';

@Component({
  selector: 'app-nav-bar',
  standalone: true,
  imports: [RouterLink, RouterLinkActive],
  template: `
    <div role="tablist" class="tabs tabs-bordered mb-4">
      <a
        routerLink="/dashboard"
        role="tab"
        class="tab"
        [routerLinkActive]="['tab-active']"
        >Dashboard</a
      >
      <a
        routerLink="/todo-list"
        role="tab"
        class="tab"
        [routerLinkActive]="['tab-active']"
        >Todo List</a
      >
      <a
        routerLink="/counter"
        role="tab"
        class="tab"
        [routerLinkActive]="['tab-active']"
        >Counter</a
>
    </div>
  `,
  styles: ``,
})
export class NavBarComponent {}
